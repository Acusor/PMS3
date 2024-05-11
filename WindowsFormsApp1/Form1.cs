using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void btnStock_Click(object sender, EventArgs e)
        {
            loadform(new stock());
        }

        private void angajati_Click(object sender, EventArgs e)
        {
            loadform(new angajati());
        }

        private void furnizori_Click(object sender, EventArgs e)
        {
            loadform(new furnizori());
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
