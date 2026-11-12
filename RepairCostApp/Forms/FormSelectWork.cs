using RepairCostApp.Repositories;
using RepairCostApp.Entities;
using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormSelectWork : Form
    {
        public RepairWork SelectedWork { get; private set; }

        public FormSelectWork(IRepairWorkRepository workRepository)
        {
            InitializeComponent();
            // Загружаем список работ
            dataGridViewWorks.DataSource = workRepository.ReadRepairWorks();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorks.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите работу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Берем выбранную работу (в заглушке это будет тестовый объект)
            // В реальной БД здесь мы бы получали объект из репозитория по ID
            int id = Convert.ToInt32(dataGridViewWorks.SelectedRows[0].Cells["Id"].Value);

            // Для заглушки создадим тестовый объект (потом заменим на получение из БД)
            SelectedWork = RepairWork.CreateOperation(id, DateTime.Now, 1, 100, Entities.Enums.WorkCategory.None, 1, 1, 1);

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