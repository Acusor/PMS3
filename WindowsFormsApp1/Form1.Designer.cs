namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iesire = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.furnizori = new System.Windows.Forms.Button();
            this.angajati = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iesire);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.furnizori);
            this.panel1.Controls.Add(this.angajati);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 761);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.settings;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(30, 408);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(208, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "CONFIGURARE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(30, 470);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(208, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "INFO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(68, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // iesire
            // 
            this.iesire.BackColor = System.Drawing.Color.White;
            this.iesire.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iesire.Image = ((System.Drawing.Image)(resources.GetObject("iesire.Image")));
            this.iesire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iesire.Location = new System.Drawing.Point(30, 537);
            this.iesire.Name = "iesire";
            this.iesire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iesire.Size = new System.Drawing.Size(208, 47);
            this.iesire.TabIndex = 5;
            this.iesire.Text = "IESIRE";
            this.iesire.UseVisualStyleBackColor = false;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(30, 218);
            this.btnStock.Name = "btnStock";
            this.btnStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStock.Size = new System.Drawing.Size(208, 47);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "STOCK PRODUSE";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // furnizori
            // 
            this.furnizori.BackColor = System.Drawing.Color.White;
            this.furnizori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnizori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.furnizori.Image = ((System.Drawing.Image)(resources.GetObject("furnizori.Image")));
            this.furnizori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.furnizori.Location = new System.Drawing.Point(30, 343);
            this.furnizori.Name = "furnizori";
            this.furnizori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.furnizori.Size = new System.Drawing.Size(208, 47);
            this.furnizori.TabIndex = 4;
            this.furnizori.Text = "FURNIZORI";
            this.furnizori.UseVisualStyleBackColor = false;
            this.furnizori.Click += new System.EventHandler(this.furnizori_Click);
            // 
            // angajati
            // 
            this.angajati.BackColor = System.Drawing.Color.White;
            this.angajati.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angajati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.angajati.Image = ((System.Drawing.Image)(resources.GetObject("angajati.Image")));
            this.angajati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.angajati.Location = new System.Drawing.Point(30, 280);
            this.angajati.Name = "angajati";
            this.angajati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.angajati.Size = new System.Drawing.Size(208, 47);
            this.angajati.TabIndex = 3;
            this.angajati.Text = "ANGAJATI";
            this.angajati.UseVisualStyleBackColor = false;
            this.angajati.Click += new System.EventHandler(this.angajati_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1515, 40);
            this.panel2.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Location = new System.Drawing.Point(293, 46);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(867, 580);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(381, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENIU PMS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 638);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PMS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button angajati;
        private System.Windows.Forms.Button furnizori;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

