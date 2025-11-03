namespace ChatbotApp
{
    partial class ChatbotApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbInput = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TbChat = new System.Windows.Forms.TextBox();
            this.TbFeedback = new System.Windows.Forms.TextBox();
            this.BtnRebuild = new System.Windows.Forms.Button();
            this.LabInput = new System.Windows.Forms.Label();
            this.LabOutput = new System.Windows.Forms.Label();
            this.LabFeedback = new System.Windows.Forms.Label();
            this.BtnSaveModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbInput
            // 
            this.TbInput.Location = new System.Drawing.Point(20, 20);
            this.TbInput.Name = "TbInput";
            this.TbInput.Size = new System.Drawing.Size(400, 20);
            this.TbInput.TabIndex = 0;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(445, 20);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 20);
            this.BtnEnter.TabIndex = 1;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TbChat
            // 
            this.TbChat.Location = new System.Drawing.Point(20, 60);
            this.TbChat.Multiline = true;
            this.TbChat.Name = "TbChat";
            this.TbChat.ReadOnly = true;
            this.TbChat.Size = new System.Drawing.Size(500, 40);
            this.TbChat.TabIndex = 2;
            // 
            // TbFeedback
            // 
            this.TbFeedback.Location = new System.Drawing.Point(20, 120);
            this.TbFeedback.Multiline = true;
            this.TbFeedback.Name = "TbFeedback";
            this.TbFeedback.ReadOnly = true;
            this.TbFeedback.Size = new System.Drawing.Size(370, 40);
            this.TbFeedback.TabIndex = 3;
            // 
            // BtnRebuild
            // 
            this.BtnRebuild.Location = new System.Drawing.Point(410, 120);
            this.BtnRebuild.Name = "BtnRebuild";
            this.BtnRebuild.Size = new System.Drawing.Size(110, 40);
            this.BtnRebuild.TabIndex = 4;
            this.BtnRebuild.Text = "Load Training Data and Rebuild Model";
            this.BtnRebuild.UseVisualStyleBackColor = true;
            // 
            // LabInput
            // 
            this.LabInput.AutoSize = true;
            this.LabInput.Location = new System.Drawing.Point(20, 5);
            this.LabInput.Name = "LabInput";
            this.LabInput.Size = new System.Drawing.Size(106, 13);
            this.LabInput.TabIndex = 5;
            this.LabInput.Text = "Enter Question Here:";
            // 
            // LabOutput
            // 
            this.LabOutput.AutoSize = true;
            this.LabOutput.Location = new System.Drawing.Point(20, 45);
            this.LabOutput.Name = "LabOutput";
            this.LabOutput.Size = new System.Drawing.Size(111, 13);
            this.LabOutput.TabIndex = 6;
            this.LabOutput.Text = "Chatbot Answer Here:";
            // 
            // LabFeedback
            // 
            this.LabFeedback.AutoSize = true;
            this.LabFeedback.Location = new System.Drawing.Point(20, 105);
            this.LabFeedback.Name = "LabFeedback";
            this.LabFeedback.Size = new System.Drawing.Size(153, 13);
            this.LabFeedback.TabIndex = 7;
            this.LabFeedback.Text = "Accuracy and Feedback Here:";
            // 
            // BtnSaveModel
            // 
            this.BtnSaveModel.Location = new System.Drawing.Point(23, 180);
            this.BtnSaveModel.Name = "BtnSaveModel";
            this.BtnSaveModel.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveModel.TabIndex = 8;
            this.BtnSaveModel.Text = "Save Model";
            this.BtnSaveModel.UseVisualStyleBackColor = true;
            this.BtnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // ChatbotApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 221);
            this.Controls.Add(this.BtnSaveModel);
            this.Controls.Add(this.LabFeedback);
            this.Controls.Add(this.LabOutput);
            this.Controls.Add(this.LabInput);
            this.Controls.Add(this.BtnRebuild);
            this.Controls.Add(this.TbFeedback);
            this.Controls.Add(this.TbChat);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TbInput);
            this.Name = "ChatbotApp";
            this.Text = "ChatbotApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbInput;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.TextBox TbChat;
        private System.Windows.Forms.TextBox TbFeedback;
        private System.Windows.Forms.Button BtnRebuild;
        private System.Windows.Forms.Label LabInput;
        private System.Windows.Forms.Label LabOutput;
        private System.Windows.Forms.Label LabFeedback;
        private System.Windows.Forms.Button BtnSaveModel;
    }
}

