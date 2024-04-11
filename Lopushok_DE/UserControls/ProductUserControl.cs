using Lopushok_DE.Forms;
using Lopushok_DE.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok_DE
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        UpdateProducts _updateProducts;
        public ProductUserControl(Product product, UpdateProducts up)
        {
            InitializeComponent();
            _product = product;
            _updateProducts = up;
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            titleL.Text = $"{_product.ProductType.Title} | {_product.Title}";
            articleL.Text = _product.ArticleNumber;

            imagePB.Image = Image.FromFile(_product.Image == string.Empty ? "products\\null.png" : _product.Image);

            var materials = Getter.db.ProductMaterial
                .Where(pm => pm.ProductID == _product.ID)
                .Select(pm => pm.Material.Title)
                .ToList();

            materialsL.Text = "Материалы: " + string.Join(", ", materials);

            costL.Text = Getter.db.ProductMaterial
                .Where(pm => pm.ProductID == _product.ID)
                .Select(pm => pm.Material.Cost)
                .ToList()
                .Sum()
                .ToString() + " руб.";
        }


        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            new EditForm(_product.ID, _updateProducts).ShowDialog();
        }
    }
}
