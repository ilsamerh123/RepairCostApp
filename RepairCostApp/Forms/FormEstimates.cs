using RepairCostApp.Repositories;
using Unity;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormEstimates : Form
    {
        private readonly IUnityContainer _container;
        private readonly IEstimateRepository _estimateRepository;

        public FormEstimates(IUnityContainer container, IEstimateRepository estimateRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _estimateRepository = estimateRepository ?? throw new ArgumentNullException(nameof(estimateRepository));
        }

        private void FormEstimates_Load(object sender, EventArgs e) => LoadList();

        private void LoadList()
        {
            try { dataGridViewData.DataSource = _estimateRepository.ReadEstimates(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _container.Resolve<FormEstimateEdit>();
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

            if (MessageBox.Show("Удалить смету?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _estimateRepository.DeleteEstimate(id);
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}