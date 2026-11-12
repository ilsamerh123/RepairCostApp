namespace RepairCostApp.Forms
{
    partial class FormSelectWork
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewWorks;
        private Button ButtonSelect;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewWorks = new DataGridView();
            this.ButtonSelect = new Button();
            this.ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorks)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewWorks.AllowUserToAddRows = false;
            this.dataGridViewWorks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorks.Location = new Point(12, 12);
            this.dataGridViewWorks.MultiSelect = false;
            this.dataGridViewWorks.Name = "dataGridViewWorks";
            this.dataGridViewWorks.ReadOnly = true;
            this.dataGridViewWorks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWorks.Size = new Size(500, 300);

            this.ButtonSelect.Location = new Point(12, 330);
            this.ButtonSelect.Size = new Size(150, 40);
            this.ButtonSelect.Text = "Выбрать";
            this.ButtonSelect.Click += new EventHandler(this.ButtonSelect_Click);

            this.ButtonCancel.Location = new Point(180, 330);
            this.ButtonCancel.Size = new Size(150, 40);
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new Size(550, 400);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.dataGridViewWorks);
            this.Name = "FormSelectWork";
            this.Text = "Выбор работы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorks)).EndInit();
            this.ResumeLayout(false);
        }
    }
}