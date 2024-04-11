namespace Lopushok_DE
{
    partial class ProductUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePB = new System.Windows.Forms.PictureBox();
            this.titleL = new System.Windows.Forms.Label();
            this.articleL = new System.Windows.Forms.Label();
            this.materialsL = new System.Windows.Forms.Label();
            this.costL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePB
            // 
            this.imagePB.Location = new System.Drawing.Point(13, 15);
            this.imagePB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(235, 155);
            this.imagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePB.TabIndex = 0;
            this.imagePB.TabStop = false;
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleL.Location = new System.Drawing.Point(282, 15);
            this.titleL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(220, 33);
            this.titleL.TabIndex = 1;
            this.titleL.Text = "Тип\\Наименование";
            // 
            // articleL
            // 
            this.articleL.AutoSize = true;
            this.articleL.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleL.Location = new System.Drawing.Point(284, 60);
            this.articleL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.articleL.Name = "articleL";
            this.articleL.Size = new System.Drawing.Size(61, 22);
            this.articleL.TabIndex = 2;
            this.articleL.Text = "Артикул";
            // 
            // materialsL
            // 
            this.materialsL.AutoSize = true;
            this.materialsL.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialsL.Location = new System.Drawing.Point(284, 109);
            this.materialsL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialsL.Name = "materialsL";
            this.materialsL.Size = new System.Drawing.Size(86, 22);
            this.materialsL.TabIndex = 3;
            this.materialsL.Text = "Материалы";
            // 
            // costL
            // 
            this.costL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.costL.AutoSize = true;
            this.costL.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costL.Location = new System.Drawing.Point(793, 15);
            this.costL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(44, 22);
            this.costL.TabIndex = 4;
            this.costL.Text = "Цена";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.costL);
            this.Controls.Add(this.materialsL);
            this.Controls.Add(this.articleL);
            this.Controls.Add(this.titleL);
            this.Controls.Add(this.imagePB);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(877, 202);
            this.Load += new System.EventHandler(this.ProductUserControl_Load);
            this.Click += new System.EventHandler(this.ProductUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePB;
        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.Label articleL;
        private System.Windows.Forms.Label materialsL;
        private System.Windows.Forms.Label costL;
    }
}
