namespace App
{
    partial class EditRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRequest));
            this.dateTimePickerCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateCompleted = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxFaultType = new System.Windows.Forms.TextBox();
            this.textBoxEquipment = new System.Windows.Forms.TextBox();
            this.dateTimePickerCreationDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxRequestNumber = new System.Windows.Forms.TextBox();
            this.labelExecutor = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFaultType = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.labelRequestNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerCompletionDate
            // 
            this.dateTimePickerCompletionDate.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerCompletionDate.Location = new System.Drawing.Point(242, 411);
            this.dateTimePickerCompletionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerCompletionDate.Name = "dateTimePickerCompletionDate";
            this.dateTimePickerCompletionDate.ShowCheckBox = true;
            this.dateTimePickerCompletionDate.Size = new System.Drawing.Size(251, 29);
            this.dateTimePickerCompletionDate.TabIndex = 42;
            // 
            // labelDateCompleted
            // 
            this.labelDateCompleted.AutoSize = true;
            this.labelDateCompleted.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateCompleted.Location = new System.Drawing.Point(10, 415);
            this.labelDateCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateCompleted.Name = "labelDateCompleted";
            this.labelDateCompleted.Size = new System.Drawing.Size(186, 25);
            this.labelDateCompleted.TabIndex = 41;
            this.labelDateCompleted.Text = "Дата завершения:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(315, 469);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 39);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(42, 469);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 39);
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutor.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(242, 362);
            this.comboBoxExecutor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(251, 33);
            this.comboBoxExecutor.TabIndex = 38;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(242, 311);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(251, 33);
            this.comboBoxStatus.TabIndex = 37;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(242, 202);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(251, 92);
            this.textBoxDescription.TabIndex = 36;
            // 
            // textBoxFaultType
            // 
            this.textBoxFaultType.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFaultType.Location = new System.Drawing.Point(242, 153);
            this.textBoxFaultType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFaultType.Name = "textBoxFaultType";
            this.textBoxFaultType.ReadOnly = true;
            this.textBoxFaultType.Size = new System.Drawing.Size(251, 29);
            this.textBoxFaultType.TabIndex = 35;
            // 
            // textBoxEquipment
            // 
            this.textBoxEquipment.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEquipment.Location = new System.Drawing.Point(242, 109);
            this.textBoxEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEquipment.Name = "textBoxEquipment";
            this.textBoxEquipment.ReadOnly = true;
            this.textBoxEquipment.Size = new System.Drawing.Size(251, 29);
            this.textBoxEquipment.TabIndex = 34;
            // 
            // dateTimePickerCreationDate
            // 
            this.dateTimePickerCreationDate.Enabled = false;
            this.dateTimePickerCreationDate.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerCreationDate.Location = new System.Drawing.Point(242, 63);
            this.dateTimePickerCreationDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerCreationDate.Name = "dateTimePickerCreationDate";
            this.dateTimePickerCreationDate.Size = new System.Drawing.Size(251, 29);
            this.dateTimePickerCreationDate.TabIndex = 33;
            // 
            // textBoxRequestNumber
            // 
            this.textBoxRequestNumber.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRequestNumber.Location = new System.Drawing.Point(242, 19);
            this.textBoxRequestNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRequestNumber.Name = "textBoxRequestNumber";
            this.textBoxRequestNumber.ReadOnly = true;
            this.textBoxRequestNumber.Size = new System.Drawing.Size(251, 29);
            this.textBoxRequestNumber.TabIndex = 32;
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExecutor.Location = new System.Drawing.Point(10, 365);
            this.labelExecutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(143, 25);
            this.labelExecutor.TabIndex = 31;
            this.labelExecutor.Text = "Исполнитель:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(10, 314);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 25);
            this.labelStatus.TabIndex = 30;
            this.labelStatus.Text = "Статус:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(10, 205);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(214, 25);
            this.labelDescription.TabIndex = 29;
            this.labelDescription.Text = "Описание проблемы:";
            // 
            // labelFaultType
            // 
            this.labelFaultType.AutoSize = true;
            this.labelFaultType.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFaultType.Location = new System.Drawing.Point(13, 156);
            this.labelFaultType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFaultType.Name = "labelFaultType";
            this.labelFaultType.Size = new System.Drawing.Size(205, 25);
            this.labelFaultType.TabIndex = 28;
            this.labelFaultType.Text = "Тип неисправности:";
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquipment.Location = new System.Drawing.Point(13, 112);
            this.labelEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(156, 25);
            this.labelEquipment.TabIndex = 27;
            this.labelEquipment.Text = "Оборудование:";
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.AutoSize = true;
            this.labelCreationDate.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreationDate.Location = new System.Drawing.Point(13, 67);
            this.labelCreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(159, 25);
            this.labelCreationDate.TabIndex = 26;
            this.labelCreationDate.Text = "Дата создания:";
            // 
            // labelRequestNumber
            // 
            this.labelRequestNumber.AutoSize = true;
            this.labelRequestNumber.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequestNumber.Location = new System.Drawing.Point(10, 22);
            this.labelRequestNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequestNumber.Name = "labelRequestNumber";
            this.labelRequestNumber.Size = new System.Drawing.Size(153, 25);
            this.labelRequestNumber.TabIndex = 25;
            this.labelRequestNumber.Text = "Номер заявки:";
            // 
            // EditRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 524);
            this.Controls.Add(this.dateTimePickerCompletionDate);
            this.Controls.Add(this.labelDateCompleted);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxFaultType);
            this.Controls.Add(this.textBoxEquipment);
            this.Controls.Add(this.dateTimePickerCreationDate);
            this.Controls.Add(this.textBoxRequestNumber);
            this.Controls.Add(this.labelExecutor);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelFaultType);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.labelCreationDate);
            this.Controls.Add(this.labelRequestNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditRequest";
            this.Text = "EditRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerCompletionDate;
        private System.Windows.Forms.Label labelDateCompleted;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxFaultType;
        private System.Windows.Forms.TextBox textBoxEquipment;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreationDate;
        private System.Windows.Forms.TextBox textBoxRequestNumber;
        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelFaultType;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Label labelCreationDate;
        private System.Windows.Forms.Label labelRequestNumber;
    }
}