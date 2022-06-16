namespace GeografyNotebook.models.forms
{
    partial class SearchPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.saveSearchresultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // saveSearchresultsButton
            // 
            this.saveSearchresultsButton.Location = new System.Drawing.Point(713, 12);
            this.saveSearchresultsButton.Name = "saveSearchresultsButton";
            this.saveSearchresultsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSearchresultsButton.TabIndex = 1;
            this.saveSearchresultsButton.Text = "Save";
            this.saveSearchresultsButton.UseVisualStyleBackColor = true;
            this.saveSearchresultsButton.Click += new System.EventHandler(this.saveSearchresultsButton_Click);
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveSearchresultsButton);
            this.Controls.Add(this.label1);
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveSearchresultsButton;
    }
}