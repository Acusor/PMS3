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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Info_Load(null, EventArgs.Empty);
        }

        private void Info_Load(object sender, EventArgs e)
        {
            // Încarcă pagina HTML când formularul "Info" este încărcat
            paginaweb.Navigate("file:///C:/Users/wwwza/Downloads/Pagina.html");
        }
       
    }
}
