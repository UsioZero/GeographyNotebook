namespace GeografyNotebook.models.forms
{
    partial class AddOrChangeCountryPage
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
            this.AreaNumber = new System.Windows.Forms.NumericUpDown();
            this.PopulationNumber = new System.Windows.Forms.NumericUpDown();
            this.GovernmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.CapitalSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(200, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Name1";
            // 
            // AreaNumber
            // 
            this.AreaNumber.Location = new System.Drawing.Point(200, 150);
            this.AreaNumber.Name = "AreaNumber";
            this.AreaNumber.Size = new System.Drawing.Size(200, 20);
            this.AreaNumber.TabIndex = 1;
            this.AreaNumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // PopulationNumber
            // 
            this.PopulationNumber.Location = new System.Drawing.Point(200, 180);
            this.PopulationNumber.Name = "PopulationNumber";
            this.PopulationNumber.Size = new System.Drawing.Size(200, 20);
            this.PopulationNumber.TabIndex = 2;
            this.PopulationNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // GovernmentTypeTextBox
            // 
            this.GovernmentTypeTextBox.Location = new System.Drawing.Point(200, 120);
            this.GovernmentTypeTextBox.Name = "GovernmentTypeTextBox";
            this.GovernmentTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.GovernmentTypeTextBox.TabIndex = 3;
            this.GovernmentTypeTextBox.Text = "Monarchy";
            // 
            // CapitalSelector
            // 
            this.CapitalSelector.FormattingEnabled = true;
            this.CapitalSelector.Location = new System.Drawing.Point(200, 90);
            this.CapitalSelector.Name = "CapitalSelector";
            this.CapitalSelector.Size = new System.Drawing.Size(200, 21);
            this.CapitalSelector.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Capital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Government";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
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
            // AddOrChangeCountryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CapitalSelector);
            this.Controls.Add(this.GovernmentTypeTextBox);
            this.Controls.Add(this.PopulationNumber);
            this.Controls.Add(this.AreaNumber);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddOrChangeCountryPage";
            this.Text = "AddOrChangeCountryPage";
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown AreaNumber;
        private System.Windows.Forms.NumericUpDown PopulationNumber;
        private System.Windows.Forms.TextBox GovernmentTypeTextBox;
        private System.Windows.Forms.ComboBox CapitalSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button BackButton;
    }
}