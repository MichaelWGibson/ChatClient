namespace ChatClient
{
    partial class Form1
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
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(12, 12);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(932, 732);
            this.listBoxMessages.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(13, 763);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(750, 90);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(770, 763);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(174, 90);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 865);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.listBoxMessages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
    }
}

