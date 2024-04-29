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
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(yearTextBox.Text) ||
                string.IsNullOrWhiteSpace(purposeTextBox.Text) ||
                string.IsNullOrWhiteSpace(weightTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(yearTextBox.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Неправильні дані у рядку 'Рік побудови'. Приклад правильного формату: 2000.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(weightTextBox.Text, out double weight) || weight <= 0)
            {
                MessageBox.Show("Неправильні дані у рядку 'Вага'. Приклад правильного формату: 5000.5.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(priceTextBox.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Неправильні дані у рядку 'Ціна'. Приклад правильного формату: 25000.99.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = nameTextBox.Text;
            string purpose = purposeTextBox.Text;

            mainForm.AddRecord(name, year, purpose, weight, price);

            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
