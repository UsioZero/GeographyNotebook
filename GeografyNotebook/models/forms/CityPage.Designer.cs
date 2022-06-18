namespace GeografyNotebook.models.forms
{
    partial class CityPage
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
            this.SearchParameter = new System.Windows.Forms.ComboBox();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.SortParametr = new System.Windows.Forms.ComboBox();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.CitiesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.M = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PageLabel = new System.Windows.Forms.Label();
            this.SaveResultbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchParameter
            // 
            this.SearchParameter.FormattingEnabled = true;
            this.SearchParameter.Location = new System.Drawing.Point(196, 10);
            this.SearchParameter.Name = "SearchParameter";
            this.SearchParameter.Size = new System.Drawing.Size(126, 21);
            this.SearchParameter.TabIndex = 1;
            // 
            // SearchValue
            // 
            this.SearchValue.Location = new System.Drawing.Point(346, 12);
            this.SearchValue.Name = "SearchValue";
            this.SearchValue.Size = new System.Drawing.Size(267, 20);
            this.SearchValue.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(645, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(1, 129);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(42, 253);
            this.LeftButton.TabIndex = 6;
            this.LeftButton.Text = "left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(756, 129);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(42, 253);
            this.RightButton.TabIndex = 7;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // SortParametr
            // 
            this.SortParametr.FormattingEnabled = true;
            this.SortParametr.Location = new System.Drawing.Point(346, 50);
            this.SortParametr.Name = "SortParametr";
            this.SortParametr.Size = new System.Drawing.Size(267, 21);
            this.SortParametr.TabIndex = 8;
            this.SortParametr.SelectedValueChanged += new System.EventHandler(this.SortParametr_SelectedValueChanged);
            // 
            // AddCityButton
            // 
            this.AddCityButton.Location = new System.Drawing.Point(723, 388);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(75, 23);
            this.AddCityButton.TabIndex = 10;
            this.AddCityButton.Text = "New City";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // CitiesGrid
            // 
            this.CitiesGrid.AllowUserToAddRows = false;
            this.CitiesGrid.AllowUserToDeleteRows = false;
            this.CitiesGrid.AllowUserToOrderColumns = true;
            this.CitiesGrid.AutoGenerateColumns = false;
            this.CitiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.Edit,
            this.M});
            this.CitiesGrid.DataSource = this.cityBindingSource;
            this.CitiesGrid.Location = new System.Drawing.Point(49, 129);
            this.CitiesGrid.Name = "CitiesGrid";
            this.CitiesGrid.ReadOnly = true;
            this.CitiesGrid.Size = new System.Drawing.Size(701, 253);
            this.CitiesGrid.TabIndex = 12;
            this.CitiesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CitiesGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sort";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // M
            // 
            this.M.HeaderText = "";
            this.M.Name = "M";
            this.M.ReadOnly = true;
            this.M.Text = "Map";
            this.M.UseColumnTextForButtonValue = true;
            this.M.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(GeografyNotebook.models.classes.City);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(12, 388);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(35, 13);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "label1";
            // 
            // SaveResultbutton
            // 
            this.SaveResultbutton.Location = new System.Drawing.Point(721, 97);
            this.SaveResultbutton.Name = "SaveResultbutton";
            this.SaveResultbutton.Size = new System.Drawing.Size(75, 23);
            this.SaveResultbutton.TabIndex = 14;
            this.SaveResultbutton.Text = "Save to file";
            this.SaveResultbutton.UseVisualStyleBackColor = true;
            this.SaveResultbutton.Click += new System.EventHandler(this.SaveResultbutton_Click);
            // 
            // CityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveResultbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CitiesGrid);
            this.Controls.Add(this.AddCityButton);
            this.Controls.Add(this.SortParametr);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(this.SearchParameter);
            this.Controls.Add(this.PageLabel);
            this.KeyPreview = true;
            this.Name = "CityPage";
            this.Text = "CityPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CitiesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SearchParameter;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.ComboBox SortParametr;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.DataGridView CitiesGrid;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn M;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button SaveResultbutton;
    }
}