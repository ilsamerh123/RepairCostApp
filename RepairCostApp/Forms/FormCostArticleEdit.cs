using RepairCostApp.Repositories;
using RepairCostApp.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RepairCostApp.Forms
{
    public partial class FormCostArticleEdit : Form
    {
        private readonly ICostArticleRepository _articleRepository;
        private int? _articleId;

        public FormCostArticleEdit(ICostArticleRepository articleRepository)
        {
            InitializeComponent();
            _articleRepository = articleRepository ?? throw new ArgumentNullException(nameof(articleRepository));
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ArticleId
        {
            set
            {
                _articleId = value;
                var article = _articleRepository.ReadCostArticleById(value);
                textBoxName.Text = article.Name;
                textBoxUnit.Text = article.Unit;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                    throw new Exception("Введите название статьи.");

                var article = CostArticle.CreateEntity(
                    _articleId ?? 0,
                    textBoxName.Text,
                    textBoxUnit.Text
                );

                if (_articleId.HasValue)
                    _articleRepository.UpdateCostArticle(article);
                else
                    _articleRepository.CreateCostArticle(article);

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