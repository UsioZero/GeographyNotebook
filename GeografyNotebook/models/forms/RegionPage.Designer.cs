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
            this.RegionList = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.SortTypeSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RegionList
            // 
            this.RegionList.AutoSize = true;
            this.RegionList.Location = new System.Drawing.Point(64, 167);
            this.RegionList.Name = "RegionList";
            this.RegionList.Size = new System.Drawing.Size(35, 13);
            this.RegionList.TabIndex = 0;
            this.RegionList.Text = "label1";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(12, 167);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(46, 131);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(742, 167);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(46, 131);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // SortTypeSelector
            // 
            this.SortTypeSelector.FormattingEnabled = true;
            this.SortTypeSelector.Location = new System.Drawing.Point(457, 68);
            this.SortTypeSelector.Name = "SortTypeSelector";
            this.SortTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.SortTypeSelector.TabIndex = 3;
            this.SortTypeSelector.SelectedValueChanged += new System.EventHandler(this.SortTypeSelector_SelectedValueChanged);
            // 
            // RegionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortTypeSelector);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.RegionList);
            this.KeyPreview = true;
            this.Name = "RegionPage";
            this.Text = "RegionPage";
            this.Load += new System.EventHandler(this.RegionPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegionList;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.ComboBox SortTypeSelector;
    }
}