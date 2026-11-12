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

        private void RepairWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormRepairWorks>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void CostArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormCostArticles>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
        private void EstimatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormEstimates>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}