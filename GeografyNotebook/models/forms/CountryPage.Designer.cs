namespace GeografyNotebook.models.forms
{
    partial class CountryPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button SearchButton;
            this.PageLabel = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.SortTypeSelector = new System.Windows.Forms.ComboBox();
            this.CountryGrid = new System.Windows.Forms.DataGridView();
            this.countryBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchParam = new System.Windows.Forms.ComboBox();
            SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new System.Drawing.Point(650, 13);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(75, 23);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(17, 364);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(35, 13);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "label1";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(12, 106);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(40, 242);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(731, 106);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(40, 242);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sort";
            // 
            // SearchValue
            // 
            this.SearchValue.Location = new System.Drawing.Point(351, 15);
            this.SearchValue.Name = "SearchValue";
            this.SearchValue.Size = new System.Drawing.Size(267, 20);
            this.SearchValue.TabIndex = 11;
            // 
            // SortTypeSelector
            // 
            this.SortTypeSelector.FormattingEnabled = true;
            this.SortTypeSelector.Location = new System.Drawing.Point(351, 53);
            this.SortTypeSelector.Name = "SortTypeSelector";
            this.SortTypeSelector.Size = new System.Drawing.Size(267, 21);
            this.SortTypeSelector.TabIndex = 8;
            this.SortTypeSelector.SelectedValueChanged += new System.EventHandler(this.SortTypeSelector_SelectedValueChanged);
            // 
            // CountryGrid
            // 
            this.CountryGrid.AllowUserToAddRows = false;
            this.CountryGrid.AllowUserToDeleteRows = false;
            this.CountryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryGrid.Location = new System.Drawing.Point(58, 106);
            this.CountryGrid.Name = "CountryGrid";
            this.CountryGrid.ReadOnly = true;
            this.CountryGrid.Size = new System.Drawing.Size(667, 242);
            this.CountryGrid.TabIndex = 13;
            this.CountryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CountryGrid_CellClick);
            // 
            // countryBindingSource7
            // 
            this.countryBindingSource7.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource5
            // 
            this.countryBindingSource5.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource2
            // 
            this.countryBindingSource2.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource3
            // 
            this.countryBindingSource3.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource4
            // 
            this.countryBindingSource4.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // countryBindingSource6
            // 
            this.countryBindingSource6.DataSource = typeof(GeografyNotebook.models.classes.Country);
            // 
            // SearchParam
            // 
            this.SearchParam.FormattingEnabled = true;
            this.SearchParam.Location = new System.Drawing.Point(173, 15);
            this.SearchParam.Name = "SearchParam";
            this.SearchParam.Size = new System.Drawing.Size(154, 21);
            this.SearchParam.TabIndex = 14;
            // 
            // CountryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchParam);
            this.Controls.Add(this.CountryGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(SearchButton);
            this.Controls.Add(this.SortTypeSelector);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.PageLabel);
            this.KeyPreview = true;
            this.Name = "CountryPage";
            this.Text = "CountryPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountryPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.ComboBox SortTypeSelector;
        private System.Windows.Forms.DataGridView CountryGrid;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource1;
        private System.Windows.Forms.BindingSource countryBindingSource2;
        private System.Windows.Forms.BindingSource countryBindingSource3;
        private System.Windows.Forms.BindingSource countryBindingSource4;
        private System.Windows.Forms.BindingSource countryBindingSource5;
        private System.Windows.Forms.BindingSource countryBindingSource7;
        private System.Windows.Forms.BindingSource countryBindingSource6;
        private System.Windows.Forms.ComboBox SearchParam;
    }
}