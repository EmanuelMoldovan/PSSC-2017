namespace Chat
{
    partial class Chat
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chatBox = new MetroFramework.Controls.MetroTextBox();
            this.msgBox = new MetroFramework.Controls.MetroTextBox();
            this.sendButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.newChatButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 132);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "User:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(73, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 1;
            // 
            // chatBox
            // 
            // 
            // 
            // 
            this.chatBox.CustomButton.Image = null;
            this.chatBox.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.chatBox.CustomButton.Name = "";
            this.chatBox.CustomButton.Size = new System.Drawing.Size(161, 161);
            this.chatBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chatBox.CustomButton.TabIndex = 1;
            this.chatBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chatBox.CustomButton.UseSelectable = true;
            this.chatBox.CustomButton.Visible = false;
            this.chatBox.Enabled = false;
            this.chatBox.Lines = new string[0];
            this.chatBox.Location = new System.Drawing.Point(10, 166);
            this.chatBox.MaxLength = 32767;
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.PasswordChar = '\0';
            this.chatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatBox.SelectedText = "";
            this.chatBox.SelectionLength = 0;
            this.chatBox.SelectionStart = 0;
            this.chatBox.ShortcutsEnabled = true;
            this.chatBox.Size = new System.Drawing.Size(329, 166);
            this.chatBox.TabIndex = 2;
            this.chatBox.UseSelectable = true;
            this.chatBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chatBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // msgBox
            // 
            // 
            // 
            // 
            this.msgBox.CustomButton.Image = null;
            this.msgBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.msgBox.CustomButton.Name = "";
            this.msgBox.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.msgBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.msgBox.CustomButton.TabIndex = 1;
            this.msgBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.msgBox.CustomButton.UseSelectable = true;
            this.msgBox.CustomButton.Visible = false;
            this.msgBox.Lines = new string[0];
            this.msgBox.Location = new System.Drawing.Point(10, 338);
            this.msgBox.MaxLength = 32767;
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.PasswordChar = '\0';
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.msgBox.SelectedText = "";
            this.msgBox.SelectionLength = 0;
            this.msgBox.SelectionStart = 0;
            this.msgBox.ShortcutsEnabled = true;
            this.msgBox.Size = new System.Drawing.Size(221, 45);
            this.msgBox.TabIndex = 3;
            this.msgBox.UseSelectable = true;
            this.msgBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.msgBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sendButton
            // 
            this.sendButton.Highlight = true;
            this.sendButton.Location = new System.Drawing.Point(237, 338);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(102, 45);
            this.sendButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sendButton.UseSelectable = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Highlight = true;
            this.clearButton.Location = new System.Drawing.Point(290, 132);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(49, 27);
            this.clearButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Username:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(88, 72);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(197, 26);
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addButton
            // 
            this.addButton.Highlight = true;
            this.addButton.Location = new System.Drawing.Point(291, 72);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(49, 27);
            this.addButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // newChatButton
            // 
            this.newChatButton.Highlight = true;
            this.newChatButton.Location = new System.Drawing.Point(237, 389);
            this.newChatButton.Name = "newChatButton";
            this.newChatButton.Size = new System.Drawing.Size(102, 27);
            this.newChatButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newChatButton.TabIndex = 9;
            this.newChatButton.Text = "New Chat";
            this.newChatButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newChatButton.UseSelectable = true;
            this.newChatButton.Click += new System.EventHandler(this.newChatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newChatButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox chatBox;
        private MetroFramework.Controls.MetroTextBox msgBox;
        private MetroFramework.Controls.MetroButton sendButton;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton newChatButton;
        private System.Windows.Forms.Label label1;
    }
}

