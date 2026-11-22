using RepairCostApp.Repositories;
using Unity;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormRepairWorks : Form
    {
        private readonly IUnityContainer _container;
        private readonly IRepairWorkRepository _workRepository;

        public FormRepairWorks(IUnityContainer container, IRepairWorkRepository workRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _workRepository = workRepository ?? throw new ArgumentNullException(nameof(workRepository));
        }

        private void FormRepairWorks_Load(object sender, EventArgs e) => LoadList();

        private void LoadList()
        {
            try { dataGridViewData.DataSource = _workRepository.ReadRepairWorks(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _container.Resolve<FormRepairWorkEdit>();
                if (form.ShowDialog() == DialogResult.OK) LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _workRepository.DeleteRepairWork(id);
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}