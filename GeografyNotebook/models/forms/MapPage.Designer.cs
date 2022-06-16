namespace GeografyNotebook.models.forms
{
    partial class MapPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapPage));
            this.RedDot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedDot
            // 
            this.RedDot.AutoSize = true;
            this.RedDot.BackColor = System.Drawing.Color.Transparent;
            this.RedDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedDot.ForeColor = System.Drawing.Color.Red;
            this.RedDot.Location = new System.Drawing.Point(645, 408);
            this.RedDot.Name = "RedDot";
            this.RedDot.Size = new System.Drawing.Size(58, 76);
            this.RedDot.TabIndex = 0;
            this.RedDot.Text = "*";
            // 
            // MapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 749);
            this.Controls.Add(this.RedDot);
            this.KeyPreview = true;
            this.Name = "MapPage";
            this.Text = "MapPage";
            this.Load += new System.EventHandler(this.MapPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RedDot;
    }
}