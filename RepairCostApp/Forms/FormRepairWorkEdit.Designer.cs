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

        // Добавили переменные для подписей
        private Label labelDate;
        private Label labelQuantity;
        private Label labelPrice;
        private Label labelRoom;
        private Label labelContractor;
        private Label labelArticle;
        private Label labelCategory;

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
            this.labelDate = new Label();
            this.labelQuantity = new Label();
            this.labelPrice = new Label();
            this.labelRoom = new Label();
            this.labelContractor = new Label();
            this.labelArticle = new Label();
            this.labelCategory = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();

            // labelDate
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new Point(20, 10);
            this.labelDate.Text = "Дата:";

            // dateTimePickerDate
            this.dateTimePickerDate.Location = new Point(20, 30);
            this.dateTimePickerDate.Size = new Size(200, 27);

            // labelQuantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new Point(20, 70);
            this.labelQuantity.Text = "Количество:";

            // numericUpDownQuantity
            this.numericUpDownQuantity.DecimalPlaces = 2;
            this.numericUpDownQuantity.Location = new Point(20, 90);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownQuantity.Size = new Size(200, 27);

            // labelPrice
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new Point(20, 130);
            this.labelPrice.Text = "Цена:";

            // numericUpDownPrice
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new Point(20, 150);
            this.numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericUpDownPrice.Size = new Size(200, 27);

            // labelRoom
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new Point(20, 190);
            this.labelRoom.Text = "Помещение:";

            // comboBoxRoom
            this.comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Location = new Point(20, 210);
            this.comboBoxRoom.Size = new Size(200, 28);

            // labelContractor
            this.labelContractor.AutoSize = true;
            this.labelContractor.Location = new Point(20, 250);
            this.labelContractor.Text = "Подрядчик:";

            // comboBoxContractor
            this.comboBoxContractor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxContractor.Location = new Point(20, 270);
            this.comboBoxContractor.Size = new Size(200, 28);

            // labelArticle
            this.labelArticle.AutoSize = true;
            this.labelArticle.Location = new Point(20, 310);
            this.labelArticle.Text = "Статья затрат:";

            // comboBoxArticle
            this.comboBoxArticle.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxArticle.Location = new Point(20, 330);
            this.comboBoxArticle.Size = new Size(200, 28);

            // labelCategory
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new Point(250, 10);
            this.labelCategory.Text = "Категории работ:";

            // checkedListBoxCategory
            this.checkedListBoxCategory.Location = new Point(250, 30);
            this.checkedListBoxCategory.Size = new Size(200, 180);
            this.checkedListBoxCategory.CheckOnClick = true;

            // ButtonSave
            this.ButtonSave.Location = new Point(20, 390);
            this.ButtonSave.Size = new Size(120, 40);
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new EventHandler(this.ButtonSave_Click);

            // ButtonCancel
            this.ButtonCancel.Location = new Point(150, 390);
            this.ButtonCancel.Size = new Size(120, 40);
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            // FormRepairWorkEdit
            this.ClientSize = new Size(500, 460);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelArticle);
            this.Controls.Add(this.labelContractor);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDate);

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
            this.PerformLayout();
        }
    }
}