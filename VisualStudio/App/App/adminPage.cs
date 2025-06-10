using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App.Mod;
using static App.dataBaseHelp;
using System.Data.SqlClient;

namespace App
{
    public partial class adminPage : Form
    {
        private readonly dataBaseHelp _dbHelper = new dataBaseHelp();
        private readonly int _requestId;
        dataBaseHelp dbHelper = new dataBaseHelp();

        public DataGridView DataGridViewForTesting => dataGridView1;
        public DataGridView RequestsDataGridView => dataGridView1;
        public int LoadRequestsForTesting()
        {
            LoadRequests();
            return dataGridView1.Rows.Count;
        }

        public void RenameDataGridViewColumnsForTesting()
        {
            RenameDataGridViewColumns();
            return;
        }

        public adminPage()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                string query = "SELECT id, dateCreation, equipment, faultType, description, idClient, status, idExecutor, dataCompletion FROM Requests";
                DataTable requests = _dbHelper.ExecuteSqlQuery(query);

                dataGridView1.DataSource = requests;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;

                // Переименовываем заголовки столбцов на русский
                RenameDataGridViewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}");
            }
        }

        private void RenameDataGridViewColumns()
        {
            // Создаем словарь для перевода названий столбцов
            Dictionary<string, string> columnMappings = new Dictionary<string, string>
            {
                { "id", "Номер заявки" },
                { "dateCreation", "Дата создания" },
                { "equipment", "Оборудование" },
                { "faultType", "Тип неисправности" },
                { "description", "Описание проблемы" },
                { "idClient", "Клиент" },
                { "status", "Статус заявки" },
                { "idExecutor", "Исполнитель" },
                { "dataCompletion", "Дата завершения" }
            };

            // Проходим по всем столбцам DataGridView
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // Если столбец есть в словаре, меняем заголовок
                if (columnMappings.ContainsKey(column.DataPropertyName))
                {
                    column.HeaderText = columnMappings[column.DataPropertyName];
                }
            }
        }
    }
}
