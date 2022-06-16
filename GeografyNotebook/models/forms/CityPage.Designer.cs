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
            this.NamesSelection = new System.Windows.Forms.ComboBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.SortList = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
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
            this.SearchParameter.Size = new System.Drawing.Size(121, 21);
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
            // NamesSelection
            // 
            this.NamesSelection.FormattingEnabled = true;
            this.NamesSelection.Location = new System.Drawing.Point(346, 85);
            this.NamesSelection.Name = "NamesSelection";
            this.NamesSelection.Size = new System.Drawing.Size(267, 21);
            this.NamesSelection.TabIndex = 5;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(1, 129);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(42, 122);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(756, 129);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(42, 122);
            this.rightButton.TabIndex = 7;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // SortList
            // 
            this.SortList.FormattingEnabled = true;
            this.SortList.Location = new System.Drawing.Point(346, 50);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(267, 21);
            this.SortList.TabIndex = 8;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(645, 48);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 9;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // CityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.SortList);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.NamesSelection);
            this.Controls.Add(this.MapButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(this.SearchParameter);
            this.Controls.Add(this.CityList);
            this.KeyPreview = true;
            this.Name = "CityPage";
            this.Text = "CityPage";
            this.Load += new System.EventHandler(this.CityPage_Load);
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
        private System.Windows.Forms.ComboBox NamesSelection;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.ComboBox SortList;
        private System.Windows.Forms.Button sortButton;
    }
}