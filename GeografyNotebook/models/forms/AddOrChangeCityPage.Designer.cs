namespace GeografyNotebook.models.forms
{
    partial class AddOrChangeCityPage
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountrySelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LatitudeNumber = new System.Windows.Forms.NumericUpDown();
            this.LongtitudeNumber = new System.Windows.Forms.NumericUpDown();
            this.PopulationNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LatitudeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongtitudeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(200, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // CountrySelector
            // 
            this.CountrySelector.FormattingEnabled = true;
            this.CountrySelector.Location = new System.Drawing.Point(200, 90);
            this.CountrySelector.Name = "CountrySelector";
            this.CountrySelector.Size = new System.Drawing.Size(200, 21);
            this.CountrySelector.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Longtitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Population";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(713, 415);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 10;
            this.ChangeButton.Text = "Done";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(632, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LatitudeNumber
            // 
            this.LatitudeNumber.DecimalPlaces = 4;
            this.LatitudeNumber.Location = new System.Drawing.Point(200, 120);
            this.LatitudeNumber.Name = "LatitudeNumber";
            this.LatitudeNumber.Size = new System.Drawing.Size(200, 20);
            this.LatitudeNumber.TabIndex = 12;
            this.LatitudeNumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // LongtitudeNumber
            // 
            this.LongtitudeNumber.DecimalPlaces = 4;
            this.LongtitudeNumber.Location = new System.Drawing.Point(200, 150);
            this.LongtitudeNumber.Name = "LongtitudeNumber";
            this.LongtitudeNumber.Size = new System.Drawing.Size(200, 20);
            this.LongtitudeNumber.TabIndex = 13;
            // 
            // PopulationNumber
            // 
            this.PopulationNumber.Location = new System.Drawing.Point(200, 180);
            this.PopulationNumber.Name = "PopulationNumber";
            this.PopulationNumber.Size = new System.Drawing.Size(200, 20);
            this.PopulationNumber.TabIndex = 14;
            // 
            // AddOrChangeCityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PopulationNumber);
            this.Controls.Add(this.LongtitudeNumber);
            this.Controls.Add(this.LatitudeNumber);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountrySelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddOrChangeCityPage";
            this.Text = "AddOrChangeCityPage";
            ((System.ComponentModel.ISupportInitialize)(this.LatitudeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongtitudeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CountrySelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.NumericUpDown LatitudeNumber;
        private System.Windows.Forms.NumericUpDown LongtitudeNumber;
        private System.Windows.Forms.NumericUpDown PopulationNumber;
    }
}