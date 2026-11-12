namespace RepairCostApp.Forms
{
    partial class FormEstimateEdit
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxRoom;
        private DataGridView dataGridViewItems;
        private Button ButtonAddWork;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dateTimePickerDate = new DateTimePicker();
            this.comboBoxRoom = new ComboBox();
            this.dataGridViewItems = new DataGridView();
            this.ButtonAddWork = new Button();
            this.ButtonSave = new Button();
            this.ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();

            this.dateTimePickerDate.Location = new Point(20, 20);
            this.dateTimePickerDate.Size = new Size(200, 27);

            this.comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Location = new Point(240, 20);
            this.comboBoxRoom.Size = new Size(250, 28);

            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new Point(20, 60);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new Size(600, 250);

            this.ButtonAddWork.Location = new Point(20, 320);
            this.ButtonAddWork.Size = new Size(150, 40);
            this.ButtonAddWork.Text = "Добавить работу";
            this.ButtonAddWork.Click += new EventHandler(this.ButtonAddWork_Click);

            this.ButtonSave.Location = new Point(200, 320);
            this.ButtonSave.Size = new Size(150, 40);
            this.ButtonSave.Text = "Сохранить смету";
            this.ButtonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.ButtonCancel.Location = new Point(380, 320);
            this.ButtonCancel.Size = new Size(150, 40);
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new Size(650, 400);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonAddWork);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "FormEstimateEdit";
            this.Text = "Создание сметы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
        }
    }
}