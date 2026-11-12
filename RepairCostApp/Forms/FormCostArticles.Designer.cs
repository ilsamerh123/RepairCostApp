namespace RepairCostApp.Forms
{
    partial class FormCostArticles
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

            this.ButtonUpd.Location = new Point(580, 80);
            this.ButtonUpd.Size = new Size(150, 50);
            this.ButtonUpd.Text = "Изменить";
            this.ButtonUpd.Click += new EventHandler(this.ButtonUpd_Click);

            this.ButtonDel.Location = new Point(580, 148);
            this.ButtonDel.Size = new Size(150, 50);
            this.ButtonDel.Text = "Удалить";
            this.ButtonDel.Click += new EventHandler(this.ButtonDel_Click);

            this.ClientSize = new Size(750, 480);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonUpd);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "FormCostArticles";
            this.Text = "Список статей затрат";
            this.Load += new EventHandler(this.FormCostArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
        }
    }
}