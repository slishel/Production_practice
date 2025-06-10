using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App.Mod;
namespace App
{
    public partial class login : Form
    {
        private readonly dataBaseHelp _dbHelper = new dataBaseHelp();
        public User UserLoggedIn { get; private set; }
        public login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = txtLog.Text;
            string password = txtPass.Text;

            dataBaseHelp dbHelper = new dataBaseHelp();
            UserLoggedIn = dbHelper.AuthenticateUser(username, password);

            if (UserLoggedIn != null)
            {
                // Определяем роль пользователя и открываем соответствующую форму
                switch (UserLoggedIn.nameRole.ToLower()) // Предполагается, что у класса User есть свойство NameRole
                {
                    case "admin":
                        adminPage adminPage = new adminPage();
                        adminPage.Show();
                        break;
                    case "worker":
                        // Открываем форму исполнителя
                        adminPage adminPage1 = new adminPage();
                        adminPage1.Show();
                        break;
                    case "client":
                        // Открываем форму клиента
                        user user = new user();
                        user.Show();
                        break;
                    default:
                        MessageBox.Show("Неизвестная роль пользователя.");
                        break;
                }

                this.Hide(); // Скрываем форму входа
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear(); // Очищаем поле пароля после неудачной попытки
            }
        }

        private void lblRegi_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            this.Hide();
        }

      
    }
}
