namespace GeografyNotebook.models.forms
{
    partial class RegionPage
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
            System.Windows.Forms.Button SearchButton;
            this.PageLabel = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.SortTypeSelector = new System.Windows.Forms.ComboBox();
            this.SearchParam = new System.Windows.Forms.ComboBox();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryGrid = new System.Windows.Forms.DataGridView();
            this.SaveResultButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new System.Drawing.Point(645, 10);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(75, 23);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(24, 369);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(35, 13);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "label1";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(13, 109);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(46, 257);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(743, 109);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(46, 257);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // SortTypeSelector
            // 
            this.SortTypeSelector.FormattingEnabled = true;
            this.SortTypeSelector.Location = new System.Drawing.Point(346, 49);
            this.SortTypeSelector.Name = "SortTypeSelector";
            this.SortTypeSelector.Size = new System.Drawing.Size(267, 21);
            this.SortTypeSelector.TabIndex = 3;
            this.SortTypeSelector.SelectedValueChanged += new System.EventHandler(this.SortTypeSelector_SelectedValueChanged);
            // 
            // SearchParam
            // 
            this.SearchParam.FormattingEnabled = true;
            this.SearchParam.Location = new System.Drawing.Point(196, 10);
            this.SearchParam.Name = "SearchParam";
            this.SearchParam.Size = new System.Drawing.Size(126, 21);
            this.SearchParam.TabIndex = 5;
            // 
            // SearchValue
            // 
            this.SearchValue.Location = new System.Drawing.Point(346, 12);
            this.SearchValue.Name = "SearchValue";
            this.SearchValue.Size = new System.Drawing.Size(267, 20);
            this.SearchValue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort";
            // 
            // CountryGrid
            // 
            this.CountryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryGrid.Location = new System.Drawing.Point(65, 109);
            this.CountryGrid.Name = "CountryGrid";
            this.CountryGrid.Size = new System.Drawing.Size(672, 257);
            this.CountryGrid.TabIndex = 8;
            this.CountryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CountryGrid_CellClick);
            // 
            // SaveResultButton
            // 
            this.SaveResultButton.Location = new System.Drawing.Point(701, 80);
            this.SaveResultButton.Name = "SaveResultButton";
            this.SaveResultButton.Size = new System.Drawing.Size(75, 23);
            this.SaveResultButton.TabIndex = 9;
            this.SaveResultButton.Text = "Save";
            this.SaveResultButton.UseVisualStyleBackColor = true;
            this.SaveResultButton.Click += new System.EventHandler(this.SaveResultButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(679, 372);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 23);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "New Region";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RegionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveResultButton);
            this.Controls.Add(this.CountryGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(this.SearchParam);
            this.Controls.Add(SearchButton);
            this.Controls.Add(this.SortTypeSelector);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.PageLabel);
            this.KeyPreview = true;
            this.Name = "RegionPage";
            this.Text = "RegionPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CountryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.ComboBox SortTypeSelector;
        private System.Windows.Forms.ComboBox SearchParam;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CountryGrid;
        private System.Windows.Forms.Button SaveResultButton;
        private System.Windows.Forms.Button AddButton;
    }
}