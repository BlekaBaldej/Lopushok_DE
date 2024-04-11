namespace Lopushok_DE
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.productsP = new System.Windows.Forms.Panel();
            this.sortCB = new System.Windows.Forms.ComboBox();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.pagesP = new System.Windows.Forms.Panel();
            this.pagesPrev = new System.Windows.Forms.Label();
            this.pagesList = new System.Windows.Forms.Label();
            this.pagesNext = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.pagesP.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsP
            // 
            this.productsP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsP.AutoScroll = true;
            this.productsP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsP.Location = new System.Drawing.Point(9, 68);
            this.productsP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productsP.Name = "productsP";
            this.productsP.Size = new System.Drawing.Size(720, 350);
            this.productsP.TabIndex = 0;
            // 
            // sortCB
            // 
            this.sortCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortCB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sortCB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortCB.FormattingEnabled = true;
            this.sortCB.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.sortCB.Location = new System.Drawing.Point(422, 16);
            this.sortCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortCB.Name = "sortCB";
            this.sortCB.Size = new System.Drawing.Size(152, 28);
            this.sortCB.TabIndex = 1;
            this.sortCB.SelectedIndexChanged += new System.EventHandler(this.sortCB_SelectedIndexChanged);
            // 
            // filterCB
            // 
            this.filterCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterCB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filterCB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Location = new System.Drawing.Point(578, 16);
            this.filterCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(152, 28);
            this.filterCB.TabIndex = 2;
            this.filterCB.SelectedIndexChanged += new System.EventHandler(this.filterCB_SelectedIndexChanged);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchTB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(16, 16);
            this.searchTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(402, 26);
            this.searchTB.TabIndex = 3;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // pagesP
            // 
            this.pagesP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pagesP.BackColor = System.Drawing.SystemColors.Control;
            this.pagesP.Controls.Add(this.pagesPrev);
            this.pagesP.Controls.Add(this.pagesList);
            this.pagesP.Controls.Add(this.pagesNext);
            this.pagesP.Location = new System.Drawing.Point(246, 423);
            this.pagesP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pagesP.Name = "pagesP";
            this.pagesP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pagesP.Size = new System.Drawing.Size(483, 30);
            this.pagesP.TabIndex = 4;
            // 
            // pagesPrev
            // 
            this.pagesPrev.AutoSize = true;
            this.pagesPrev.Dock = System.Windows.Forms.DockStyle.Right;
            this.pagesPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesPrev.Location = new System.Drawing.Point(401, 0);
            this.pagesPrev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagesPrev.Name = "pagesPrev";
            this.pagesPrev.Size = new System.Drawing.Size(31, 24);
            this.pagesPrev.TabIndex = 2;
            this.pagesPrev.Text = " < ";
            this.pagesPrev.Click += new System.EventHandler(this.pagesPrev_Click);
            // 
            // pagesList
            // 
            this.pagesList.AutoSize = true;
            this.pagesList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pagesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesList.Location = new System.Drawing.Point(432, 0);
            this.pagesList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagesList.Name = "pagesList";
            this.pagesList.Size = new System.Drawing.Size(20, 24);
            this.pagesList.TabIndex = 1;
            this.pagesList.Text = "1";
            // 
            // pagesNext
            // 
            this.pagesNext.AutoSize = true;
            this.pagesNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.pagesNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesNext.Location = new System.Drawing.Point(452, 0);
            this.pagesNext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagesNext.Name = "pagesNext";
            this.pagesNext.Size = new System.Drawing.Size(31, 24);
            this.pagesNext.TabIndex = 0;
            this.pagesNext.Text = " > ";
            this.pagesNext.Click += new System.EventHandler(this.pagesNext_Click);
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProduct.Location = new System.Drawing.Point(9, 423);
            this.addProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(184, 30);
            this.addProduct.TabIndex = 5;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.pagesP);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.filterCB);
            this.Controls.Add(this.sortCB);
            this.Controls.Add(this.productsP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pagesP.ResumeLayout(false);
            this.pagesP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel productsP;
        private System.Windows.Forms.ComboBox sortCB;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Panel pagesP;
        private System.Windows.Forms.Label pagesPrev;
        private System.Windows.Forms.Label pagesList;
        private System.Windows.Forms.Label pagesNext;
        private System.Windows.Forms.Button addProduct;
    }
}