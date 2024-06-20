using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка на заповнення всіх полів
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Отримання парамметрів
            double cc1 = double.Parse(textBox1.Text);
            double ff1 = double.Parse(textBox2.Text);
            double ee1 = double.Parse(textBox3.Text);
            double a = double.Parse(textBox4.Text);
            double a2 = double.Parse(textBox5.Text);
            double qa = double.Parse(textBox6.Text);

            // Розрахунок показників
            double di = (ee1 / cc1) * 100;
            double ccmh = (cc1 / a2);
            double dsi = (ff1 / cc1) * 100;

            //Визначення діагнозу
            string diagnosis1;
            if (qa < 0.18)
            {
                diagnosis1 = "Менше норми.";
            }
            else if (qa > 0.30)
            {
                diagnosis1 = "Більше норми.";
            }
            else
            {
                diagnosis1 = "У нормі.";
            }

            string diagnosis2;
            if (a < 0.08)
            {
                diagnosis2 = "Менше норми.";
            }
            else if (a > 0.16)
            {
                diagnosis2 = "Більше норми.";
            }
            else
            {
                diagnosis2 = "У нормі.";
            }

            string diagnosis3;
            if (di < 30)
            {
                diagnosis3 = "Менше норми. ";
            }
            else if (di > 80)
            {
                diagnosis3 = "Більше норми. ";
            }
            else
            {
                diagnosis3 = "У нормі. ";
            }

            string diagnosis4;
            if (dsi < 20)
            {
                diagnosis4 = "Менше норми. ";
            }
            else if (dsi > 80)
            {
                diagnosis4 = "Більше норми. ";
            }
            else
            {
                diagnosis4 = "У нормі. ";
            }

            string diagnosis5;
            if (ccmh < 0.5)
            {
                diagnosis5 = "Менше норми. ";
            }
            else if (ccmh > 1.1)
            {
                diagnosis5 = "Більше норми. ";
            }
            else
            {
                diagnosis5 = "У нормі. ";
            }

            //Виведення результатів
            label15.Text = diagnosis1;
            label16.Text = diagnosis2;
            label17.Text = diagnosis3;
            label18.Text = diagnosis4;
            label19.Text = diagnosis5;
        }
    }
}
