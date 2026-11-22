namespace RepairCostApp.Forms
{
    partial class FormRepairWorks
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Button ButtonAdd;
        private Button ButtonDel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewData = new DataGridView();
            this.ButtonAdd = new Button();
            this.ButtonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new Point(12, 12);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new Size(550, 450);

            this.ButtonAdd.Location = new Point(580, 12);
            this.ButtonAdd.Size = new Size(150, 50);
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Click += new EventHandler(this.ButtonAdd_Click);

            this.ButtonDel.Location = new Point(580, 80);
            this.ButtonDel.Size = new Size(150, 50);
            this.ButtonDel.Text = "Удалить";
            this.ButtonDel.Click += new EventHandler(this.ButtonDel_Click);

            this.ClientSize = new Size(750, 480);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "FormRepairWorks";
            this.Text = "Список ремонтных работ";
            this.Load += new EventHandler(this.FormRepairWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
        }
    }
}