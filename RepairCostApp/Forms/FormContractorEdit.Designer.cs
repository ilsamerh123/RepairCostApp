namespace RepairCostApp.Forms
{
    partial class FormContractorEdit
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelINN;
        private TextBox textBoxINN;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelINN = new Label();
            textBoxINN = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(124, 20);
            labelName.TabIndex = 7;
            labelName.Text = "Имя / Название:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(30, 60);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 6;
            // 
            // labelINN
            // 
            labelINN.AutoSize = true;
            labelINN.Location = new Point(30, 100);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(45, 20);
            labelINN.TabIndex = 5;
            labelINN.Text = "ИНН:";
            // 
            // textBoxINN
            // 
            textBoxINN.Location = new Point(30, 130);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(250, 27);
            textBoxINN.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(30, 170);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 20);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(30, 200);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(250, 27);
            textBoxPhone.TabIndex = 2;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(30, 260);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(120, 40);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(160, 260);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(120, 40);
            ButtonCancel.TabIndex = 0;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // FormContractorEdit
            // 
            ClientSize = new Size(498, 403);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxINN);
            Controls.Add(labelINN);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "FormContractorEdit";
            Text = "Редактирование подрядчика";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}