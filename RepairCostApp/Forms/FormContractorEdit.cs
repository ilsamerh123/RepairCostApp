using RepairCostApp.Repositories;
using RepairCostApp.Entities;
using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormContractorEdit : Form
    {
        private readonly IContractorRepository _contractorRepository;
        private int? _contractorId;

        public FormContractorEdit(IContractorRepository contractorRepository)
        {
            InitializeComponent();
            _contractorRepository = contractorRepository ?? throw new ArgumentNullException(nameof(contractorRepository));
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ContractorId
        {
            set
            {
                _contractorId = value;
                var contractor = _contractorRepository.ReadContractorById(value);
                textBoxName.Text = contractor.Name;
                textBoxINN.Text = contractor.INN;
                textBoxPhone.Text = contractor.Phone;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxINN.Text))
                {
                    throw new Exception("Поля 'Имя' и 'ИНН' обязательны для заполнения.");
                }

                var contractor = Contractor.CreateEntity(
                    _contractorId ?? 0,
                    textBoxName.Text,
                    textBoxINN.Text,
                    textBoxPhone.Text
                );

                if (_contractorId.HasValue)
                    _contractorRepository.UpdateContractor(contractor);
                else
                    _contractorRepository.CreateContractor(contractor);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}