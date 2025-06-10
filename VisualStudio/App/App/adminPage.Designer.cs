namespace App
{
    partial class adminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.filtrFull = new System.Windows.Forms.Label();
            this.filtrRef = new System.Windows.Forms.Label();
            this.filtrApprov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filtrWait = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 206);
            this.dataGridView1.TabIndex = 53;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUpdate1.Location = new System.Drawing.Point(554, 309);
            this.btnUpdate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(221, 32);
            this.btnUpdate1.TabIndex = 52;
            this.btnUpdate1.Text = "Обновить таблицу";
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Visible = false;
            // 
            // filtrFull
            // 
            this.filtrFull.AutoSize = true;
            this.filtrFull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filtrFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrFull.Location = new System.Drawing.Point(11, 396);
            this.filtrFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtrFull.Name = "filtrFull";
            this.filtrFull.Size = new System.Drawing.Size(126, 22);
            this.filtrFull.TabIndex = 51;
            this.filtrFull.Text = "Показать всё";
            // 
            // filtrRef
            // 
            this.filtrRef.AutoSize = true;
            this.filtrRef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filtrRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrRef.Location = new System.Drawing.Point(13, 362);
            this.filtrRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtrRef.Name = "filtrRef";
            this.filtrRef.Size = new System.Drawing.Size(333, 22);
            this.filtrRef.TabIndex = 50;
            this.filtrRef.Text = "Показать заявки в статусе \"в работе\"";
            // 
            // filtrApprov
            // 
            this.filtrApprov.AutoSize = true;
            this.filtrApprov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filtrApprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrApprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrApprov.Location = new System.Drawing.Point(13, 328);
            this.filtrApprov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtrApprov.Name = "filtrApprov";
            this.filtrApprov.Size = new System.Drawing.Size(350, 22);
            this.filtrApprov.TabIndex = 49;
            this.filtrApprov.Text = "Показать заявки в статусе \"выполнено\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(113, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Фильтрация";
            // 
            // filtrWait
            // 
            this.filtrWait.AutoSize = true;
            this.filtrWait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filtrWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrWait.Location = new System.Drawing.Point(13, 297);
            this.filtrWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtrWait.Name = "filtrWait";
            this.filtrWait.Size = new System.Drawing.Size(332, 22);
            this.filtrWait.TabIndex = 47;
            this.filtrWait.Text = "Показать заявки в статусе \"ожидает\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem.Text = "&Редактировать";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.статистикаToolStripMenuItem.Text = "&Статистика";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "&Добавить";
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.filtrFull);
            this.Controls.Add(this.filtrRef);
            this.Controls.Add(this.filtrApprov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filtrWait);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminPage";
            this.Text = "Страница админа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Label filtrFull;
        private System.Windows.Forms.Label filtrRef;
        private System.Windows.Forms.Label filtrApprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filtrWait;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
    }
}