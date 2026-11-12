namespace RepairCostApp.Forms
{
    partial class FormContractors
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Button ButtonAdd;
        private Button ButtonUpd;
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
            this.ButtonUpd = new Button();
            this.ButtonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();

            // dataGridViewData
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new Point(12, 12);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new Size(550, 450);

            // ButtonAdd
            this.ButtonAdd.Location = new Point(580, 12);
            this.ButtonAdd.Size = new Size(150, 50);
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Click += new EventHandler(this.ButtonAdd_Click);

            // ButtonUpd
            this.ButtonUpd.Location = new Point(580, 80);
            this.ButtonUpd.Size = new Size(150, 50);
            this.ButtonUpd.Text = "Изменить";
            this.ButtonUpd.Name = "ButtonUpd";
            this.ButtonUpd.Click += new EventHandler(this.ButtonUpd_Click);

            // ButtonDel
            this.ButtonDel.Location = new Point(580, 148);
            this.ButtonDel.Size = new Size(150, 50);
            this.ButtonDel.Text = "Удалить";
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Click += new EventHandler(this.ButtonDel_Click);

            // FormContractors
            this.ClientSize = new Size(750, 480);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonUpd);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "FormContractors";
            this.Text = "Список подрядчиков";
            this.Load += new EventHandler(this.FormContractors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
        }
    }
}