using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WPFworks
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if(principalTextbox.Text == null || RateTextbox.Text == null || periodTextbox.Text == null)
            {
                MessageBox.Show("please enter the value");
            }
            else
            {
                var principal = double.Parse(principalTextbox.Text);
                var rate = double.Parse(RateTextbox.Text);
                var period = double.Parse(periodTextbox.Text);

                var interest = (principal * rate * period) / 1200;

                var amount = interest + principal;
                interestTextbox.Text = interest.ToString();
                AmountTextbox.Text = amount.ToString();

            }

        }

        private void principalTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
