using RepairCostApp.Repositories;
using RepairCostApp.Entities;
namespace RepairCostApp.Forms
{
    public partial class FormSelectWork : Form
    {
        private readonly IRepairWorkRepository _workRepository;

        public RepairWork? SelectedWork { get; private set; }

        public FormSelectWork(IRepairWorkRepository workRepository, int roomId)
        {
            InitializeComponent();
            _workRepository = workRepository;
            dataGridViewWorks.DataSource = _workRepository.ReadRepairWorks().Where(w => w.RoomId == roomId).ToList();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorks.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите работу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridViewWorks.SelectedRows[0].Cells["Id"].Value);
            SelectedWork = _workRepository.ReadRepairWorks().FirstOrDefault(w => w.Id == id);
            if (SelectedWork == null)
            {
                MessageBox.Show("Работа не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}