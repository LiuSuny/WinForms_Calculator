using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string choiceOperation = "";
        bool isChoiceOperationPerform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || isChoiceOperationPerform)
                tbDisplayResult.Clear();

            isChoiceOperationPerform = false;
            Button button = (Button)sender;
            //Next we validate if decimal is more than 1
            if(button.Text ==".")
            {
                if(!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            choiceOperation = button.Text;
            resultValue = double.Parse(tbDisplayResult.Text);
            IbCurrentOp.Text = resultValue + " " + choiceOperation;
            isChoiceOperationPerform = true;
        }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void EqualToOperator_click(object sender, EventArgs e)
        {
            if(choiceOperation == "+")
            {
                tbDisplayResult.Text= (resultValue + double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (choiceOperation == "-")
            {
                tbDisplayResult.Text = (resultValue - double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (choiceOperation == "*")
            {
                tbDisplayResult.Text = (resultValue * double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (choiceOperation == "/")
            {
                tbDisplayResult.Text = (resultValue / double.Parse(tbDisplayResult.Text)).ToString();
            }
           else
            {
                throw new Exception();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text.Length > 0)
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);
            if (tbDisplayResult.Text == "")
                tbDisplayResult.Text = "0";
        }
    }
}
