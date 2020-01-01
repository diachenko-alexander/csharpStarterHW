using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void reminderOfDividingradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exponentRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void concatenationRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void divisionRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (reminderOfDivisionRadioButton.Checked)
            {                
                resultTextBox.Text = GetReminderOfDivision(double.Parse(operand1.Text), double.Parse(operand2.Text)).ToString();
            } else if (exponentRadioButton.Checked)
            {
                resultTextBox.Text = GetExponent(double.Parse(operand1.Text), double.Parse(operand2.Text)).ToString();
            } else if (concatenationRadioButton.Checked)
            {
                resultTextBox.Text = GetConcatenation(operand1.Text, operand2.Text);
            } else if (divisionRadioButton.Checked)
            {
                if (operand2.Text == "0")
                {
                    MessageBox.Show("Dividing by zero imposible", "Error");
                } else
                {
                    resultTextBox.Text = GetDivision (double.Parse(operand1.Text), double.Parse(operand2.Text)).ToString();
                }
            }

        }

        string GetConcatenation (string a, string b)
        {
            return a + b;
        }

        double GetReminderOfDivision (double a, double b)
        {
            return a % b;
        }

        double GetExponent (double a, double b)
        {
            return Math.Pow(a, b);
        }

        double GetDivision(double a, double b)
        {
           return a / b;
        }
        
    }
}
