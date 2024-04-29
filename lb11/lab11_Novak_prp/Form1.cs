using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11_Novak_prp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Year", "Рік побудови");
            dataGridView1.Columns.Add("Purpose", "Призначення");
            dataGridView1.Columns.Add("Weight", "Вага");
            dataGridView1.Columns.Add("Price", "Ціна");
        }

        public void AddRecord(string name, int year, string purpose, double weight, decimal price)
        {
            dataGridView1.Rows.Add(name, year, purpose, weight, price);
        }

        private void AddShipButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
