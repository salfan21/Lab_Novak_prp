using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8._1_Novak_prp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            double x1 = double.Parse(xTextBox.Text);
            double x2 = double.Parse(zTextBox.Text);

            double y = 23 * Math.Pow(Math.Sin(Math.Pow(x1, 3) * Math.Pow(x2, 5)), 2) + 2 * x1 + Math.Cos(x1 * x2);

            yTextBox.Text = y.ToString("0.###");

            double min_x = Math.Min(x1, x2);
            
            minXTextBox.Text = min_x.ToString("0.###");
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            xTextBox.Text = "";
            zTextBox.Text = "";
            yTextBox.Text = "";
            minXTextBox.Text = "";
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
