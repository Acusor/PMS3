using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.furnizori;

namespace WindowsFormsApp1
{
    public partial class furnizori : Form
    {
        private List<Furnizori> listaFurnizori;
        public class Furnizori
        {
            public string Nume { get; set; }
            public string Contact { get; set; }
            public string Produse { get; set; }
            
        }
        public furnizori()
        {
            InitializeComponent();
            listaFurnizori = new List<Furnizori>();
            AfiseazaFurnizori();

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
            }




        }



        public void AfiseazaFurnizori()
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Furnizori.Txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Fisierul nu exista,asa ca a fost facut unul nou");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    try
                    {
                        Furnizori furnizor = new Furnizori()
                        {
                            Nume = parts[0],
                            Contact = parts[1],
                            Produse = parts[2]
                        };
                        listaFurnizori.Add(furnizor);
                        AdaugaFurnizorLaFormular(furnizor);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre liniile furnizorilor.");
                        return;
                    }

                }
            }
        }
        private void AdaugaFurnizorLaFormular(Furnizori furnizor)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{furnizor.Nume}"
            };

            TextBox textBoxContact = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{furnizor.Contact}"
            };
            TextBox textBoxProduse = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{furnizor.Produse}"
            };

            flowLayoutPanelFurnizori.Controls.Add(textBoxNume);
            flowLayoutPanelFurnizori.Controls.Add(textBoxContact);
            flowLayoutPanelFurnizori.Controls.Add(textBoxProduse);
        }

        private void AdaugaFurnizorInFisier(Furnizori furnizor)
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Furnizori.Txt");
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{furnizor.Nume},{furnizor.Contact},{furnizor.Produse}");
            }
        }

        private void flowLayoutPanelFurnizori_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAdaugareFurnizor_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnAdaugaFurnizor_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumeFurnizor.Text) || string.IsNullOrWhiteSpace(txtContactFurnizor.Text) || string.IsNullOrWhiteSpace(txtProduseFurnizor.Text))
            {
                MessageBox.Show("Introduceți date valide pentru a completa câmpurile.");
                return;
            }

            Furnizori furnizor = new Furnizori
            {
                Nume = txtNumeFurnizor.Text,
                Contact = txtContactFurnizor.Text,
                Produse=txtProduseFurnizor.Text
            };

            AdaugaFurnizorLaFormular(furnizor);
            AdaugaFurnizorInFisier(furnizor);
            MessageBox.Show("Furnizorul a fost adăugat cu succes!");

            txtNumeFurnizor.Text = "";
            txtContactFurnizor.Text = "";
            txtProduseFurnizor.Text = "";

            tabControl1.SelectedTab = tabPage1;
        }

       
    }
}
