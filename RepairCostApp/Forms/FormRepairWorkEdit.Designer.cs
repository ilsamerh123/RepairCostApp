namespace RepairCostApp.Forms
{
    partial class FormRepairWorkEdit
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dateTimePickerDate;
        private NumericUpDown numericUpDownQuantity;
        private NumericUpDown numericUpDownPrice;
        private ComboBox comboBoxRoom;
        private ComboBox comboBoxContractor;
        private ComboBox comboBoxArticle;
        private CheckedListBox checkedListBoxCategory;
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
            this.numericUpDownQuantity = new NumericUpDown();
            this.numericUpDownPrice = new NumericUpDown();
            this.comboBoxRoom = new ComboBox();
            this.comboBoxContractor = new ComboBox();
            this.comboBoxArticle = new ComboBox();
            this.checkedListBoxCategory = new CheckedListBox();
            this.ButtonSave = new Button();
            this.ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();

            // dateTimePickerDate
            this.dateTimePickerDate.Location = new Point(20, 20);
            this.dateTimePickerDate.Size = new Size(200, 27);

            // numericUpDownQuantity
            this.numericUpDownQuantity.DecimalPlaces = 2;
            this.numericUpDownQuantity.Location = new Point(20, 60);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownQuantity.Size = new Size(200, 27);

            // numericUpDownPrice
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new Point(20, 100);
            this.numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericUpDownPrice.Size = new Size(200, 27);

            // comboBoxRoom
            this.comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Location = new Point(20, 140);
            this.comboBoxRoom.Size = new Size(200, 28);

            // comboBoxContractor
            this.comboBoxContractor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxContractor.Location = new Point(20, 180);
            this.comboBoxContractor.Size = new Size(200, 28);

            // comboBoxArticle
            this.comboBoxArticle.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxArticle.Location = new Point(20, 220);
            this.comboBoxArticle.Size = new Size(200, 28);

            // checkedListBoxCategory
            this.checkedListBoxCategory.Location = new Point(250, 20);
            this.checkedListBoxCategory.Size = new Size(200, 180);
            this.checkedListBoxCategory.CheckOnClick = true;

            // ButtonSave
            this.ButtonSave.Location = new Point(20, 300);
            this.ButtonSave.Size = new Size(120, 40);
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new EventHandler(this.ButtonSave_Click);

            // ButtonCancel
            this.ButtonCancel.Location = new Point(150, 300);
            this.ButtonCancel.Size = new Size(120, 40);
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            // FormRepairWorkEdit
            this.ClientSize = new Size(500, 380);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.checkedListBoxCategory);
            this.Controls.Add(this.comboBoxArticle);
            this.Controls.Add(this.comboBoxContractor);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "FormRepairWorkEdit";
            this.Text = "Добавление ремонтной работы";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
        }
    }
}