namespace GeografyNotebook.models.forms
{
    partial class ContinentPage
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
            this.ContinentList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContinentList
            // 
            this.ContinentList.AutoSize = true;
            this.ContinentList.Location = new System.Drawing.Point(13, 202);
            this.ContinentList.Name = "ContinentList";
            this.ContinentList.Size = new System.Drawing.Size(35, 13);
            this.ContinentList.TabIndex = 0;
            this.ContinentList.Text = "label1";
            // 
            // ContinentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinentList);
            this.KeyPreview = true;
            this.Name = "ContinentPage";
            this.Text = "ContinentPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContinentPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContinentList;
    }
}