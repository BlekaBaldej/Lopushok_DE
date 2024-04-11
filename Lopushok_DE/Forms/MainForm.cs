using Lopushok_DE.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok_DE
{
    public partial class MainForm : Form
    {
        private int _currentPage;

        public MainForm()
        {
            InitializeComponent();
            _currentPage = 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Fill ComboBoxes
            sortCB.SelectedIndex = 0;

            var productTypes = Getter.db.ProductType.Select(pt => pt.Title).ToList();
            productTypes.Insert(0, "Все типы");

            filterCB.DataSource = productTypes;

            // Prepare Data
            PrepareProductsData();
        }

        private void PrepareProductsData()
        {
            // Get
            var list = Getter.db.Product.ToList();

            // Search
            list = list.Where(pr => (pr.Title + pr.Description).ToLower().Contains(searchTB.Text.ToLower())).ToList();

            // Sort
            switch ((Sorting)sortCB.SelectedIndex)
            {
                case Sorting.Ascending:
                    list = list
                        .OrderBy(pr => pr.Title)
                        .OrderBy(pr => pr.ProductionWorkshopNumber)
                        .OrderBy(pr => pr.MinCostForAgent)
                        .ToList();
                    break;
                case Sorting.Descending:
                    list = list
                        .OrderByDescending(pr => pr.Title)
                        .OrderByDescending(pr => pr.ProductionWorkshopNumber)
                        .OrderByDescending(pr => pr.MinCostForAgent)
                        .ToList();
                    break;
            }

            // Filter
            if (filterCB.SelectedIndex != 0)
                list = list.Where(pr => pr.ProductTypeID == filterCB.SelectedIndex).ToList();

            // Generate and Show Text for Pages
            var countPageElem = 20;
            var countPages = (list.Count % countPageElem == 0) ? list.Count / countPageElem : list.Count / countPageElem + 1;

            if (_currentPage > countPages)
                _currentPage = countPages;
            else if (_currentPage < 1)
                _currentPage = 1;

            var stringsPages = new List<string>();
            for (int i = 1; i <= countPages; i++)
            {
                if (i == _currentPage)
                    stringsPages.Add($"({i})");
                else 
                    stringsPages.Add(i.ToString());
            }

            pagesList.Text = string.Join(" ", stringsPages);

            // Slice Page
            list = list.Skip((_currentPage - 1) * countPageElem).Take(countPageElem).ToList();

            // Show
            productsP.Controls.Clear();
            foreach (var product in list)
            {
                productsP.Controls.Add(new ProductUserControl(product, PrepareProductsData)
                {
                    Dock = DockStyle.Top,
                });
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            PrepareProductsData();
        }

        private void sortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareProductsData();
        }

        private void filterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareProductsData();
        }

        private void pagesPrev_Click(object sender, EventArgs e)
        {
            _currentPage--;
            PrepareProductsData();
        }

        private void pagesNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            PrepareProductsData();
        }
    }
}
