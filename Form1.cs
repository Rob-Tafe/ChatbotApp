using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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



    class chatProgram
    {
        static MLContext cbContext;
        static Microsoft.ML.Data.TransformerChain<Microsoft.ML.Transforms.KeyToValueMappingTransformer> ChatModel;
        static IEnumerable<ChatModelClass> chatTrainingData;
        static IEnumerable<ChatModelClass> chatTestingData;
        static String chatbotFileName = "ChatModel.zip";
    }


    public class ChatModelClass
    {
        [ColumnName("Question"), LoadColumn(0)]
        public string Question { get; set; }
        [ColumnName("Answer"), LoadColumn(1)]
        public string Answer { get; set; }
    }


    public class ChatbotPredictionModel
    {
        [ColumnName("PredictedAnswer")]
        public string PredictedAnswer { get; set; }

        [ColumnName("Score")]
        public float[] Score { get; set; }
    }


} // End of ChatbotApp namespace.
