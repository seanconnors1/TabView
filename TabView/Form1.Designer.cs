namespace TabView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.botSortChoice = new System.Windows.Forms.ComboBox();
            this.botQueryInputBox = new System.Windows.Forms.TextBox();
            this.getButtonBot = new System.Windows.Forms.Button();
            this.botOutPutBox = new System.Windows.Forms.TextBox();
            this.topSortChoice = new System.Windows.Forms.ComboBox();
            this.topQueryInputBox = new System.Windows.Forms.TextBox();
            this.getButtonTop = new System.Windows.Forms.Button();
            this.topOutPutBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1243, 820);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "loginPage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.submitButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1243, 820);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "surveyPage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(6, 215);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(137, 54);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Who did you speak to?";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "",
            "CEO",
            "President",
            "CFO",
            "Manager",
            "Employee",
            "Other"});
            this.comboBox3.Location = new System.Drawing.Point(6, 166);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Is this a small buisness?";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(8, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "How would you rate this buisness?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "N/A"});
            this.comboBox1.Location = new System.Drawing.Point(8, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.botSortChoice);
            this.tabPage3.Controls.Add(this.botQueryInputBox);
            this.tabPage3.Controls.Add(this.getButtonBot);
            this.tabPage3.Controls.Add(this.botOutPutBox);
            this.tabPage3.Controls.Add(this.topSortChoice);
            this.tabPage3.Controls.Add(this.topQueryInputBox);
            this.tabPage3.Controls.Add(this.getButtonTop);
            this.tabPage3.Controls.Add(this.topOutPutBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1243, 820);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JSONPage";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // botSortChoice
            // 
            this.botSortChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botSortChoice.FormattingEnabled = true;
            this.botSortChoice.Items.AddRange(new object[] {
            "",
            "Alphabetically",
            "Newest First",
            "Oldest First"});
            this.botSortChoice.Location = new System.Drawing.Point(889, 405);
            this.botSortChoice.Name = "botSortChoice";
            this.botSortChoice.Size = new System.Drawing.Size(209, 28);
            this.botSortChoice.TabIndex = 7;
            // 
            // botQueryInputBox
            // 
            this.botQueryInputBox.Location = new System.Drawing.Point(85, 397);
            this.botQueryInputBox.Name = "botQueryInputBox";
            this.botQueryInputBox.Size = new System.Drawing.Size(786, 26);
            this.botQueryInputBox.TabIndex = 6;
            // 
            // getButtonBot
            // 
            this.getButtonBot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getButtonBot.Location = new System.Drawing.Point(1104, 388);
            this.getButtonBot.Name = "getButtonBot";
            this.getButtonBot.Size = new System.Drawing.Size(131, 45);
            this.getButtonBot.TabIndex = 5;
            this.getButtonBot.Text = "Get";
            this.getButtonBot.UseVisualStyleBackColor = true;
            this.getButtonBot.Click += new System.EventHandler(this.getButtonBot_Click);
            // 
            // botOutPutBox
            // 
            this.botOutPutBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botOutPutBox.Location = new System.Drawing.Point(3, 436);
            this.botOutPutBox.Multiline = true;
            this.botOutPutBox.Name = "botOutPutBox";
            this.botOutPutBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.botOutPutBox.Size = new System.Drawing.Size(1232, 327);
            this.botOutPutBox.TabIndex = 4;
            // 
            // topSortChoice
            // 
            this.topSortChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topSortChoice.FormattingEnabled = true;
            this.topSortChoice.Items.AddRange(new object[] {
            "",
            "Alphabetically",
            "Newest First",
            "Oldest First"});
            this.topSortChoice.Location = new System.Drawing.Point(894, 20);
            this.topSortChoice.Name = "topSortChoice";
            this.topSortChoice.Size = new System.Drawing.Size(209, 28);
            this.topSortChoice.TabIndex = 3;
            // 
            // topQueryInputBox
            // 
            this.topQueryInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.topQueryInputBox.Location = new System.Drawing.Point(85, 12);
            this.topQueryInputBox.Name = "topQueryInputBox";
            this.topQueryInputBox.Size = new System.Drawing.Size(791, 26);
            this.topQueryInputBox.TabIndex = 2;
            // 
            // getButtonTop
            // 
            this.getButtonTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getButtonTop.Location = new System.Drawing.Point(1109, 3);
            this.getButtonTop.Name = "getButtonTop";
            this.getButtonTop.Size = new System.Drawing.Size(131, 45);
            this.getButtonTop.TabIndex = 1;
            this.getButtonTop.Text = "Get";
            this.getButtonTop.UseVisualStyleBackColor = true;
            this.getButtonTop.Click += new System.EventHandler(this.getButtonTop_Click);
            // 
            // topOutPutBox
            // 
            this.topOutPutBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topOutPutBox.Location = new System.Drawing.Point(8, 51);
            this.topOutPutBox.Multiline = true;
            this.topOutPutBox.Name = "topOutPutBox";
            this.topOutPutBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.topOutPutBox.Size = new System.Drawing.Size(1232, 327);
            this.topOutPutBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 871);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button getButtonTop;
        private System.Windows.Forms.TextBox topOutPutBox;
        private System.Windows.Forms.TextBox topQueryInputBox;
        private System.Windows.Forms.ComboBox topSortChoice;
        private System.Windows.Forms.ComboBox botSortChoice;
        private System.Windows.Forms.TextBox botQueryInputBox;
        private System.Windows.Forms.Button getButtonBot;
        private System.Windows.Forms.TextBox botOutPutBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

