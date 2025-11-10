/*
 * Author:      Robert Sewell 
 * Student ID:  P214430
 * Date:        04/11/2025
 * 
 * Unit:        Cluster - Artificial Intelligence Skill Set
 * Project:     Assessment 3 - Task 3 - Build a Chatbot
 */

using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatbotApp
{

    public partial class ChatbotApp : Form
    {

        // This initialises our form.
        public ChatbotApp()
        {
            InitializeComponent();
        } // End of ChatbotApp.

        // This is the method that runs immediately on form loading.
        private void ChatbotApp_Load(object sender, EventArgs e)
        {
            AutoLoadChatModel();
        } // End of ChatbotApp_Load method.

        // These are the fields that govern the chatbot app, most methods refer to,
        // or modify these fields as required.
        static MLContext chatModelContext = new MLContext();
        static string chatbotFileName = "ChatModel.zip";

        static ITransformer loadedModel;
        static DataViewSchema loadedModelSchema;

        static PredictionEngine<ChatModel.ModelInput, ChatModel.ModelOutput> predictEng;
        // End of chatbot fields

        // This is the method that will recieve a user's question, send it to
        // the chatbot model, receive an answer from the model, and return that answer
        // to the user.
        public void AskChatModel(String chatQuestion)
        {
            //Load sample data
            var chatInput = new ChatModel.ModelInput
            {
                Question = chatQuestion,
            };

            //Load model and predict output
            var result = predictEng.Predict(chatInput);

            if (result.Score.Max() >= 0.2) {
                TbChat.Text = $"{result.PredictedLabel}";
                TbFeedback.Text = $"Model Confidence (Label score): {result.Score.Max():F2}";
            }
            else {
                TbChat.Text = $"Sorry, I am not confident that I have an accurate answer to your question :(";
                TbFeedback.Text = $"Model Confidence (Label score): {result.Score.Max():F2}, (Cut off: 0.2)";
            }

        } // End of chatModel method.

        // This method will send the text in the TbInput textbox to the chatbot model as 
        // a question and run the chatModel method when the 'Enter' button is clicked.
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            AskChatModel(TbInput.Text);

        } // End of BtnEnter_Click method.

        // This is the method that will call our save function
        private void BtnSaveModel_Click(object sender, EventArgs e)
        {
            ModelSave();
        } // End of BtnSaveModel_Click method.

        // This method was used to save the ChatModel.mlnet as a zip file for
        // portability.
        private void ModelSave()
        {
            chatModelContext = new MLContext();

            ITransformer trainedChatModel;
            DataViewSchema chatModelSchema;

            using (var fileStream = new FileStream("ChatModel.mlnet", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                trainedChatModel = chatModelContext.Model.Load(fileStream, out chatModelSchema);
            }

            string zipFilePath = chatbotFileName;
            using (var fileStream = new FileStream(zipFilePath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                chatModelContext.Model.Save(trainedChatModel, chatModelSchema, fileStream);
            }

            TbFeedback.Text = $"Model saved to {zipFilePath}";
        } // End of ModelSave method.

        // This method automatically loads the default model for use in the chatbot.
        private void AutoLoadChatModel()
        {
            string defaultModelPath = Path.Combine(Application.StartupPath, chatbotFileName);
            BuildModel(defaultModelPath);
        } // End of AutoLoadChatModel method.

        // This method calls our ModelLoadRebuild method.
        private void BtnRebuild_Click(object sender, EventArgs e)
        {
            ModelLoadRebuild();
        } // End of BtnRebuild_Click method.

        // This method allows a user to select a different model for use in
        // the chatbot, and rebuilds it automatically once they have chosen a file.
        private void ModelLoadRebuild()
        {
            if (chatModelContext == null)
            {
                chatModelContext = new MLContext();
            }

            TbFeedback.Text = "Select a .zip file to rebuild the Chatbot with.";

            using (OpenFileDialog loadModel = new OpenFileDialog())
            {
                loadModel.InitialDirectory = Application.StartupPath;
                loadModel.Title = "Select Model to Load & Rebuild Chatbot with";
                loadModel.Filter = "ZIP files|*.zip";

                if (loadModel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                    
                string selectedModelPath = loadModel.FileName;
                {
                    try
                    {
                        BuildModel(selectedModelPath);
                    }
                    catch (Exception ex)
                    {
                        TbFeedback.Text = $"Error: Could not read file from disk. {ex.Message}";
                    }
                }
            }
        } // End of ModelLoadRebuild method.

        // This method builds the model that was selected or automatically loaded
        // by either the ModelLoadRebuild or AutoLoadChatModel methods.
        private void BuildModel(string zipFilePath)
        {
            loadedModel = chatModelContext.Model.Load(zipFilePath, out loadedModelSchema);
            predictEng = chatModelContext.Model.CreatePredictionEngine<ChatModel.ModelInput, ChatModel.ModelOutput>(loadedModel);
            TbFeedback.Text = $"Model loaded: {Path.GetFileName(zipFilePath)}";
            TbChat.Clear();
        } // End of BuildModel method.

        // This method calls the AskChatModel when the enter key is pressed
        // in the TbInput textbox.
        private void TbInput_KeyDown(object sender, KeyEventArgs enterPressed)
        {
            if (enterPressed.KeyCode == Keys.Enter)
            {
                AskChatModel(TbInput.Text);
                enterPressed.SuppressKeyPress = true;
                enterPressed.Handled = true;
            }
        } // End of TbInput_KeyDown method.


    } // End of ChatbotApp : Form partial class.


} // End of ChatbotApp namespace.
