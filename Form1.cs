using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public ChatbotApp()
        {
            InitializeComponent();
        }

        private void ChatbotApp_Load(object sender, EventArgs e)
        {
            AutoLoadChatModel();
        }


        static MLContext chatModelContext;
        static string chatbotFileName = "ChatModel.zip";

        static ITransformer loadedModel;
        static DataViewSchema loadedModelSchema;


        // This is the method that will recieve a user's question, send it to
        // the chatbot model, receive an answer from the model, and return that answer
        // to the user.
        public void askChatModel(String chatQuestion)
        {
            //Load sample data
            var sampleData = new ChatModel.ModelInput()
            {
                Question = chatQuestion,
            };

            //Load model and predict output
            var result = ChatModel.Predict(sampleData);
            TbChat.Text = $"{result.PredictedLabel}";
            TbFeedback.Text = $"Model Confidence (Label score): {result.Score.Max()}";

        } // End of chatModel method.

        // This method will send the text in the TbInput textbox to the chatbot model as 
        // a question and run the chatModel method when the 'Enter' button is clicked.
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            askChatModel(TbInput.Text);

        } // End of BtnEnter_Click method.

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {
            modelSave();
        } // EndOfStreamException of BtnSaveModel_Click method.

        private void modelSave()
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
        }

        private void AutoLoadChatModel()
        {
            chatModelContext = new MLContext();

            loadedModel = chatModelContext.Model.Load(chatbotFileName, out loadedModelSchema);

            TbFeedback.Text = $"{chatbotFileName} loaded as default.";
        }

        private void BtnRebuild_Click(object sender, EventArgs e)
        {

        }

        private static void modelLoad()
        {
            using (OpenFileDialog loadModelZip = new OpenFileDialog())
            {

            }

        
    } // End of ChatbotApp : Form partial class.


} // End of ChatbotApp namespace.
