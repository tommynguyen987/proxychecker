namespace ProxyChecker
{
    partial class Main
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
            this.loadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.threadBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeoutbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.proxyList = new System.Windows.Forms.ListBox();
            this.checkedList = new System.Windows.Forms.ListBox();
            this.respondingLable = new System.Windows.Forms.Label();
            this.proxyLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 221);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(117, 221);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 250);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(213, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(231, 250);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(213, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Location = new System.Drawing.Point(336, 221);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(108, 23);
            this.clearButton2.TabIndex = 6;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(231, 221);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server";
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(15, 291);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(116, 20);
            this.serverBox.TabIndex = 9;
            this.serverBox.Text = "http://www.yahoo.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Threads";
            // 
            // threadBox
            // 
            this.threadBox.Location = new System.Drawing.Point(140, 291);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(29, 20);
            this.threadBox.TabIndex = 11;
            this.threadBox.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Timeout";
            // 
            // timeoutbox
            // 
            this.timeoutbox.Location = new System.Drawing.Point(192, 291);
            this.timeoutbox.Name = "timeoutbox";
            this.timeoutbox.Size = new System.Drawing.Size(66, 20);
            this.timeoutbox.TabIndex = 13;
            this.timeoutbox.Text = "8000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status:";
            // 
            // statusBox
            // 
            this.statusBox.Enabled = false;
            this.statusBox.Location = new System.Drawing.Point(12, 330);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(432, 20);
            this.statusBox.TabIndex = 15;
            // 
            // proxyList
            // 
            this.proxyList.FormattingEnabled = true;
            this.proxyList.Location = new System.Drawing.Point(12, 26);
            this.proxyList.Name = "proxyList";
            this.proxyList.Size = new System.Drawing.Size(213, 186);
            this.proxyList.TabIndex = 16;
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(231, 26);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(213, 186);
            this.checkedList.TabIndex = 17;
            // 
            // respondingLable
            // 
            this.respondingLable.AutoSize = true;
            this.respondingLable.Location = new System.Drawing.Point(228, 9);
            this.respondingLable.Name = "respondingLable";
            this.respondingLable.Size = new System.Drawing.Size(115, 13);
            this.respondingLable.TabIndex = 18;
            this.respondingLable.Text = "Responding proxies : 0";
            // 
            // proxyLable
            // 
            this.proxyLable.AutoSize = true;
            this.proxyLable.Location = new System.Drawing.Point(9, 9);
            this.proxyLable.Name = "proxyLable";
            this.proxyLable.Size = new System.Drawing.Size(47, 13);
            this.proxyLable.TabIndex = 19;
            this.proxyLable.Text = "Proxies :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 356);
            this.Controls.Add(this.proxyLable);
            this.Controls.Add(this.respondingLable);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.proxyList);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeoutbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.threadBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Proxy Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox threadBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeoutbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.ListBox proxyList;
        private System.Windows.Forms.ListBox checkedList;
        private System.Windows.Forms.Label respondingLable;
        private System.Windows.Forms.Label proxyLable;
    }
}

