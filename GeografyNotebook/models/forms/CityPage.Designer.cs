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
            this.CityList = new System.Windows.Forms.Label();
            this.SearchParameter = new System.Windows.Forms.ComboBox();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MapButton = new System.Windows.Forms.Button();
            this.CityOnMapSelector = new System.Windows.Forms.ComboBox();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.SortParametr = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.EditCityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityList
            // 
            this.CityList.AutoSize = true;
            this.CityList.Location = new System.Drawing.Point(49, 129);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(35, 13);
            this.CityList.TabIndex = 0;
            this.CityList.Text = "label1";
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
            // MapButton
            // 
            this.MapButton.Location = new System.Drawing.Point(645, 85);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(75, 23);
            this.MapButton.TabIndex = 4;
            this.MapButton.Text = "See on map";
            this.MapButton.UseVisualStyleBackColor = true;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // CityOnMapSelector
            // 
            this.CityOnMapSelector.FormattingEnabled = true;
            this.CityOnMapSelector.Location = new System.Drawing.Point(346, 85);
            this.CityOnMapSelector.Name = "CityOnMapSelector";
            this.CityOnMapSelector.Size = new System.Drawing.Size(267, 21);
            this.CityOnMapSelector.TabIndex = 5;
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(1, 129);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(42, 122);
            this.LeftButton.TabIndex = 6;
            this.LeftButton.Text = "left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(756, 129);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(42, 122);
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
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(645, 48);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 9;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // AddCityButton
            // 
            this.AddCityButton.Location = new System.Drawing.Point(687, 275);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(75, 23);
            this.AddCityButton.TabIndex = 10;
            this.AddCityButton.Text = "New City";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // EditCityButton
            // 
            this.EditCityButton.Location = new System.Drawing.Point(247, 83);
            this.EditCityButton.Name = "EditCityButton";
            this.EditCityButton.Size = new System.Drawing.Size(75, 23);
            this.EditCityButton.TabIndex = 11;
            this.EditCityButton.Text = "Edit City";
            this.EditCityButton.UseVisualStyleBackColor = true;
            this.EditCityButton.Click += new System.EventHandler(this.EditCityButton_Click);
            // 
            // CityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditCityButton);
            this.Controls.Add(this.AddCityButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortParametr);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.CityOnMapSelector);
            this.Controls.Add(this.MapButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(this.SearchParameter);
            this.Controls.Add(this.CityList);
            this.KeyPreview = true;
            this.Name = "CityPage";
            this.Text = "CityPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityList;
        private System.Windows.Forms.ComboBox SearchParameter;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MapButton;
        private System.Windows.Forms.ComboBox CityOnMapSelector;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.ComboBox SortParametr;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.Button EditCityButton;
    }
}