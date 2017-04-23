using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num, ans, num2;
        double percentage = 0.01;
        double MemoryStore = 0;
        double EndResult = 0;
        int count;

        private void digitCalculate_Click(object sender, EventArgs e)
        {

            Button ButtonThatWasPushed = (Button)sender;
            string ButtonText = ButtonThatWasPushed.Text;
        }
        
        
        public void disable()
        {
            textBox1.Enabled = false;
            button1.Hide();
            button13.Show();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button28.Enabled = false;

            button29.Enabled = false;

            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
        }
        public void enable()
        {
            textBox1.Enabled = true;
            button13.Hide();
            button1.Show();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button28.Enabled = true;

            button29.Enabled = true;

            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                calculate();
                label2.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            textBox1.ForeColor = Color.White;
            //if (!textBox1.Text.Contains('0'))
            //{
            //    textBox1.Text += '0';
            //}
            //textBox1.ForeColor = Color.White;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "2";
            textBox1.ForeColor = Color.White;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            textBox1.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(','))
            {
                textBox1.Text+= ',';
            }
            textBox1.ForeColor = Color.White;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox1.ForeColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            textBox1.ForeColor = Color.White;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            textBox1.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            textBox1.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7" ;
            textBox1.ForeColor = Color.White;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            textBox1.ForeColor = Color.White;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            textBox1.ForeColor = Color.White;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enable();
        }
        
        public void calculate()
        {
        switch(count)
        { case 1:

                if (textBox1.Text.Contains(ans.ToString()))
                {
                    ans = ans + num2;
                    textBox1.Text = ans.ToString();
                }
                else
                {
                    if (textBox1.Text == " ") num2 = num;
                    else
                    {
                        num2 = double.Parse(textBox1.Text);
                    }
                    ans = num + num2;
                    textBox1.Text = ans.ToString();
                }
            break;
          case 2:
           if (textBox1.Text.Contains(ans.ToString()))
                    {
                        ans = ans - num2;
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {
                        num2 = double.Parse(textBox1.Text);
                        ans = num - num2;
                        textBox1.Text = ans.ToString();
                    }
                    break;
          case 3:
            ans = num * double.Parse(textBox1.Text);
            textBox1.Text = ans.ToString();
            break;
          case 4:
            if (textBox1.Text.Contains(ans.ToString()))
                    {
                        ans = ans / num2;
                        if (num2 == 0) textBox1.Text = "На 0 не делят!";
   
                        else
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {
                        num2 = double.Parse(textBox1.Text);
                        ans = num / num2;
                        if (num2 == 0) textBox1.Text = "На 0 не делят!";
                        else
                            textBox1.Text = ans.ToString();
                    }
                    break;
          case 5:
            ans = num *  percentage * double.Parse (textBox1.Text);
            textBox1.Text = ans.ToString();
            break;
          case 6:
            ans = (num * num) * 1;
            textBox1.Text = ans.ToString();
            break;
            case 7:
            ans = Math.Sqrt(num);
            textBox1.Text = ans.ToString();
            break;
            case 8:
            ans = (1) / (num);
            textBox1.Text = ans.ToString();
            break;
            default:
            break;
            
        }
    }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label2.Text = num.ToString() + "-";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label2.Text = num.ToString() + "×";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label2.Text = num.ToString() + "÷";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label2.Text = num.ToString() + "+";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                label2.Text = num.ToString() + "%";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 6;
                label2.Text = num.ToString() + "²";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
       }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {


                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 7;
                label2.Text = "√" + num.ToString() + "	᷆   ";
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 8;
                label2.Text = "1⁄" + num.ToString();
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label2.Text = " ";
            ans = ' ';

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('-'))
            {
                textBox1.Text = '-' + textBox1.Text;
            }
            else
            {

                textBox1.Text = textBox1.Text.Trim('-');
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            this.tm.Enabled = true;

        }
        private void tm_Tick(object sender, EventArgs e)
        {
            if (this.Height >= 550) this.tm.Enabled = false;
            else this.Height += 5; 
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                count = 1;
                MemoryStore = MemoryStore + double.Parse(textBox1.Text);
                MemoryStore += EndResult;
                textBox1.Text = MemoryStore.ToString();
                return;
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStore = Double.Parse(textBox1.Text);
                return;
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                count = 2;
                MemoryStore = MemoryStore - double.Parse(textBox1.Text);
                MemoryStore -= EndResult;
                textBox1.Text = MemoryStore.ToString();
                return;
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStore = 0;
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = MemoryStore.ToString();
            }
            catch
            {
                MessageBox.Show("Введите сначала число.");
            }
        }

        /*private void button28_Click(object sender, EventArgs e)
        {
            this.tm2.Enabled = true;
        }

        private void tm2_Tick(object sender, EventArgs e)
        {if (this.Height <= 162) this.tm.Enabled = false;
            else this.Height -= 5;

        }*/

       
    }
}
