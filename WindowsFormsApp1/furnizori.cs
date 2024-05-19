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
            public string Plata { get; set; }
            public StockStatus Stock { get; set; }
        }

        public enum StockStatus
        {
            Da=1,
            Nu=2
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

            comboBoxStockStatus.Items.AddRange(new string[] { "Da", "Nu" });
            comboBoxStockStatusEditare.Items.AddRange(new string[] { "Da", "Nu" });
            cmbCriteriuCautareFurnizor.Items.AddRange(new string[] { "Nume","Contact","Produse","Plata","Stock" });


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
                if (parts.Length == 5)
                {
                    try
                    {
                        Furnizori furnizor = new Furnizori()
                        {
                            Nume = parts[0],
                            Contact = parts[1],
                            Produse = parts[2],
                            Plata = parts[3],
                            Stock = (StockStatus)Enum.Parse(typeof(StockStatus), parts[4])
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

            TextBox textBoxPlata = new TextBox
            {
                Multiline=true,
                ReadOnly=true,
                Text=$"{furnizor.Plata}"
            };

            TextBox textBoxStock = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{furnizor.Stock}"
            };

            flowLayoutPanelFurnizori.Controls.Add(textBoxNume);
            flowLayoutPanelFurnizori.Controls.Add(textBoxContact);
            flowLayoutPanelFurnizori.Controls.Add(textBoxProduse);
            flowLayoutPanelFurnizori.Controls.Add(textBoxPlata);
            flowLayoutPanelFurnizori.Controls.Add(textBoxStock);
        }

        private void AdaugaFurnizorInFisier(Furnizori furnizor)
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Furnizori.Txt");
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{furnizor.Nume},{furnizor.Contact},{furnizor.Produse},{furnizor.Plata},{(int)furnizor.Stock}");
            }
        }

        private void flowLayoutPanelFurnizori_Paint(object sender, PaintEventArgs e)
        {

        }


        //working..
        private void btnAdaugareFurnizor_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnStergereFurnizor_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnCautareFurnizor_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            listBoxRezultateCautareFurnizor.Visible = false;

        }

        private void btnEditareAngajati_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void btnAnulareFurnizori_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnAnulareAngajati2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnAnulareAngajati3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnAnulareAngajati4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }


        private void btnAdaugaFurnizor_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumeFurnizor.Text) || string.IsNullOrWhiteSpace(txtContactFurnizor.Text) || string.IsNullOrWhiteSpace(txtProduseFurnizor.Text) || string.IsNullOrWhiteSpace(txtPlataFurnizor.Text) || comboBoxStockStatus.SelectedIndex==-1)
            {
                MessageBox.Show("Introduceți date valide pentru a completa câmpurile.");
                return;
            }

            StockStatus stock = comboBoxStockStatus.SelectedIndex == 0 ? StockStatus.Da : StockStatus.Nu;

            Furnizori furnizor = new Furnizori
            {
                Nume = txtNumeFurnizor.Text,
                Contact = txtContactFurnizor.Text,
                Produse=txtProduseFurnizor.Text,
                Plata = txtPlataFurnizor.Text,
                Stock = stock
            };

            AdaugaFurnizorLaFormular(furnizor);
            AdaugaFurnizorInFisier(furnizor);
            MessageBox.Show("Furnizorul a fost adăugat cu succes!");

            txtNumeFurnizor.Text = "";
            txtContactFurnizor.Text = "";
            txtProduseFurnizor.Text = "";
            txtPlataFurnizor.Text = "";
            comboBoxStockStatus.SelectedIndex = 0;

            tabControl1.SelectedTab = tabPage1;
        }

        

       
       
        private void btnStergeFurnizori_Click(object sender, EventArgs e)
        {
            string nume = txtStergeFurnizorNume.Text;

            if (string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Introduceți un nume de furnizor pentru a șterge.");
                return;
            }

            var furnizor = listaFurnizori.FirstOrDefault(f => f.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase));
            if (furnizor != null)
            {
                listaFurnizori.Remove(furnizor);
                RefreshAfisareFurnizori();
                StergeFurnizorDinFisier(furnizor);
                MessageBox.Show("Furnizorul a fost șters cu succes!");
            }
            else
            {
                MessageBox.Show("Furnizorul nu a fost găsit.");
            }

            txtStergeFurnizorNume.Text = "";
            tabControl1.SelectedTab = tabPage1;
        }
        
        private void StergeFurnizorDinFisier(Furnizori furnizor)
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Furnizori.Txt");
            var lines = File.ReadAllLines(filePath).Where(line => !line.StartsWith(furnizor.Nume + ",")).ToList();
            File.WriteAllLines(filePath, lines);
        }

        private void RefreshAfisareFurnizori()
        {
            flowLayoutPanelFurnizori.Controls.Clear();
            foreach (var furnizor in listaFurnizori)
            {
                AdaugaFurnizorLaFormular(furnizor);
            }
        }




        private void btnCautaFurnizor_Click(object sender, EventArgs e)
        {
            // Verificăm dacă s-a selectat un criteriu de căutare și s-a introdus o valoare pentru căutare
            if (string.IsNullOrWhiteSpace(txtCautareFurnizor.Text) || cmbCriteriuCautareFurnizor.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați un criteriu de căutare și introduceți o valoare pentru căutare.");
                return;
            }

            // Obținem criteriul de căutare și valoarea căutată din interfață
            string criteriu = cmbCriteriuCautareFurnizor.SelectedItem.ToString();
            string valoareCautata = txtCautareFurnizor.Text.ToLower(); // Folosim ToLower pentru a face căutarea insensibilă la majuscule/minuscule

            // Creăm o listă pentru stocarea rezultatelor căutării
            List<Furnizori> rezultateCautare = new List<Furnizori>();

            // Căutăm în lista de furnizori în funcție de criteriul selectat
            switch (criteriu)
            {
                case "Nume":
                    rezultateCautare = listaFurnizori.Where(furnizor => furnizor.Nume.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Contact":
                    rezultateCautare = listaFurnizori.Where(furnizor => furnizor.Contact.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Produse":
                    rezultateCautare = listaFurnizori.Where(furnizor => furnizor.Produse.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Plata":
                    rezultateCautare = listaFurnizori.Where(furnizor => furnizor.Plata.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Stock":
                    if (valoareCautata == "da" || valoareCautata == "nu")
                    {
                        StockStatus stockCautat = valoareCautata == "da" ? StockStatus.Da : StockStatus.Nu;
                        rezultateCautare = listaFurnizori.Where(furnizor => furnizor.Stock == stockCautat).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Valoarea căutată pentru stoc trebuie să fie 'da' sau 'nu'.");
                        return;
                    }
                    break;
            }

            listBoxRezultateCautareFurnizor.Visible = true;

            // Afisăm rezultatele în ListBox
            listBoxRezultateCautareFurnizor.Items.Clear();
            if (rezultateCautare.Any())
            {
                foreach (Furnizori furnizor in rezultateCautare)
                {
                    listBoxRezultateCautareFurnizor.Items.Add($"Nume: {furnizor.Nume}, Contact: {furnizor.Contact}, Produse: {furnizor.Produse}, Plata: {furnizor.Plata}, Stock: {furnizor.Stock}");
                }
            }
            else
            {
                listBoxRezultateCautareFurnizor.Items.Add("Niciun rezultat găsit pentru criteriul și valoarea specificate.");
            }
        }

        private void btnEditeazaFurnizor_Click(object sender, EventArgs e)
        {
            // Verifică dacă furnizorul este selectat pentru editare
            string numeFurnizorEditare = txtNumeFurnizorEditare.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeFurnizorEditare))
            {
                MessageBox.Show("Introduceți numele furnizorului pentru editare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Găsește furnizorul în listă bazat pe numele introdus
            Furnizori furnizorEditat = listaFurnizori.FirstOrDefault(furnizor => furnizor.Nume.Equals(numeFurnizorEditare, StringComparison.OrdinalIgnoreCase));

            if (furnizorEditat != null)
            {
                // Verifică dacă toate câmpurile sunt completate
                if (string.IsNullOrWhiteSpace(txtNumeFurnizorEditare.Text) || string.IsNullOrWhiteSpace(txtContactFurnizorEditare.Text) || string.IsNullOrWhiteSpace(txtProduseFurnizorEditare.Text) || string.IsNullOrWhiteSpace(txtPlataFurnizorEditare.Text) || comboBoxStockStatusEditare.SelectedIndex == -1)
                {
                    MessageBox.Show("Completați toate câmpurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizează informațiile furnizorului cu noile valori introduse de utilizator
                furnizorEditat.Contact = txtContactFurnizorEditare.Text;
                furnizorEditat.Produse = txtProduseFurnizorEditare.Text;
                furnizorEditat.Plata = txtPlataFurnizorEditare.Text;
                furnizorEditat.Stock = comboBoxStockStatusEditare.SelectedIndex == 0 ? StockStatus.Da : StockStatus.Nu;

                // Actualizează sursa de date (de exemplu, fișierul text) cu modificările efectuate
                ActualizeazaFisierulDeDateFurnizori();

                // Oferă feedback că editarea s-a realizat cu succes
                MessageBox.Show("Furnizorul a fost actualizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Oferă feedback că furnizorul nu a fost găsit
                MessageBox.Show("Nu s-a găsit niciun furnizor cu numele specificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaFisierulDeDateFurnizori()
        {
            // Definirea calei către fișierul de date
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Furnizori.Txt");

            // Verifică dacă fișierul există
            if (File.Exists(filePath))
            {
                // Creează o listă de linii actualizată cu noile informații despre furnizori
                List<string> updatedLines = new List<string>();
                foreach (var furnizor in listaFurnizori)
                {
                    string line = $"{furnizor.Nume},{furnizor.Contact},{furnizor.Produse},{furnizor.Plata},{(int)furnizor.Stock}";
                    updatedLines.Add(line);
                }

                // Suprascrie conținutul fișierului cu noile linii actualizate
                File.WriteAllLines(filePath, updatedLines);
            }
            else
            {
                MessageBox.Show("Fișierul de date pentru furnizori nu există.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        
    }
}
