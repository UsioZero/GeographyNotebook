namespace GeografyNotebook.models.forms
{
    partial class MainPage
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
            this.CityButton = new System.Windows.Forms.Button();
            this.RegionButton = new System.Windows.Forms.Button();
            this.CountryButton = new System.Windows.Forms.Button();
            this.ContinentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityButton
            // 
            this.CityButton.Location = new System.Drawing.Point(96, 139);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(75, 23);
            this.CityButton.TabIndex = 0;
            this.CityButton.Text = "Cities list";
            this.CityButton.UseVisualStyleBackColor = true;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            // 
            // RegionButton
            // 
            this.RegionButton.Location = new System.Drawing.Point(242, 139);
            this.RegionButton.Name = "RegionButton";
            this.RegionButton.Size = new System.Drawing.Size(125, 23);
            this.RegionButton.TabIndex = 1;
            this.RegionButton.Text = "Regions list";
            this.RegionButton.UseVisualStyleBackColor = true;
            this.RegionButton.Click += new System.EventHandler(this.RegionButton_Click);
            // 
            // CountryButton
            // 
            this.CountryButton.Location = new System.Drawing.Point(403, 139);
            this.CountryButton.Name = "CountryButton";
            this.CountryButton.Size = new System.Drawing.Size(123, 23);
            this.CountryButton.TabIndex = 2;
            this.CountryButton.Text = "Countries list";
            this.CountryButton.UseVisualStyleBackColor = true;
            this.CountryButton.Click += new System.EventHandler(this.CountryButton_Click);
            // 
            // ContinentButton
            // 
            this.ContinentButton.Location = new System.Drawing.Point(582, 139);
            this.ContinentButton.Name = "ContinentButton";
            this.ContinentButton.Size = new System.Drawing.Size(146, 23);
            this.ContinentButton.TabIndex = 3;
            this.ContinentButton.Text = "Continents list";
            this.ContinentButton.UseVisualStyleBackColor = true;
            this.ContinentButton.Click += new System.EventHandler(this.ContinentButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinentButton);
            this.Controls.Add(this.CountryButton);
            this.Controls.Add(this.RegionButton);
            this.Controls.Add(this.CityButton);
            this.KeyPreview = true;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainPage_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CityButton;
        private System.Windows.Forms.Button RegionButton;
        private System.Windows.Forms.Button CountryButton;
        private System.Windows.Forms.Button ContinentButton;
    }
}