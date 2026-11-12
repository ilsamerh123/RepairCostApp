using System;
using System.Windows.Forms;
using Unity;
using RepairCostApp.Forms;

namespace RepairCostApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        // --- Справочники ---
        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormRooms>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ContractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormContractors>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // --- Операции ---
        private void RepairWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Здесь будет ошибка, пока мы не создадим форму FormRepairWorks. 
            // Это нормально, мы сделаем её на следующем шаге!
            try { _container.Resolve<FormRepairWorks>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}