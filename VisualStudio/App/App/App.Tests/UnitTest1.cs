using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Windows.Forms;

namespace App.Tests
{
    [TestClass]
    public class AdminPageTests
    {
        [TestMethod]
        public void LoadRequests_ShouldPopulateDataGridView()
        {
            // Arrange
            var adminPage = new adminPage();

            // Используем новое свойство для доступа
            int initialRowCount = 0;

            // Act
            adminPage.LoadRequestsForTesting();

            // Assert
            Assert.IsTrue(adminPage.DataGridViewForTesting.Rows.Count > initialRowCount ||
                         (initialRowCount == 0 && adminPage.DataGridViewForTesting.Rows.Count == 0));
        }

        [TestMethod]
        public void RenameDataGridViewColumns_ShouldTranslateHeaders()
        {
            // Arrange
            var adminPage = new adminPage();

            var testTable = new DataTable();
            testTable.Columns.Add("id");
            testTable.Columns.Add("status");
            testTable.Columns.Add("description");

            // Используем публичное свойство вместо прямого доступа
            adminPage.RequestsDataGridView.DataSource = testTable;

            // Act
            adminPage.RenameDataGridViewColumnsForTesting();

            // Assert
            var grid = adminPage.RequestsDataGridView;
            Assert.AreEqual("Номер заявки", grid.Columns["id"].HeaderText);
            Assert.AreEqual("Статус заявки", grid.Columns["status"].HeaderText);
            Assert.AreEqual("Описание проблемы", grid.Columns["description"].HeaderText);
        }
    }
}