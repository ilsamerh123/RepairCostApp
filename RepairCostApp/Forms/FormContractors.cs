using RepairCostApp.Repositories;
using Unity;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormContractors : Form
    {
        private readonly IUnityContainer _container;
        private readonly IContractorRepository _contractorRepository;

        public FormContractors(IUnityContainer container, IContractorRepository contractorRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _contractorRepository = contractorRepository ?? throw new ArgumentNullException(nameof(contractorRepository));
        }

        private void FormContractors_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            try
            {
                dataGridViewData.DataSource = null; 
                dataGridViewData.DataSource = _contractorRepository.ReadContractors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _container.Resolve<FormContractorEdit>();
                if (form.ShowDialog() == DialogResult.OK)
                    LoadList(); 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try
            {
                var form = _container.Resolve<FormContractorEdit>();
                form.ContractorId = findId;
                if (form.ShowDialog() != DialogResult.OK)
                    LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _contractorRepository.DeleteContractor(findId);
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}