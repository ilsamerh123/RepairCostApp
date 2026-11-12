using RepairCostApp.Repositories;
using RepairCostApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace RepairCostApp.Forms
{
    public partial class FormEstimateEdit : Form
    {
        private readonly IEstimateRepository _estimateRepository;
        private readonly IUnityContainer _container;
        private readonly List<RepairWork> _selectedWorks = new List<RepairWork>();

        public FormEstimateEdit(IEstimateRepository estimateRepository, IUnityContainer container, IRoomRepository roomRepository)
        {
            InitializeComponent();
            _estimateRepository = estimateRepository;
            _container = container;

            comboBoxRoom.DataSource = roomRepository.ReadRooms();
            comboBoxRoom.DisplayMember = "Address";
            comboBoxRoom.ValueMember = "Id";
        }

        private void ButtonAddWork_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<FormSelectWork>();
            if (form.ShowDialog() == DialogResult.OK && form.SelectedWork != null)
            {
                _selectedWorks.Add(form.SelectedWork);
                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            
            dataGridViewItems.DataSource = null;
            dataGridViewItems.DataSource = _selectedWorks;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoom.SelectedIndex < 0)
                    throw new Exception("Выберите помещение.");

                if (_selectedWorks.Count == 0)
                    throw new Exception("Добавьте хотя бы одну работу в смету.");

                decimal total = _selectedWorks.Sum(w => (decimal)w.Quantity * w.Price);

                var estimate = Estimate.CreateOperation(
                    0,
                    dateTimePickerDate.Value,
                    total,
                    (int)comboBoxRoom.SelectedValue!
                );

                var items = _selectedWorks.Select(w => EstimateItem.CreateElement(0, 0, w.Id)).ToList();

                _estimateRepository.CreateEstimate(estimate, items);

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