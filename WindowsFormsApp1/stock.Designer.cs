namespace WindowsFormsApp1
{
    partial class stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock));
            this.flowLayoutPanelMedicamente = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.btnStergereMedicamente = new System.Windows.Forms.Button();
            this.btnAdaugareMedicamente = new System.Windows.Forms.Button();
            this.btnEditareMedicamente = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCautareMedicamente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataExpirare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.txtIDMedicament = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnAdaugaMedicamnete = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAnulare2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPretMax = new System.Windows.Forms.TextBox();
            this.txtPretMin = new System.Windows.Forms.TextBox();
            this.txtProducatorCautat = new System.Windows.Forms.TextBox();
            this.txtNumeCautat = new System.Windows.Forms.TextBox();
            this.CautaMedicamente = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDataExpirareActualizata = new System.Windows.Forms.TextBox();
            this.txtCantitateActualizata = new System.Windows.Forms.TextBox();
            this.txtPretActualizat = new System.Windows.Forms.TextBox();
            this.txtProducatorActualizat = new System.Windows.Forms.TextBox();
            this.txtNumeActualizat = new System.Windows.Forms.TextBox();
            this.txtIDMedicamentActualizat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ActualizeazaMedicamente = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.StergeMedicamente = new System.Windows.Forms.Button();
            this.txtIDMedicamentStergere = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMedicamente
            // 
            this.flowLayoutPanelMedicamente.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanelMedicamente.Location = new System.Drawing.Point(7, 28);
            this.flowLayoutPanelMedicamente.Name = "flowLayoutPanelMedicamente";
            this.flowLayoutPanelMedicamente.Size = new System.Drawing.Size(884, 311);
            this.flowLayoutPanelMedicamente.TabIndex = 0;
            this.flowLayoutPanelMedicamente.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMedicamente_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock medicamente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 527);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.btnStergereMedicamente);
            this.tabPage1.Controls.Add(this.btnAdaugareMedicamente);
            this.tabPage1.Controls.Add(this.btnEditareMedicamente);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.flowLayoutPanelMedicamente);
            this.tabPage1.Controls.Add(this.btnCautareMedicamente);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label30.Location = new System.Drawing.Point(6, 359);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(90, 22);
            this.label30.TabIndex = 7;
            this.label30.Text = "Optiuni:";
            // 
            // btnStergereMedicamente
            // 
            this.btnStergereMedicamente.BackColor = System.Drawing.Color.White;
            this.btnStergereMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereMedicamente.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btnStergereMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStergereMedicamente.Location = new System.Drawing.Point(443, 349);
            this.btnStergereMedicamente.Name = "btnStergereMedicamente";
            this.btnStergereMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStergereMedicamente.Size = new System.Drawing.Size(208, 47);
            this.btnStergereMedicamente.TabIndex = 6;
            this.btnStergereMedicamente.Text = "Stergere";
            this.btnStergereMedicamente.UseVisualStyleBackColor = false;
            this.btnStergereMedicamente.Click += new System.EventHandler(this.btnStergereMedicamente_Click);
            // 
            // btnAdaugareMedicamente
            // 
            this.btnAdaugareMedicamente.BackColor = System.Drawing.Color.White;
            this.btnAdaugareMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareMedicamente.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btnAdaugareMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdaugareMedicamente.Location = new System.Drawing.Point(150, 349);
            this.btnAdaugareMedicamente.Name = "btnAdaugareMedicamente";
            this.btnAdaugareMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdaugareMedicamente.Size = new System.Drawing.Size(208, 47);
            this.btnAdaugareMedicamente.TabIndex = 3;
            this.btnAdaugareMedicamente.Text = "Adaugare";
            this.btnAdaugareMedicamente.UseVisualStyleBackColor = false;
            this.btnAdaugareMedicamente.Click += new System.EventHandler(this.btnAdaugareMedicamente_Click);
            // 
            // btnEditareMedicamente
            // 
            this.btnEditareMedicamente.BackColor = System.Drawing.Color.White;
            this.btnEditareMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditareMedicamente.Image = global::WindowsFormsApp1.Properties.Resources.update_icon;
            this.btnEditareMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditareMedicamente.Location = new System.Drawing.Point(443, 420);
            this.btnEditareMedicamente.Name = "btnEditareMedicamente";
            this.btnEditareMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditareMedicamente.Size = new System.Drawing.Size(208, 47);
            this.btnEditareMedicamente.TabIndex = 4;
            this.btnEditareMedicamente.Text = "Editare";
            this.btnEditareMedicamente.UseVisualStyleBackColor = false;
            this.btnEditareMedicamente.Click += new System.EventHandler(this.btnEditareMedicamente_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(708, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 22);
            this.label13.TabIndex = 6;
            this.label13.Text = "D/E:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(576, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(425, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cantitate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(289, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pret:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(146, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Furnizor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nume:";
            // 
            // btnCautareMedicamente
            // 
            this.btnCautareMedicamente.BackColor = System.Drawing.Color.White;
            this.btnCautareMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareMedicamente.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.btnCautareMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCautareMedicamente.Location = new System.Drawing.Point(150, 420);
            this.btnCautareMedicamente.Name = "btnCautareMedicamente";
            this.btnCautareMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCautareMedicamente.Size = new System.Drawing.Size(208, 47);
            this.btnCautareMedicamente.TabIndex = 5;
            this.btnCautareMedicamente.Text = "Cautare";
            this.btnCautareMedicamente.UseVisualStyleBackColor = false;
            this.btnCautareMedicamente.Click += new System.EventHandler(this.btnCautareMedicamente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.btnAnulare);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDataExpirare);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtCantitate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtPret);
            this.tabPage2.Controls.Add(this.txtProducator);
            this.tabPage2.Controls.Add(this.txtIDMedicament);
            this.tabPage2.Controls.Add(this.txtNume);
            this.tabPage2.Controls.Add(this.btnAdaugaMedicamnete);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAnulare
            // 
            this.btnAnulare.BackColor = System.Drawing.Color.White;
            this.btnAnulare.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare.Image = ((System.Drawing.Image)(resources.GetObject("btnAnulare.Image")));
            this.btnAnulare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnulare.Location = new System.Drawing.Point(705, 437);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnulare.Size = new System.Drawing.Size(142, 37);
            this.btnAnulare.TabIndex = 22;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = false;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(26, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 37);
            this.label21.TabIndex = 21;
            this.label21.Text = "Adaugare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(460, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data expirare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(44, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(465, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pret";
            // 
            // txtDataExpirare
            // 
            this.txtDataExpirare.Location = new System.Drawing.Point(463, 337);
            this.txtDataExpirare.Multiline = true;
            this.txtDataExpirare.Name = "txtDataExpirare";
            this.txtDataExpirare.Size = new System.Drawing.Size(169, 31);
            this.txtDataExpirare.TabIndex = 16;
            this.txtDataExpirare.TextChanged += new System.EventHandler(this.txtDataExpirare_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Furnizor";
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(48, 337);
            this.txtCantitate.Multiline = true;
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(169, 31);
            this.txtCantitate.TabIndex = 14;
            this.txtCantitate.TextChanged += new System.EventHandler(this.txtCantitate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(460, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nume";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(464, 214);
            this.txtPret.Multiline = true;
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(169, 31);
            this.txtPret.TabIndex = 11;
            this.txtPret.TextChanged += new System.EventHandler(this.txtPret_TextChanged);
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(48, 214);
            this.txtProducator.Multiline = true;
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(169, 31);
            this.txtProducator.TabIndex = 10;
            this.txtProducator.TextChanged += new System.EventHandler(this.txtProducator_TextChanged);
            // 
            // txtIDMedicament
            // 
            this.txtIDMedicament.Location = new System.Drawing.Point(463, 106);
            this.txtIDMedicament.Multiline = true;
            this.txtIDMedicament.Name = "txtIDMedicament";
            this.txtIDMedicament.Size = new System.Drawing.Size(169, 31);
            this.txtIDMedicament.TabIndex = 9;
            this.txtIDMedicament.TextChanged += new System.EventHandler(this.txtIDMedicament_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(48, 106);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(169, 31);
            this.txtNume.TabIndex = 8;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // btnAdaugaMedicamnete
            // 
            this.btnAdaugaMedicamnete.BackColor = System.Drawing.Color.White;
            this.btnAdaugaMedicamnete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaMedicamnete.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btnAdaugaMedicamnete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdaugaMedicamnete.Location = new System.Drawing.Point(705, 383);
            this.btnAdaugaMedicamnete.Name = "btnAdaugaMedicamnete";
            this.btnAdaugaMedicamnete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdaugaMedicamnete.Size = new System.Drawing.Size(142, 37);
            this.btnAdaugaMedicamnete.TabIndex = 20;
            this.btnAdaugaMedicamnete.Text = "Adauga";
            this.btnAdaugaMedicamnete.UseVisualStyleBackColor = false;
            this.btnAdaugaMedicamnete.Click += new System.EventHandler(this.btnAdaugaMedicamnete_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAnulare2);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtPretMax);
            this.tabPage3.Controls.Add(this.txtPretMin);
            this.tabPage3.Controls.Add(this.txtProducatorCautat);
            this.tabPage3.Controls.Add(this.txtNumeCautat);
            this.tabPage3.Controls.Add(this.CautaMedicamente);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(926, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAnulare2
            // 
            this.btnAnulare2.BackColor = System.Drawing.Color.White;
            this.btnAnulare2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare2.Image = ((System.Drawing.Image)(resources.GetObject("btnAnulare2.Image")));
            this.btnAnulare2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnulare2.Location = new System.Drawing.Point(690, 435);
            this.btnAnulare2.Name = "btnAnulare2";
            this.btnAnulare2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnulare2.Size = new System.Drawing.Size(142, 37);
            this.btnAnulare2.TabIndex = 23;
            this.btnAnulare2.Text = "Anulare";
            this.btnAnulare2.UseVisualStyleBackColor = false;
            this.btnAnulare2.Click += new System.EventHandler(this.btnAnulare2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(24, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 37);
            this.label20.TabIndex = 18;
            this.label20.Text = "Cautare";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(414, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 22);
            this.label17.TabIndex = 17;
            this.label17.Text = "Pret max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(26, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 22);
            this.label16.TabIndex = 16;
            this.label16.Text = "Pret min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(414, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 22);
            this.label15.TabIndex = 15;
            this.label15.Text = "Producator";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(26, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nume";
            // 
            // txtPretMax
            // 
            this.txtPretMax.Location = new System.Drawing.Point(418, 279);
            this.txtPretMax.Multiline = true;
            this.txtPretMax.Name = "txtPretMax";
            this.txtPretMax.Size = new System.Drawing.Size(241, 31);
            this.txtPretMax.TabIndex = 12;
            this.txtPretMax.TextChanged += new System.EventHandler(this.txtPretMax_TextChanged);
            // 
            // txtPretMin
            // 
            this.txtPretMin.Location = new System.Drawing.Point(30, 279);
            this.txtPretMin.Multiline = true;
            this.txtPretMin.Name = "txtPretMin";
            this.txtPretMin.Size = new System.Drawing.Size(241, 31);
            this.txtPretMin.TabIndex = 11;
            this.txtPretMin.TextChanged += new System.EventHandler(this.txtPretMin_TextChanged);
            // 
            // txtProducatorCautat
            // 
            this.txtProducatorCautat.Location = new System.Drawing.Point(418, 146);
            this.txtProducatorCautat.Multiline = true;
            this.txtProducatorCautat.Name = "txtProducatorCautat";
            this.txtProducatorCautat.Size = new System.Drawing.Size(241, 31);
            this.txtProducatorCautat.TabIndex = 10;
            this.txtProducatorCautat.TextChanged += new System.EventHandler(this.txtProducatorCautat_TextChanged);
            // 
            // txtNumeCautat
            // 
            this.txtNumeCautat.Location = new System.Drawing.Point(30, 146);
            this.txtNumeCautat.Multiline = true;
            this.txtNumeCautat.Name = "txtNumeCautat";
            this.txtNumeCautat.Size = new System.Drawing.Size(241, 31);
            this.txtNumeCautat.TabIndex = 9;
            this.txtNumeCautat.TextChanged += new System.EventHandler(this.txtNumeCautat_TextChanged);
            // 
            // CautaMedicamente
            // 
            this.CautaMedicamente.BackColor = System.Drawing.Color.White;
            this.CautaMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautaMedicamente.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.CautaMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CautaMedicamente.Location = new System.Drawing.Point(690, 377);
            this.CautaMedicamente.Name = "CautaMedicamente";
            this.CautaMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CautaMedicamente.Size = new System.Drawing.Size(142, 37);
            this.CautaMedicamente.TabIndex = 13;
            this.CautaMedicamente.Text = "Cauta";
            this.CautaMedicamente.UseVisualStyleBackColor = false;
            this.CautaMedicamente.Click += new System.EventHandler(this.CautaMedicamente_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.txtDataExpirareActualizata);
            this.tabPage4.Controls.Add(this.txtCantitateActualizata);
            this.tabPage4.Controls.Add(this.txtPretActualizat);
            this.tabPage4.Controls.Add(this.txtProducatorActualizat);
            this.tabPage4.Controls.Add(this.txtNumeActualizat);
            this.tabPage4.Controls.Add(this.txtIDMedicamentActualizat);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.ActualizeazaMedicamente);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(926, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(692, 402);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Anulare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label29.Location = new System.Drawing.Point(23, 195);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(276, 27);
            this.label29.TabIndex = 23;
            this.label29.Text = "Introduceti noile date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.Location = new System.Drawing.Point(307, 344);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(140, 22);
            this.label28.TabIndex = 22;
            this.label28.Text = "Data expirare";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(24, 344);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 22);
            this.label27.TabIndex = 21;
            this.label27.Text = "Cantitate";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(589, 237);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 27);
            this.label26.TabIndex = 20;
            this.label26.Text = "Pret";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(307, 237);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 27);
            this.label25.TabIndex = 19;
            this.label25.Text = "Producator";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(25, 237);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 27);
            this.label24.TabIndex = 18;
            this.label24.Text = "Nume";
            // 
            // txtDataExpirareActualizata
            // 
            this.txtDataExpirareActualizata.Location = new System.Drawing.Point(311, 386);
            this.txtDataExpirareActualizata.Multiline = true;
            this.txtDataExpirareActualizata.Name = "txtDataExpirareActualizata";
            this.txtDataExpirareActualizata.Size = new System.Drawing.Size(241, 31);
            this.txtDataExpirareActualizata.TabIndex = 15;
            // 
            // txtCantitateActualizata
            // 
            this.txtCantitateActualizata.Location = new System.Drawing.Point(28, 386);
            this.txtCantitateActualizata.Multiline = true;
            this.txtCantitateActualizata.Name = "txtCantitateActualizata";
            this.txtCantitateActualizata.Size = new System.Drawing.Size(241, 31);
            this.txtCantitateActualizata.TabIndex = 14;
            // 
            // txtPretActualizat
            // 
            this.txtPretActualizat.Location = new System.Drawing.Point(593, 274);
            this.txtPretActualizat.Multiline = true;
            this.txtPretActualizat.Name = "txtPretActualizat";
            this.txtPretActualizat.Size = new System.Drawing.Size(241, 31);
            this.txtPretActualizat.TabIndex = 13;
            // 
            // txtProducatorActualizat
            // 
            this.txtProducatorActualizat.Location = new System.Drawing.Point(311, 274);
            this.txtProducatorActualizat.Multiline = true;
            this.txtProducatorActualizat.Name = "txtProducatorActualizat";
            this.txtProducatorActualizat.Size = new System.Drawing.Size(241, 31);
            this.txtProducatorActualizat.TabIndex = 12;
            // 
            // txtNumeActualizat
            // 
            this.txtNumeActualizat.Location = new System.Drawing.Point(29, 274);
            this.txtNumeActualizat.Multiline = true;
            this.txtNumeActualizat.Name = "txtNumeActualizat";
            this.txtNumeActualizat.Size = new System.Drawing.Size(241, 31);
            this.txtNumeActualizat.TabIndex = 11;
            // 
            // txtIDMedicamentActualizat
            // 
            this.txtIDMedicamentActualizat.Location = new System.Drawing.Point(29, 141);
            this.txtIDMedicamentActualizat.Multiline = true;
            this.txtIDMedicamentActualizat.Name = "txtIDMedicamentActualizat";
            this.txtIDMedicamentActualizat.Size = new System.Drawing.Size(241, 31);
            this.txtIDMedicamentActualizat.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(24, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 27);
            this.label19.TabIndex = 1;
            this.label19.Text = "Introduceti ID-ul";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(23, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 37);
            this.label18.TabIndex = 0;
            this.label18.Text = "Editare";
            // 
            // ActualizeazaMedicamente
            // 
            this.ActualizeazaMedicamente.BackColor = System.Drawing.Color.White;
            this.ActualizeazaMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizeazaMedicamente.Image = global::WindowsFormsApp1.Properties.Resources.update_icon;
            this.ActualizeazaMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActualizeazaMedicamente.Location = new System.Drawing.Point(692, 344);
            this.ActualizeazaMedicamente.Name = "ActualizeazaMedicamente";
            this.ActualizeazaMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActualizeazaMedicamente.Size = new System.Drawing.Size(142, 37);
            this.ActualizeazaMedicamente.TabIndex = 17;
            this.ActualizeazaMedicamente.Text = "Actualizeaza";
            this.ActualizeazaMedicamente.UseVisualStyleBackColor = false;
            this.ActualizeazaMedicamente.Click += new System.EventHandler(this.ActualizeazaMedicamente_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.StergeMedicamente);
            this.tabPage5.Controls.Add(this.txtIDMedicamentStergere);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(926, 498);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(385, 309);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 25;
            this.button3.Text = "Anulare";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StergeMedicamente
            // 
            this.StergeMedicamente.BackColor = System.Drawing.Color.White;
            this.StergeMedicamente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StergeMedicamente.Image = ((System.Drawing.Image)(resources.GetObject("StergeMedicamente.Image")));
            this.StergeMedicamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StergeMedicamente.Location = new System.Drawing.Point(385, 242);
            this.StergeMedicamente.Name = "StergeMedicamente";
            this.StergeMedicamente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StergeMedicamente.Size = new System.Drawing.Size(142, 37);
            this.StergeMedicamente.TabIndex = 18;
            this.StergeMedicamente.Text = "Sterge";
            this.StergeMedicamente.UseVisualStyleBackColor = false;
            this.StergeMedicamente.Click += new System.EventHandler(this.StergeMedicamente_Click);
            // 
            // txtIDMedicamentStergere
            // 
            this.txtIDMedicamentStergere.Location = new System.Drawing.Point(337, 159);
            this.txtIDMedicamentStergere.Multiline = true;
            this.txtIDMedicamentStergere.Name = "txtIDMedicamentStergere";
            this.txtIDMedicamentStergere.Size = new System.Drawing.Size(241, 31);
            this.txtIDMedicamentStergere.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(347, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 27);
            this.label23.TabIndex = 2;
            this.label23.Text = "Introduceti ID-ul";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Yu Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(21, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 36);
            this.label22.TabIndex = 1;
            this.label22.Text = "Stergere";
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock";
            this.Text = "stock";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMedicamente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdaugareMedicamente;
        private System.Windows.Forms.Button btnEditareMedicamente;
        private System.Windows.Forms.Button btnCautareMedicamente;
        private System.Windows.Forms.Button btnStergereMedicamente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.TextBox txtIDMedicament;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataExpirare;
        private System.Windows.Forms.Button btnAdaugaMedicamnete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNumeCautat;
        private System.Windows.Forms.TextBox txtPretMax;
        private System.Windows.Forms.TextBox txtPretMin;
        private System.Windows.Forms.TextBox txtProducatorCautat;
        private System.Windows.Forms.Button CautaMedicamente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIDMedicamentActualizat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDataExpirareActualizata;
        private System.Windows.Forms.TextBox txtCantitateActualizata;
        private System.Windows.Forms.TextBox txtPretActualizat;
        private System.Windows.Forms.TextBox txtProducatorActualizat;
        private System.Windows.Forms.TextBox txtNumeActualizat;
        private System.Windows.Forms.Button ActualizeazaMedicamente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtIDMedicamentStergere;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button StergeMedicamente;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Button btnAnulare2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}