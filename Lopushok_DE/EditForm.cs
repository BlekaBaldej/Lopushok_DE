using Lopushok_DE.ModelEF;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok_DE
{
    public delegate void UpdateProducts();
    public partial class EditForm : Form
    {
        Product _product;
        string _imagePath;
        private Button saveButton;
        private Button deleteButton;
        private ComboBox productTypeComboBox;
        private PictureBox imagePB;
        private TextBox articleNumberTextBox;
        private TextBox descriptionTextBox;
        private TextBox minCostForAgentTextBox;
        private TextBox productionPersonCountTextBox;
        private TextBox productionWorkshopNumberTextBox;
        private TextBox titleTextBox;
        UpdateProducts _updateProducts;
        public EditForm(int productId, UpdateProducts up)
        {
            InitializeComponent();
            _product = Getter.db.Product.First(pr => pr.ID == productId);
            _imagePath = _product.Image == string.Empty ? "products\\null.png" : _product.Image;
            _updateProducts = up;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = _product.Title;
            articleNumberTextBox.Text = _product.ArticleNumber;
            productionWorkshopNumberTextBox.Text = _product.ProductionWorkshopNumber.ToString();
            productionPersonCountTextBox.Text = _product.ProductionPersonCount.ToString();
            minCostForAgentTextBox.Text = _product.MinCostForAgent.ToString();
            descriptionTextBox.Text = _product.Description;

            productTypeComboBox.DataSource = Getter.db.ProductType.Select(pr => pr.Title).ToList();
            productTypeComboBox.SelectedIndex = (_product.ProductTypeID ?? 1) - 1;

            imagePB.Image = Image.FromFile(_imagePath);
        }

        private void imagePB_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.imagePB = new System.Windows.Forms.PictureBox();
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(453, 376);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 40);
            this.saveButton.TabIndex = 46;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(10, 376);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 40);
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Location = new System.Drawing.Point(359, 33);
            this.productTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(244, 21);
            this.productTypeComboBox.TabIndex = 44;
            // 
            // imagePB
            // 
            this.imagePB.Location = new System.Drawing.Point(12, 33);
            this.imagePB.Margin = new System.Windows.Forms.Padding(2);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(154, 116);
            this.imagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePB.TabIndex = 43;
            this.imagePB.TabStop = false;
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Location = new System.Drawing.Point(212, 59);
            articleNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(51, 13);
            articleNumberLabel.TabIndex = 29;
            articleNumberLabel.Text = "Артикул:";
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.Location = new System.Drawing.Point(359, 57);
            this.articleNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(244, 20);
            this.articleNumberTextBox.TabIndex = 30;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 167);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 31;
            descriptionLabel.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(83, 164);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(520, 88);
            this.descriptionTextBox.TabIndex = 32;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(10, 8);
            imageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(80, 13);
            imageLabel.TabIndex = 33;
            imageLabel.Text = "Изображение:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Location = new System.Drawing.Point(212, 130);
            minCostForAgentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(149, 13);
            minCostForAgentLabel.TabIndex = 34;
            minCostForAgentLabel.Text = "Мин. стоимость для агента:";
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(359, 125);
            this.minCostForAgentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(244, 20);
            this.minCostForAgentTextBox.TabIndex = 35;
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Location = new System.Drawing.Point(212, 107);
            productionPersonCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(88, 13);
            productionPersonCountLabel.TabIndex = 36;
            productionPersonCountLabel.Text = "Кол-во человек:";
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(359, 103);
            this.productionPersonCountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(244, 20);
            this.productionPersonCountTextBox.TabIndex = 37;
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(212, 82);
            productionWorkshopNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(47, 13);
            productionWorkshopNumberLabel.TabIndex = 38;
            productionWorkshopNumberLabel.Text = "№ цеха:";
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(359, 80);
            this.productionWorkshopNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(244, 20);
            this.productionWorkshopNumberTextBox.TabIndex = 39;
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Location = new System.Drawing.Point(212, 39);
            productTypeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(78, 13);
            productTypeIDLabel.TabIndex = 40;
            productTypeIDLabel.Text = "Тип продукта:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(212, 16);
            titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(60, 13);
            titleLabel.TabIndex = 41;
            titleLabel.Text = "Название:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(359, 11);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(244, 20);
            this.titleTextBox.TabIndex = 42;
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(610, 425);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.productTypeComboBox);
            this.Controls.Add(this.imagePB);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
