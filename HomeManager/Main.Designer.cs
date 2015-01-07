namespace HomeManager
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTwoThreads = new System.Windows.Forms.RadioButton();
            this.rbOneThread = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.rbThreeThreads = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(87, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbThreeThreads);
            this.groupBox2.Controls.Add(this.rbTwoThreads);
            this.groupBox2.Controls.Add(this.rbOneThread);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Threads";
            // 
            // rbTwoThreads
            // 
            this.rbTwoThreads.AutoSize = true;
            this.rbTwoThreads.Location = new System.Drawing.Point(7, 40);
            this.rbTwoThreads.Name = "rbTwoThreads";
            this.rbTwoThreads.Size = new System.Drawing.Size(31, 17);
            this.rbTwoThreads.TabIndex = 1;
            this.rbTwoThreads.Text = "2";
            this.rbTwoThreads.UseVisualStyleBackColor = true;
            // 
            // rbOneThread
            // 
            this.rbOneThread.AutoSize = true;
            this.rbOneThread.Checked = true;
            this.rbOneThread.Location = new System.Drawing.Point(7, 19);
            this.rbOneThread.Name = "rbOneThread";
            this.rbOneThread.Size = new System.Drawing.Size(31, 17);
            this.rbOneThread.TabIndex = 0;
            this.rbOneThread.TabStop = true;
            this.rbOneThread.Text = "1";
            this.rbOneThread.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbResult);
            this.groupBox3.Location = new System.Drawing.Point(13, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(7, 15);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(187, 79);
            this.tbResult.TabIndex = 0;
            // 
            // rbThreeThreads
            // 
            this.rbThreeThreads.AutoSize = true;
            this.rbThreeThreads.Location = new System.Drawing.Point(7, 63);
            this.rbThreeThreads.Name = "rbThreeThreads";
            this.rbThreeThreads.Size = new System.Drawing.Size(31, 17);
            this.rbThreeThreads.TabIndex = 2;
            this.rbThreeThreads.TabStop = true;
            this.rbThreeThreads.Text = "3";
            this.rbThreeThreads.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Home Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTwoThreads;
        private System.Windows.Forms.RadioButton rbOneThread;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.RadioButton rbThreeThreads;
    }
}

