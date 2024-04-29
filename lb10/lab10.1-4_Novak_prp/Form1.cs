using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10._1_4_Novak_prp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtXMin.Text, out double xMin) ||
                !double.TryParse(txtXMax.Text, out double xMax) ||
                !double.TryParse(txtDX.Text, out double dx) ||
                !double.TryParse(txtZMin.Text, out double zMin) ||
                !double.TryParse(txtZMax.Text, out double zMax) ||
                !double.TryParse(txtDZ.Text, out double dz))
            {
                MessageBox.Show("Помилка введення. Введіть числові значення для діапазонів та кроку зміни.");
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ColumnX", "X");
            dataGridView1.Columns.Add("ColumnZ", "Z");
            dataGridView1.Columns.Add("ColumnY", "Y");

            double sumOfNegatives = 0;

            for (double x = xMin; x <= xMax; x += dx)
            {
                for (double z = zMin; z <= zMax; z += dz)
                {
                    double result = 23 * Math.Pow(Math.Sin(Math.Pow(x, 3) * Math.Pow(z, 5)), 2) + 2 * x + Math.Cos(x * z);
                    dataGridView1.Rows.Add(x.ToString("F3"), z.ToString("F3"), result.ToString("F3"));

                    if (result < 0)
                    {
                        sumOfNegatives += result;
                    }
                }
            }

            lblSumOfNegatives.Text = $"Сума від'ємних значень: {sumOfNegatives}";

            dataGridView1.Rows.Add("", "", "");
            dataGridView1.Rows.Add("Середні значення:", "", "");

            double sumX = 0, sumZ = 0, sumResult = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
            {
                if (double.TryParse(dataGridView1.Rows[i].Cells[0].Value.ToString(), out double xValue) &&
                    double.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out double zValue) &&
                    double.TryParse(dataGridView1.Rows[i].Cells[2].Value.ToString(), out double resultValue))
                {
                    sumX += xValue;
                    sumZ += zValue;
                    sumResult += resultValue;
                }
            }

            double averageX = sumX / (dataGridView1.Rows.Count - 2);
            double averageZ = sumZ / (dataGridView1.Rows.Count - 2);
            double averageResult = sumResult / (dataGridView1.Rows.Count - 2);

            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = averageX.ToString("F3");
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = averageZ.ToString("F3");
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = averageResult.ToString("F3");

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                double sumColumn = 0;
                for (int j = 0; j < dataGridView1.Rows.Count - 2; j++)
                {
                    if (double.TryParse(dataGridView1.Rows[j].Cells[i].Value.ToString(), out double columnValue))
                    {
                        sumColumn += columnValue;
                    }
                }
                double averageColumn = sumColumn / (dataGridView1.Rows.Count - 2);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = averageColumn.ToString("F3");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtXMin.Clear();
            txtXMax.Clear();
            txtDX.Clear();

            txtZMin.Clear();
            txtZMax.Clear();
            txtDZ.Clear();

            dataGridView1.Rows.Clear();

            lblSumOfNegatives.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
