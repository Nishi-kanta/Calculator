using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_performance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& textBox2.Text!="")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 + num2;
                // MessageBox.Show("Addition result is:-" + result.ToString());

                label4.Text = "Addition result is:=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both fields....!!!");
            }
           
        }

        private void substractbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                // MessageBox.Show("Addition result is:-" + result.ToString());

                label4.Text = "Substraction result is:=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both fields....!!!");
            }
        }

        private void multibutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                // MessageBox.Show("Addition result is:-" + result.ToString());

                label4.Text = "Multiplication result is:=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both fields....!!!");
            }
        }

        private void divisionbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 / num2;
                // MessageBox.Show("Addition result is:-" + result.ToString());

                label4.Text = "division result is:=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please fill both fields....!!!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
