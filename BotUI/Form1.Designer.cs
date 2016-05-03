namespace BotUI
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
            this.btnTestBot = new System.Windows.Forms.Button();
            this.btnGetUpdates = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestBot
            // 
            this.btnTestBot.Location = new System.Drawing.Point(13, 368);
            this.btnTestBot.Name = "btnTestBot";
            this.btnTestBot.Size = new System.Drawing.Size(75, 23);
            this.btnTestBot.TabIndex = 0;
            this.btnTestBot.Text = "Test bot";
            this.btnTestBot.UseVisualStyleBackColor = true;
            this.btnTestBot.Click += new System.EventHandler(this.btnTestBot_Click);
            // 
            // btnGetUpdates
            // 
            this.btnGetUpdates.Location = new System.Drawing.Point(95, 368);
            this.btnGetUpdates.Name = "btnGetUpdates";
            this.btnGetUpdates.Size = new System.Drawing.Size(75, 23);
            this.btnGetUpdates.TabIndex = 1;
            this.btnGetUpdates.Text = "Get updates";
            this.btnGetUpdates.UseVisualStyleBackColor = true;
            this.btnGetUpdates.Click += new System.EventHandler(this.btnGetUpdates_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(177, 368);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 2;
            this.btnSendMsg.Text = "Send msg";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(13, 13);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(636, 349);
            this.txtMessages.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 403);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnGetUpdates);
            this.Controls.Add(this.btnTestBot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestBot;
        private System.Windows.Forms.Button btnGetUpdates;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtMessages;
    }
}

