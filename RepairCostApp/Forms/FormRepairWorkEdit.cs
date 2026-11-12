using RepairCostApp.Repositories;
using RepairCostApp.Entities;
using RepairCostApp.Entities.Enums;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormRepairWorkEdit : Form
    {
        private readonly IRepairWorkRepository _workRepository;

        public FormRepairWorkEdit(
            IRepairWorkRepository workRepository,
            IRoomRepository roomRepository,
            IContractorRepository contractorRepository,
            ICostArticleRepository articleRepository)
        {
            InitializeComponent();
            _workRepository = workRepository;

            // Заполняем ComboBox-ы данными из справочников (пока заглушки пустые)
            comboBoxRoom.DataSource = roomRepository.ReadRooms();
            comboBoxRoom.DisplayMember = "Address";
            comboBoxRoom.ValueMember = "Id";

            comboBoxContractor.DataSource = contractorRepository.ReadContractors();
            comboBoxContractor.DisplayMember = "Name";
            comboBoxContractor.ValueMember = "Id";

            comboBoxArticle.DataSource = articleRepository.ReadCostArticles();
            comboBoxArticle.DisplayMember = "Name";
            comboBoxArticle.ValueMember = "Id";

            // Заполняем CheckedListBox категориями (флаговое перечисление)
            foreach (var val in Enum.GetValues(typeof(WorkCategory)))
            {
                checkedListBoxCategory.Items.Add(val);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверки на пустые значения
                if (comboBoxRoom.SelectedIndex < 0 || comboBoxContractor.SelectedIndex < 0 || comboBoxArticle.SelectedIndex < 0)
                    throw new Exception("Выберите значения во всех выпадающих списках.");

                // Собираем выбранные категории (флаговое перечисление)
                WorkCategory category = WorkCategory.None;
                foreach (var item in checkedListBoxCategory.CheckedItems)
                {
                    category |= (WorkCategory)item;
                }

                if (category == WorkCategory.None)
                    throw new Exception("Выберите хотя бы одну категорию работ.");

                // Создаем объект
                var work = RepairWork.CreateOperation(
                    0,
                    dateTimePickerDate.Value,
                    (double)numericUpDownQuantity.Value,
                    numericUpDownPrice.Value,
                    category,
                    (int)comboBoxRoom.SelectedValue!,
                    (int)comboBoxContractor.SelectedValue!,
                    (int)comboBoxArticle.SelectedValue!
                );

                _workRepository.CreateRepairWork(work);

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