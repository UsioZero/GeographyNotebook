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
            System.Windows.Forms.Button SearchButton;
            this.CountryList = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.SearchParametr = new System.Windows.Forms.ComboBox();
            this.SortTypeSelector = new System.Windows.Forms.ComboBox();
            SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new System.Drawing.Point(652, 32);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(75, 23);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CountryList
            // 
            this.CountryList.AutoSize = true;
            this.CountryList.Location = new System.Drawing.Point(58, 170);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(35, 13);
            this.CountryList.TabIndex = 0;
            this.CountryList.Text = "label1";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(12, 170);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(40, 109);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(748, 170);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(40, 109);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sort";
            // 
            // SearchValue
            // 
            this.SearchValue.Location = new System.Drawing.Point(353, 34);
            this.SearchValue.Name = "SearchValue";
            this.SearchValue.Size = new System.Drawing.Size(267, 20);
            this.SearchValue.TabIndex = 11;
            // 
            // SearchParametr
            // 
            this.SearchParametr.FormattingEnabled = true;
            this.SearchParametr.Location = new System.Drawing.Point(203, 32);
            this.SearchParametr.Name = "SearchParametr";
            this.SearchParametr.Size = new System.Drawing.Size(126, 21);
            this.SearchParametr.TabIndex = 10;
            // 
            // SortTypeSelector
            // 
            this.SortTypeSelector.FormattingEnabled = true;
            this.SortTypeSelector.Location = new System.Drawing.Point(353, 100);
            this.SortTypeSelector.Name = "SortTypeSelector";
            this.SortTypeSelector.Size = new System.Drawing.Size(267, 21);
            this.SortTypeSelector.TabIndex = 8;
            this.SortTypeSelector.SelectedValueChanged += new System.EventHandler(this.SortTypeSelector_SelectedValueChanged);
            // 
            // CountryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(this.SearchParametr);
            this.Controls.Add(SearchButton);
            this.Controls.Add(this.SortTypeSelector);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.CountryList);
            this.KeyPreview = true;
            this.Name = "CountryPage";
            this.Text = "CountryPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountryPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountryList;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.ComboBox SearchParametr;
        private System.Windows.Forms.ComboBox SortTypeSelector;
    }
}