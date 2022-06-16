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
            this.CountryList = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.SortList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(748, 170);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(40, 109);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(717, 28);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // SortList
            // 
            this.SortList.FormattingEnabled = true;
            this.SortList.Location = new System.Drawing.Point(531, 28);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(165, 21);
            this.SortList.TabIndex = 4;
            // 
            // CountryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortList);
            this.Controls.Add(this.sortButton);
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
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox SortList;
    }
}