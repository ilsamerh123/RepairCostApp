using System;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;

        // Справочники
        private ToolStripMenuItem directoryToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem contractorsToolStripMenuItem;
        private ToolStripMenuItem costArticlesToolStripMenuItem; 

        // Операции
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem repairWorksToolStripMenuItem;
        private ToolStripMenuItem estimatesToolStripMenuItem; 

        // Отчеты
        private ToolStripMenuItem reportsToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();

            this.directoryToolStripMenuItem = new ToolStripMenuItem();
            this.roomsToolStripMenuItem = new ToolStripMenuItem();
            this.contractorsToolStripMenuItem = new ToolStripMenuItem();
            this.costArticlesToolStripMenuItem = new ToolStripMenuItem(); 

            this.operationsToolStripMenuItem = new ToolStripMenuItem();
            this.repairWorksToolStripMenuItem = new ToolStripMenuItem();
            this.estimatesToolStripMenuItem = new ToolStripMenuItem(); 

            this.reportsToolStripMenuItem = new ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.directoryToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 28);
            this.menuStrip1.TabIndex = 0;

            // directoryToolStripMenuItem (Справочники)
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.contractorsToolStripMenuItem,
            this.costArticlesToolStripMenuItem}); 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Text = "Справочники";

            // roomsToolStripMenuItem
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Text = "Помещения";
            this.roomsToolStripMenuItem.Click += new EventHandler(this.RoomsToolStripMenuItem_Click);

            // contractorsToolStripMenuItem
            this.contractorsToolStripMenuItem.Name = "contractorsToolStripMenuItem";
            this.contractorsToolStripMenuItem.Text = "Подрядчики";
            this.contractorsToolStripMenuItem.Click += new EventHandler(this.ContractorsToolStripMenuItem_Click);

            // costArticlesToolStripMenuItem (Статьи затрат)
            this.costArticlesToolStripMenuItem.Name = "costArticlesToolStripMenuItem";
            this.costArticlesToolStripMenuItem.Text = "Статьи затрат";
            this.costArticlesToolStripMenuItem.Click += new EventHandler(this.CostArticlesToolStripMenuItem_Click);

            // operationsToolStripMenuItem (Операции)
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.repairWorksToolStripMenuItem,
            this.estimatesToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Text = "Операции";

            // repairWorksToolStripMenuItem
            this.repairWorksToolStripMenuItem.Name = "repairWorksToolStripMenuItem";
            this.repairWorksToolStripMenuItem.Text = "Ремонтные работы";
            this.repairWorksToolStripMenuItem.Click += new EventHandler(this.RepairWorksToolStripMenuItem_Click);

            // estimatesToolStripMenuItem (Сметы)
            this.estimatesToolStripMenuItem.Name = "estimatesToolStripMenuItem";
            this.estimatesToolStripMenuItem.Text = "Сметы";
            this.estimatesToolStripMenuItem.Click += new EventHandler(this.EstimatesToolStripMenuItem_Click);

            // reportsToolStripMenuItem (Отчеты)
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Text = "Отчеты";

            // MainForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Учет стоимости ремонтных работ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}