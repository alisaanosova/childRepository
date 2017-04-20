using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double a, b, y;
        private int count;
        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    ///asdas
                    /// 
                    b = a + double.Parse(textBox1.Text);
                    label1.Text = a.ToString() + "+" + b.ToString();
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    label1.Text = a.ToString() + "+" + b.ToString();
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);
                    label1.Text = a.ToString() + "+" + b.ToString();
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / double.Parse(textBox1.Text);
                    label1.Text = a.ToString() + "+" + b.ToString();
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    y = double.Parse(textBox1.Text);

                    b = a;
                    for (int i = 1; i < y; i++)
                    {
                        b = b * a;
                    }
                    textBox1.Text = b.ToString();
                    label1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
        private void CorrectNumber()
        {
            if (textBox1.Text == "∞")
            {
                textBox1.Text = "Can not divide by zero";
            }
            if (textBox1.Text[0] == '0' && (textBox1.Text.IndexOf(",") != 1))
                textBox1.Text = textBox1.Text.Remove(0, 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            int i = 0;
            if (i == lenght)
                textBox1.Text = "0";
            else
            {
                for (i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "*";
            textBox1.Clear();
            textBox1.Text = "0";
            count = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "^2";
            b = a * a;
            textBox1.Clear();
            textBox1.Text = "0";
            label1.Text = b.ToString();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "/";
            textBox1.Clear();
            textBox1.Text = "0";
            count = 4;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "+";
            textBox1.Clear();
            textBox1.Text = "0";
            count = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "-";
            textBox1.Clear();
            textBox1.Text = "0";
            count = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = "0";
            label1.Text = a.ToString() + "^" + y.ToString();
            count = 5;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Sqrt(a);
            label1.Text = b.ToString();
            textBox1.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) > 0)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (double.Parse(textBox1.Text) < 0)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            CorrectNumber();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            CorrectNumber();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            CorrectNumber();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            CorrectNumber();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calculate();
            CorrectNumber();
            label1.Text = b.ToString();
        }
    }
}
