using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        

        private void btnRegi_Click_1(object sender, EventArgs e)
        {
            // Проверка на пустые поля с использованием String.IsNullOrWhiteSpace
            if (string.IsNullOrWhiteSpace(txtLog.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtPass1.Text))
            {
                MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //  Прерываем выполнение, если поля не заполнены
            }


        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            // для демонстрирования не совпадающего пароля
            if (txtPass.Text != txtPass1.Text)
            {
                txtPass1.BackColor = Color.FromArgb(172, 117, 123);
                lblPsNo.Visible = true;
            }
            else
            {
                txtPass1.BackColor = SystemColors.Window;
                lblPsNo.Visible = false;
            }
        }
    }
}
