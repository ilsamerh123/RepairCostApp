namespace RepairCostApp.Forms
{
    partial class FormRooms
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
            this.dataGridViewData.Location = new Point(2, 1);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new Size(574, 503);

            // ButtonAdd
            this.ButtonAdd.Location = new Point(582, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(169, 57);
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Click += new EventHandler(this.ButtonAdd_Click);

            // ButtonUpd
            this.ButtonUpd.Location = new Point(582, 86);
            this.ButtonUpd.Name = "ButtonUpd";
            this.ButtonUpd.Size = new Size(169, 57);
            this.ButtonUpd.Text = "Изменить";
            this.ButtonUpd.Click += new EventHandler(this.ButtonUpd_Click);

            // ButtonDel
            this.ButtonDel.Location = new Point(582, 164);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new Size(169, 57);
            this.ButtonDel.Text = "Удалить";
            this.ButtonDel.Click += new EventHandler(this.ButtonDel_Click);

            // FormRooms
            this.ClientSize = new Size(1069, 505);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonUpd);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "FormRooms";
            this.Text = "Список помещений";
            this.Load += new EventHandler(this.FormRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
        }
    }
}