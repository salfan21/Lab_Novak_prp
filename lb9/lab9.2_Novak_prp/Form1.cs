using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_Novak_prp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Бензин A");
            listBox1.Items.Add("Бензин B");
            listBox1.Items.Add("Бензин C");
            listBox1.Items.Add("Бензин D");
            listBox1.SelectedIndex = 0;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox2.Text = "0";
            textBox3.Text = "0";
           
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";

            // Реєструємо обробники подій
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            textBox2.KeyPress += textBox_KeyPress;
            textBox3.KeyPress += textBox_KeyPress;
            textBox8.KeyPress += textBox_KeyPress;
            textBox9.KeyPress += textBox_KeyPress;
            textBox10.KeyPress += textBox_KeyPress;
            textBox11.KeyPress += textBox_KeyPress;

            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;

            checkBox1.CheckedChanged += checkBox_CheckedChangedGG;
            checkBox2.CheckedChanged += checkBox_CheckedChangedGG;
            checkBox3.CheckedChanged += checkBox_CheckedChangedGG;
            checkBox4.CheckedChanged += checkBox_CheckedChangedGG;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '0' && textBox.Text.Length == 0)
            {
                e.Handled = false;
            }
            else if (textBox.Text.Length > 0 && textBox.Text[0] == '0' && e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else if (textBox.Text.Length > 0 && textBox.Text[0] == '0')
            {
                e.Handled = true;
            }
        }





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double priceA = 10.50;
            double priceB = 11.20;
            double priceC = 11.80;
            double priceD = 12.50;

            int selectedIndex = listBox1.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    textBox1.Text = priceA.ToString();
                    break;
                case 1:
                    textBox1.Text = priceB.ToString();
                    break;
                case 2:
                    textBox1.Text = priceC.ToString();
                    break;
                case 3:
                    textBox1.Text = priceD.ToString();
                    break;
                default:
                    textBox1.Text = "0.00";
                    break;
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
            else if (radioButton2.Checked)
            {
                textBox3.Enabled = true;
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox == checkBox1)
            {
                textBox8.Enabled = checkBox1.Checked;
            }
            else if (checkBox == checkBox2)
            {
                textBox9.Enabled = checkBox2.Checked;
            }
            else if (checkBox == checkBox3)
            {
                textBox10.Enabled = checkBox3.Checked;
            }
            else if (checkBox == checkBox4)
            {
                textBox11.Enabled = checkBox4.Checked;
            }
        }

        private void checkBox_CheckedChangedGG(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox == checkBox1)
            {
                textBox8.Enabled = checkBox1.Checked;
                if (!checkBox1.Checked)
                {
                    textBox8.Text = "0";
                }
            }
            else if (checkBox == checkBox2)
            {
                textBox9.Enabled = checkBox2.Checked;
                if (!checkBox2.Checked)
                {
                    textBox9.Text = "0";
                }
            }
            else if (checkBox == checkBox3)
            {
                textBox10.Enabled = checkBox3.Checked;
                if (!checkBox3.Checked)
                {
                    textBox10.Text = "0";
                }
            }
            else if (checkBox == checkBox4)
            {
                textBox11.Enabled = checkBox4.Checked;
                if (!checkBox4.Checked)
                {
                    textBox11.Text = "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pricePerLiter = double.Parse(textBox1.Text);

            if (radioButton1.Checked)
            {
                double liters = double.Parse(textBox2.Text);

                double totalPrice = liters * pricePerLiter;

                label5.Text = $"{totalPrice:F2}";
            }
            else if (radioButton2.Checked)
            {
                double moneyAmount = double.Parse(textBox3.Text);

                double litersAffordable = moneyAmount;

                label5.Text = $"{litersAffordable:F2}";
            }



            if (!string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox11.Text))
            {
                double result = double.Parse(textBox7.Text) * double.Parse(textBox11.Text) + double.Parse(textBox10.Text) * double.Parse(textBox6.Text) + double.Parse(textBox9.Text) * double.Parse(textBox5.Text) + double.Parse(textBox8.Text) * double.Parse(textBox4.Text);

                label6.Text = result.ToString();
            }
            else
            {
                label6.Text = "Необхідно заповнити всі поля!";
            }



            if (double.TryParse(label5.Text, out double value1) && double.TryParse(label6.Text, out double value2))
            {
                double sum = value1 + value2;
                label7.Text = sum.ToString();
            }
            else
            {
                label7.Text = "Помилка: неправильний формат числа";
            }
        }
    }
}
