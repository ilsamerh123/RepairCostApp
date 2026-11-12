namespace RepairCostApp.Forms
{
    partial class FormRoomEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAddress = new TextBox();
            Address = new Label();
            Square = new Label();
            numericUpDownArea = new NumericUpDown();
            Type = new Label();
            comboBoxType = new ComboBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArea).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(23, 63);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(127, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(23, 30);
            Address.Name = "Address";
            Address.Size = new Size(51, 20);
            Address.TabIndex = 2;
            Address.Text = "Адрес";
            // 
            // Square
            // 
            Square.AutoSize = true;
            Square.Location = new Point(23, 119);
            Square.Name = "Square";
            Square.Size = new Size(73, 20);
            Square.TabIndex = 4;
            Square.Text = "Площадь";
            // 
            // numericUpDownArea
            // 
            numericUpDownArea.DecimalPlaces = 2;
            numericUpDownArea.Location = new Point(23, 155);
            numericUpDownArea.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownArea.Name = "numericUpDownArea";
            numericUpDownArea.Size = new Size(150, 27);
            numericUpDownArea.TabIndex = 5;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(24, 208);
            Type.Name = "Type";
            Type.Size = new Size(35, 20);
            Type.TabIndex = 6;
            Type.Text = "Тип";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(24, 246);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 7;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(24, 340);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(151, 56);
            ButtonSave.TabIndex = 8;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(236, 340);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(151, 56);
            ButtonCancel.TabIndex = 9;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // FormRoomEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(comboBoxType);
            Controls.Add(Type);
            Controls.Add(numericUpDownArea);
            Controls.Add(Square);
            Controls.Add(Address);
            Controls.Add(textBoxAddress);
            Name = "FormRoomEdit";
            Text = "Добавление/Редактирование помещения";
            ((System.ComponentModel.ISupportInitialize)numericUpDownArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private Label Address;
        private Label Square;
        private NumericUpDown numericUpDownArea;
        private Label Type;
        private ComboBox comboBoxType;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}