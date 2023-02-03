namespace SharkChat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(101, 94);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(100, 23);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(101, 31);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(100, 23);
            this.textLocalIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(365, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(105, 94);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(100, 23);
            this.textRemotePort.TabIndex = 4;
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Location = new System.Drawing.Point(105, 31);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(100, 23);
            this.textRemoteIP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(699, 93);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(97, 44);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(42, 672);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(714, 23);
            this.textMessage.TabIndex = 3;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 15;
            this.listMessage.Location = new System.Drawing.Point(42, 237);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(812, 409);
            this.listMessage.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(779, 672);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 739);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chat App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonConnect;
        private Label label2;
        private Label label1;
        private TextBox textLocalPort;
        private TextBox textLocalIP;
        private TextBox textRemotePort;
        private TextBox textRemoteIP;
        private Label label4;
        private Label label3;
        private TextBox textMessage;
        private ListBox listMessage;
        private Button buttonSend;
    }
}