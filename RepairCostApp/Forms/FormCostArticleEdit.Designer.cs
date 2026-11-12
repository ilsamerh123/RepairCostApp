namespace RepairCostApp.Forms
{
    partial class FormCostArticleEdit
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelUnit;
        private TextBox textBoxUnit;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelName = new Label();
            this.textBoxName = new TextBox();
            this.labelUnit = new Label();
            this.textBoxUnit = new TextBox();
            this.ButtonSave = new Button();
            this.ButtonCancel = new Button();
            this.SuspendLayout();

            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(30, 30);
            this.labelName.Text = "Название:";

            this.textBoxName.Location = new Point(30, 60);
            this.textBoxName.Size = new Size(250, 27);
            this.textBoxName.Name = "textBoxName";

            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new Point(30, 100);
            this.labelUnit.Text = "Единица измерения:";

            this.textBoxUnit.Location = new Point(30, 130);
            this.textBoxUnit.Size = new Size(250, 27);
            this.textBoxUnit.Name = "textBoxUnit";

            this.ButtonSave.Location = new Point(30, 200);
            this.ButtonSave.Size = new Size(120, 40);
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.ButtonCancel.Location = new Point(160, 200);
            this.ButtonCancel.Size = new Size(120, 40);
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormCostArticleEdit";
            this.Text = "Редактирование статьи затрат";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}