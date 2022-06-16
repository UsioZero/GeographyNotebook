namespace GeografyNotebook.models.forms
{
    partial class CitySelectorPage
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
            this.mapButton = new System.Windows.Forms.Button();
            this.CityList = new System.Windows.Forms.ComboBox();
            this.textInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapButton
            // 
            this.mapButton.Location = new System.Drawing.Point(681, 13);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(75, 23);
            this.mapButton.TabIndex = 1;
            this.mapButton.Text = "Open map";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // CityList
            // 
            this.CityList.FormattingEnabled = true;
            this.CityList.Location = new System.Drawing.Point(289, 14);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(375, 21);
            this.CityList.TabIndex = 2;
            // 
            // textInfo
            // 
            this.textInfo.AutoSize = true;
            this.textInfo.Location = new System.Drawing.Point(24, 22);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(56, 13);
            this.textInfo.TabIndex = 3;
            this.textInfo.Text = "Chose city";
            // 
            // CitySelectorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.CityList);
            this.Controls.Add(this.mapButton);
            this.Name = "CitySelectorPage";
            this.Text = "CitySelectorPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.ComboBox CityList;
        private System.Windows.Forms.Label textInfo;
    }
}