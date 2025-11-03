using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        // This is the method that will recieve a user's question, send it to
        // the chatbot model, receive an answer from the model, and return that answer
        // to the user.
        public void chatModel(String chatQuestion)
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
            chatModel(TbInput.Text);

        } // End of BtnEnter_Click method.

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {

        } // EndOfStreamException of BtnSaveModel_Click method.

        //private static void modelSave()
        //{
        //    MLContext chatbotContext = new MLContext();


        //    chatbotContext.Model.Save(ChatModel, DataSetSchemaImporterExtension, chatbotModelPath);
        //}

    } // End of ChatbotApp : Form partial class.


} // End of ChatbotApp namespace.
