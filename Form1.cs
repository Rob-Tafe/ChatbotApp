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
        public static void chatModel()
        {
            //Load sample data
            var sampleData = new ChatModel.ModelInput()
            {
                Question = @"What is Machine Learning (ML)?",
            };

            //Load model and predict output
            var result = ChatModel.Predict(sampleData);

        } // End of chatModel method.

    } // End of ChatbotApp : Form partial class.

} // End of ChatbotApp namespace.
