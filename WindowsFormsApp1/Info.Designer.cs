namespace WindowsFormsApp1
{
    partial class Info
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
            this.paginaweb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // paginaweb
            // 
            this.paginaweb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginaweb.Location = new System.Drawing.Point(0, 0);
            this.paginaweb.MinimumSize = new System.Drawing.Size(20, 20);
            this.paginaweb.Name = "paginaweb";
            this.paginaweb.ScrollBarsEnabled = false;
            this.paginaweb.Size = new System.Drawing.Size(1223, 606);
            this.paginaweb.TabIndex = 0;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 606);
            this.Controls.Add(this.paginaweb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser paginaweb;
    }
}