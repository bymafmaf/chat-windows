namespace Lab1
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
            this.connect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.myIPBox = new System.Windows.Forms.TextBox();
            this.targetIPBox = new System.Windows.Forms.TextBox();
            this.newInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chatHistory = new System.Windows.Forms.ListBox();
            this.myPort = new System.Windows.Forms.NumericUpDown();
            this.targetPort = new System.Windows.Forms.NumericUpDown();
            this.username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPort)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(407, 135);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(630, 360);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(711, 359);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // myIPBox
            // 
            this.myIPBox.Location = new System.Drawing.Point(128, 83);
            this.myIPBox.Name = "myIPBox";
            this.myIPBox.Size = new System.Drawing.Size(193, 20);
            this.myIPBox.TabIndex = 3;
            // 
            // targetIPBox
            // 
            this.targetIPBox.Location = new System.Drawing.Point(407, 83);
            this.targetIPBox.Name = "targetIPBox";
            this.targetIPBox.Size = new System.Drawing.Size(246, 20);
            this.targetIPBox.TabIndex = 5;
            // 
            // newInputBox
            // 
            this.newInputBox.Location = new System.Drawing.Point(128, 362);
            this.newInputBox.Name = "newInputBox";
            this.newInputBox.Size = new System.Drawing.Size(488, 20);
            this.newInputBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Windows P2P Chat ";
            // 
            // chatHistory
            // 
            this.chatHistory.FormattingEnabled = true;
            this.chatHistory.Location = new System.Drawing.Point(128, 170);
            this.chatHistory.Name = "chatHistory";
            this.chatHistory.Size = new System.Drawing.Size(658, 186);
            this.chatHistory.TabIndex = 9;
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(128, 110);
            this.myPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(120, 20);
            this.myPort.TabIndex = 10;
            // 
            // targetPort
            // 
            this.targetPort.Location = new System.Drawing.Point(407, 110);
            this.targetPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.targetPort.Name = "targetPort";
            this.targetPort.Size = new System.Drawing.Size(120, 20);
            this.targetPort.TabIndex = 11;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(128, 137);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 481);
            this.Controls.Add(this.username);
            this.Controls.Add(this.targetPort);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.chatHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newInputBox);
            this.Controls.Add(this.targetIPBox);
            this.Controls.Add(this.myIPBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox myIPBox;
        private System.Windows.Forms.TextBox targetIPBox;
        private System.Windows.Forms.TextBox newInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox chatHistory;
        private System.Windows.Forms.NumericUpDown myPort;
        private System.Windows.Forms.NumericUpDown targetPort;
        private System.Windows.Forms.TextBox username;
    }
}

