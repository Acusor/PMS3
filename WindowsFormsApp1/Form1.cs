using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDarkMode = false;
        public Form1()
        {
            InitializeComponent();
           
        }
        
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetButtonColors()
        {
            btnStock.BackColor = Color.White;
            angajati.BackColor = Color.White;
            furnizori.BackColor = Color.White;
            Info.BackColor = Color.White;

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            loadform(new stock());
            btnStock.BackColor = Color.Cornsilk;
        
        }

        private void angajati_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            loadform(new angajati());
            angajati.BackColor = Color.Cornsilk;
        }

        private void furnizori_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            loadform(new furnizori());
            furnizori.BackColor = Color.Cornsilk;
        }



        private void iesire_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            iesire.BackColor = Color.Cornsilk;
            var result = MessageBox.Show("Sigur vrei sa iesi? :(", "Iesire PMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                iesire.BackColor = Color.White;
                return;
            }
            Application.Exit();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            loadform(new Info());
            Info.BackColor = Color.Cornsilk;
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
