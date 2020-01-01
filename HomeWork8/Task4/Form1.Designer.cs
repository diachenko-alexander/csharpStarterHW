namespace Task4
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
            this.operand1 = new System.Windows.Forms.TextBox();
            this.operand2 = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reminderOfDivisionRadioButton = new System.Windows.Forms.RadioButton();
            this.exponentRadioButton = new System.Windows.Forms.RadioButton();
            this.concatenationRadioButton = new System.Windows.Forms.RadioButton();
            this.divisionRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operand1
            // 
            this.operand1.AccessibleName = "Operand1";
            this.operand1.Location = new System.Drawing.Point(45, 39);
            this.operand1.Multiline = true;
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(224, 52);
            this.operand1.TabIndex = 0;
            this.operand1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // operand2
            // 
            this.operand2.AccessibleName = "Operand2";
            this.operand2.Location = new System.Drawing.Point(45, 110);
            this.operand2.Multiline = true;
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(220, 52);
            this.operand2.TabIndex = 1;
            this.operand2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.AccessibleName = "ResultText";
            this.resultTextBox.Location = new System.Drawing.Point(373, 39);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(358, 196);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "OperationGroupBox";
            this.groupBox1.Controls.Add(this.divisionRadioButton);
            this.groupBox1.Controls.Add(this.concatenationRadioButton);
            this.groupBox1.Controls.Add(this.exponentRadioButton);
            this.groupBox1.Controls.Add(this.reminderOfDivisionRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(45, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select operation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reminderOfDivisionRadioButton
            // 
            this.reminderOfDivisionRadioButton.AccessibleName = "reminder";
            this.reminderOfDivisionRadioButton.AutoSize = true;
            this.reminderOfDivisionRadioButton.Checked = true;
            this.reminderOfDivisionRadioButton.Location = new System.Drawing.Point(7, 24);
            this.reminderOfDivisionRadioButton.Name = "reminderOfDivisionRadioButton";
            this.reminderOfDivisionRadioButton.Size = new System.Drawing.Size(138, 17);
            this.reminderOfDivisionRadioButton.TabIndex = 0;
            this.reminderOfDivisionRadioButton.TabStop = true;
            this.reminderOfDivisionRadioButton.Text = "Reminder of the division";
            this.reminderOfDivisionRadioButton.UseVisualStyleBackColor = true;
            this.reminderOfDivisionRadioButton.CheckedChanged += new System.EventHandler(this.reminderOfDividingradioButton_CheckedChanged);
            // 
            // exponentRadioButton
            // 
            this.exponentRadioButton.AutoSize = true;
            this.exponentRadioButton.Location = new System.Drawing.Point(7, 48);
            this.exponentRadioButton.Name = "exponentRadioButton";
            this.exponentRadioButton.Size = new System.Drawing.Size(70, 17);
            this.exponentRadioButton.TabIndex = 1;
            this.exponentRadioButton.TabStop = true;
            this.exponentRadioButton.Text = "Exponent";
            this.exponentRadioButton.UseVisualStyleBackColor = true;
            this.exponentRadioButton.CheckedChanged += new System.EventHandler(this.exponentRadioButton_CheckedChanged_1);
            // 
            // concatenationRadioButton
            // 
            this.concatenationRadioButton.AutoSize = true;
            this.concatenationRadioButton.Location = new System.Drawing.Point(7, 72);
            this.concatenationRadioButton.Name = "concatenationRadioButton";
            this.concatenationRadioButton.Size = new System.Drawing.Size(94, 17);
            this.concatenationRadioButton.TabIndex = 2;
            this.concatenationRadioButton.TabStop = true;
            this.concatenationRadioButton.Text = "Cancatenation";
            this.concatenationRadioButton.UseVisualStyleBackColor = true;
            this.concatenationRadioButton.CheckedChanged += new System.EventHandler(this.concatenationRadioButton_CheckedChanged_1);
            // 
            // divisionRadioButton
            // 
            this.divisionRadioButton.AutoSize = true;
            this.divisionRadioButton.Location = new System.Drawing.Point(8, 96);
            this.divisionRadioButton.Name = "divisionRadioButton";
            this.divisionRadioButton.Size = new System.Drawing.Size(62, 17);
            this.divisionRadioButton.TabIndex = 3;
            this.divisionRadioButton.TabStop = true;
            this.divisionRadioButton.Text = "Division";
            this.divisionRadioButton.UseVisualStyleBackColor = true;
            this.divisionRadioButton.CheckedChanged += new System.EventHandler(this.divisionRadioButton_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AccessibleName = "CalculateButton";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.operand2);
            this.Controls.Add(this.operand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox operand1;
        private System.Windows.Forms.TextBox operand2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton reminderOfDivisionRadioButton;
        private System.Windows.Forms.RadioButton exponentRadioButton;
        private System.Windows.Forms.RadioButton concatenationRadioButton;
        private System.Windows.Forms.RadioButton divisionRadioButton;
    }
}

