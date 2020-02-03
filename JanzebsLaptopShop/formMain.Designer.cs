namespace JanzebsLaptopShop
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.labelCurrentLaptop = new System.Windows.Forms.Label();
            this.buttonPreviousLaptop = new System.Windows.Forms.Button();
            this.buttonNextLaptop = new System.Windows.Forms.Button();
            this.textLaptop = new System.Windows.Forms.TextBox();
            this.numericUpDownHigherPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowerPrice = new System.Windows.Forms.NumericUpDown();
            this.labelSetPriceRange = new System.Windows.Forms.Label();
            this.labelFromPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindRange = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.panelSetPriceRange = new System.Windows.Forms.Panel();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelAscendingPriceOrder = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelLoadList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFindLaptop = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHigherPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerPrice)).BeginInit();
            this.panelSetPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentLaptop
            // 
            this.labelCurrentLaptop.AutoSize = true;
            this.labelCurrentLaptop.Location = new System.Drawing.Point(938, 53);
            this.labelCurrentLaptop.Name = "labelCurrentLaptop";
            this.labelCurrentLaptop.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentLaptop.TabIndex = 0;
            // 
            // buttonPreviousLaptop
            // 
            this.buttonPreviousLaptop.Location = new System.Drawing.Point(19, 10);
            this.buttonPreviousLaptop.Name = "buttonPreviousLaptop";
            this.buttonPreviousLaptop.Size = new System.Drawing.Size(75, 25);
            this.buttonPreviousLaptop.TabIndex = 1;
            this.buttonPreviousLaptop.Text = "Previous";
            this.buttonPreviousLaptop.UseVisualStyleBackColor = true;
            this.buttonPreviousLaptop.Click += new System.EventHandler(this.buttonPreviousLaptop_Click);
            // 
            // buttonNextLaptop
            // 
            this.buttonNextLaptop.Location = new System.Drawing.Point(117, 10);
            this.buttonNextLaptop.Name = "buttonNextLaptop";
            this.buttonNextLaptop.Size = new System.Drawing.Size(75, 25);
            this.buttonNextLaptop.TabIndex = 2;
            this.buttonNextLaptop.Text = "Next";
            this.buttonNextLaptop.UseVisualStyleBackColor = true;
            this.buttonNextLaptop.Click += new System.EventHandler(this.buttonNextLaptop_Click);
            // 
            // textLaptop
            // 
            this.textLaptop.BackColor = System.Drawing.Color.Snow;
            this.textLaptop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLaptop.Location = new System.Drawing.Point(35, 79);
            this.textLaptop.Multiline = true;
            this.textLaptop.Name = "textLaptop";
            this.textLaptop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLaptop.Size = new System.Drawing.Size(1016, 235);
            this.textLaptop.TabIndex = 3;
            this.textLaptop.WordWrap = false;
            this.textLaptop.TextChanged += new System.EventHandler(this.textLaptop_TextChanged);
            // 
            // numericUpDownHigherPrice
            // 
            this.numericUpDownHigherPrice.BackColor = System.Drawing.Color.Snow;
            this.numericUpDownHigherPrice.Location = new System.Drawing.Point(114, 106);
            this.numericUpDownHigherPrice.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownHigherPrice.Name = "numericUpDownHigherPrice";
            this.numericUpDownHigherPrice.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHigherPrice.TabIndex = 5;
            // 
            // numericUpDownLowerPrice
            // 
            this.numericUpDownLowerPrice.BackColor = System.Drawing.Color.Snow;
            this.numericUpDownLowerPrice.Location = new System.Drawing.Point(114, 60);
            this.numericUpDownLowerPrice.Name = "numericUpDownLowerPrice";
            this.numericUpDownLowerPrice.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLowerPrice.TabIndex = 6;
            // 
            // labelSetPriceRange
            // 
            this.labelSetPriceRange.AutoSize = true;
            this.labelSetPriceRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetPriceRange.Location = new System.Drawing.Point(68, 21);
            this.labelSetPriceRange.Name = "labelSetPriceRange";
            this.labelSetPriceRange.Size = new System.Drawing.Size(159, 25);
            this.labelSetPriceRange.TabIndex = 7;
            this.labelSetPriceRange.Text = "Set Price Range:";
            // 
            // labelFromPrice
            // 
            this.labelFromPrice.AutoSize = true;
            this.labelFromPrice.Location = new System.Drawing.Point(4, 62);
            this.labelFromPrice.Name = "labelFromPrice";
            this.labelFromPrice.Size = new System.Drawing.Size(104, 17);
            this.labelFromPrice.TabIndex = 8;
            this.labelFromPrice.Text = "From Price     £";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "To  Price    £";
            // 
            // buttonFindRange
            // 
            this.buttonFindRange.Location = new System.Drawing.Point(155, 150);
            this.buttonFindRange.Name = "buttonFindRange";
            this.buttonFindRange.Size = new System.Drawing.Size(127, 25);
            this.buttonFindRange.TabIndex = 10;
            this.buttonFindRange.Text = "Find in Range";
            this.buttonFindRange.UseVisualStyleBackColor = true;
            this.buttonFindRange.Click += new System.EventHandler(this.buttonFindRange_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(50, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // panelSetPriceRange
            // 
            this.panelSetPriceRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSetPriceRange.Controls.Add(this.buttonSort);
            this.panelSetPriceRange.Controls.Add(this.buttonFindRange);
            this.panelSetPriceRange.Controls.Add(this.label2);
            this.panelSetPriceRange.Controls.Add(this.labelFromPrice);
            this.panelSetPriceRange.Controls.Add(this.labelSetPriceRange);
            this.panelSetPriceRange.Controls.Add(this.numericUpDownLowerPrice);
            this.panelSetPriceRange.Controls.Add(this.labelAscendingPriceOrder);
            this.panelSetPriceRange.Controls.Add(this.numericUpDownHigherPrice);
            this.panelSetPriceRange.Location = new System.Drawing.Point(1068, 79);
            this.panelSetPriceRange.Name = "panelSetPriceRange";
            this.panelSetPriceRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSetPriceRange.Size = new System.Drawing.Size(294, 232);
            this.panelSetPriceRange.TabIndex = 12;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(12, 150);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(127, 25);
            this.buttonSort.TabIndex = 19;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelAscendingPriceOrder
            // 
            this.labelAscendingPriceOrder.AutoSize = true;
            this.labelAscendingPriceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAscendingPriceOrder.Location = new System.Drawing.Point(28, 178);
            this.labelAscendingPriceOrder.Name = "labelAscendingPriceOrder";
            this.labelAscendingPriceOrder.Size = new System.Drawing.Size(94, 13);
            this.labelAscendingPriceOrder.TabIndex = 18;
            this.labelAscendingPriceOrder.Text = "[ Ascending Price ]";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(181, 53);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(51, 17);
            this.labelBrand.TabIndex = 13;
            this.labelBrand.Text = "Brand";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.Location = new System.Drawing.Point(339, 53);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(106, 17);
            this.labelReleaseDate.TabIndex = 14;
            this.labelReleaseDate.Text = "Release Date";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.Location = new System.Drawing.Point(539, 53);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(76, 17);
            this.labelCondition.TabIndex = 15;
            this.labelCondition.Text = "Condition";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(676, 53);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 17);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Laptop Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(116, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(218, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(213, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 25);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(16, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 25);
            this.buttonLoad.TabIndex = 23;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelLoadList
            // 
            this.labelLoadList.AutoSize = true;
            this.labelLoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadList.Location = new System.Drawing.Point(63, 38);
            this.labelLoadList.Name = "labelLoadList";
            this.labelLoadList.Size = new System.Drawing.Size(167, 13);
            this.labelLoadList.TabIndex = 24;
            this.labelLoadList.Text = "[ Load List First to Add and Save ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelLoadList);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(388, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 62);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonNextLaptop);
            this.panel2.Controls.Add(this.buttonPreviousLaptop);
            this.panel2.Location = new System.Drawing.Point(719, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 62);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "[ Navigate to Laptop Before Deleting ]";
            // 
            // buttonFindLaptop
            // 
            this.buttonFindLaptop.Location = new System.Drawing.Point(12, 16);
            this.buttonFindLaptop.Name = "buttonFindLaptop";
            this.buttonFindLaptop.Size = new System.Drawing.Size(270, 25);
            this.buttonFindLaptop.TabIndex = 27;
            this.buttonFindLaptop.Text = "Find Laptop";
            this.buttonFindLaptop.UseVisualStyleBackColor = true;
            this.buttonFindLaptop.Click += new System.EventHandler(this.buttonFindLaptop_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSearch.Controls.Add(this.buttonFindLaptop);
            this.panelSearch.Location = new System.Drawing.Point(1068, 320);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(294, 51);
            this.panelSearch.TabIndex = 28;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1471, 435);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textLaptop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelReleaseDate);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.panelSetPriceRange);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCurrentLaptop);
            this.Name = "formMain";
            this.Text = "Stock Viewer";
            this.TransparencyKey = System.Drawing.Color.MediumSpringGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHigherPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerPrice)).EndInit();
            this.panelSetPriceRange.ResumeLayout(false);
            this.panelSetPriceRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentLaptop;
        private System.Windows.Forms.Button buttonPreviousLaptop;
        private System.Windows.Forms.Button buttonNextLaptop;
        private System.Windows.Forms.TextBox textLaptop;
        private System.Windows.Forms.NumericUpDown numericUpDownHigherPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownLowerPrice;
        private System.Windows.Forms.Label labelSetPriceRange;
        private System.Windows.Forms.Label labelFromPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindRange;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelSetPriceRange;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAscendingPriceOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelLoadList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFindLaptop;
        private System.Windows.Forms.Panel panelSearch;
    }
}

