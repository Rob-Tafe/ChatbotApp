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
            // 
            // TbChat
            // 
            this.TbChat.Location = new System.Drawing.Point(20, 60);
            this.TbChat.Multiline = true;
            this.TbChat.Name = "TbChat";
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
            // ChatbotApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 181);
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
    }
}

