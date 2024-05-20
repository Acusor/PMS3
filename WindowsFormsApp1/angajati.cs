using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.stock;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class angajati : Form
    {

        private List<Angajati> membri;

       

        public class Angajati
        {
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public string Gen { get; set; }
            public int ID { get; set; }
            public string Functie { get; set; }
            public string Contact { get; set; }

        }
        public angajati()
        {
            InitializeComponent();
            membri = new List<Angajati>();
            AfiseazaAngajati();

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
            }

            cmbCriteriuCautare.Items.AddRange(new string[] { "Nume", "Prenume", "Gen", "ID", "Funcție", "Contact" });
        }

        public void AfiseazaAngajati()
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Angajati.Txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Fisierul nu exista,asa ca a fost creat!");
                return;

            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 6)
                {
                    try
                    {
                        Angajati membru = new Angajati()
                        {
                            Nume = parts[0],
                            Prenume = parts[1],
                            Gen = parts[2],
                            ID = int.Parse(parts[3]),
                            Functie = parts[4],
                            Contact = parts[5],



                        };
                        membri.Add(membru);
                        AdaugaAngajatLaFormular(membru);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre linii");
                        return;
                    }
                }
            }
        }

        private void AdaugaAngajatLaFormular(Angajati membru)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{membru.Nume}"
            };

            TextBox textBoxPrenume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{membru.Prenume}"
            };

            TextBox textBoxGenSelectat = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                Text = membru.Gen
            };

            RadioButton radioButtonMasculin = new RadioButton
            {
                AutoSize = true,
                Enabled=false,
                Text="Masculin",
                Checked = (membru.Gen=="Masculin")

            };
            radioButtonMasculin.CheckedChanged += (sender, e) => { if (radioButtonMasculin.Checked) textBoxGenSelectat.Text = "Masculin"; }; 

            RadioButton radioButtonFeminin = new RadioButton
            {
                AutoSize = true,
                Enabled = false,
                Text = "Feminin",
                Checked = (membru.Gen == "M")

            };
            radioButtonMasculin.CheckedChanged += (sender, e) => { if (radioButtonFeminin.Checked) textBoxGenSelectat.Text = "Feminin"; };

            TextBox textBoxID = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{membru.ID}"
            };

            TextBox textBoxFunctie = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{membru.Functie}"
            };

            TextBox textBoxContact = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{membru.Contact}"
            };

 
            flowLayoutPanelAngajati.Controls.Add(textBoxNume);
            flowLayoutPanelAngajati.Controls.Add(textBoxPrenume);
            flowLayoutPanelAngajati.Controls.Add(textBoxGenSelectat);
            flowLayoutPanelAngajati.Controls.Add(textBoxID);
            flowLayoutPanelAngajati.Controls.Add(textBoxFunctie);
            flowLayoutPanelAngajati.Controls.Add(textBoxContact);

        }

        private void AdaugaAngajatiInFisier(Angajati membru)
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Angajati.Txt");
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{membru.Nume},{membru.Prenume},{membru.Gen},{membru.ID},{membru.Functie},{membru.Contact}");
            }
        }

        private void flowLayoutPanelAngajati_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdaugareAngajati_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnStergereAngajati_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnCautareAngajati_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            listBoxRezultateCautare.Visible = false;
        }

        private void btnEditareAngajati_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }





        private void btnAdaugaAngajati_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeAngajat.Text) || string.IsNullOrWhiteSpace(txtPrenumeAngajat.Text) || string.IsNullOrWhiteSpace(txtIDAngajat.Text) 
                || string.IsNullOrWhiteSpace(txtFunctieAngajat.Text) || string.IsNullOrWhiteSpace(txtContactAngajat.Text))
            {
                MessageBox.Show("Introduceti date valide pentru a completa campurile");
                return;
            }

            if(!int.TryParse(txtIDAngajat.Text,out int id) || id<0)
            {
                MessageBox.Show("Introduceti un ID valid");
                return;
            }

            string gen = radioButtonMasculin.Checked ? "Masculin" : "Feminin";


            Angajati membru = new Angajati
            {
                Nume = txtNumeAngajat.Text,
                Prenume = txtPrenumeAngajat.Text,
                // Gen=txtGenAngajat.Text,
                Gen = gen,
                ID=id,
                Functie=txtFunctieAngajat.Text,
                Contact=txtContactAngajat.Text

            };

            AdaugaAngajatLaFormular(membru);
            AdaugaAngajatiInFisier(membru);
            MessageBox.Show("Angajatul a fost adaugat cu succes!");

            txtNumeAngajat.Text = "";
            txtPrenumeAngajat.Text = "";
            txtIDAngajat.Text = "";
            txtFunctieAngajat.Text = "";
            txtContactAngajat.Text = "";

            tabControl1.SelectedTab = tabPage1;
        }

        private void btnStergeAngajati_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDStergereAngajat.Text))
            {
                MessageBox.Show("Introduceți ID-ul angajatului pe care doriți să-l ștergeți.");
                return;
            }

            if (!int.TryParse(txtIDStergereAngajat.Text, out int id))
            {
                MessageBox.Show("Introduceți un ID valid pentru angajatul pe care doriți să-l ștergeți.");
                return;
            }

            Angajati angajatDeSters = membri.FirstOrDefault(angajat => angajat.ID == id);

            if (angajatDeSters == null)
            {
                MessageBox.Show("Angajatul cu ID-ul specificat nu există.");
                return;
            }

           
            membri.Remove(angajatDeSters);
            flowLayoutPanelAngajati.Controls.Clear(); 
            membri.ForEach(AdaugaAngajatLaFormular); 

          
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Angajati.Txt");
            File.WriteAllLines(filePath, membri.Select(angajat =>
                $"{angajat.Nume},{angajat.Prenume},{angajat.Gen},{angajat.ID},{angajat.Functie},{angajat.Contact}"));

            MessageBox.Show("Angajatul a fost șters cu succes.");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCautaAngajati_Click_1(object sender, EventArgs e)
        {

            
           
            if (string.IsNullOrWhiteSpace(txtCautareAngajat.Text) || cmbCriteriuCautare.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați un criteriu de căutare și introduceți o valoare pentru căutare.");
                return;
            }

     
            string criteriu = cmbCriteriuCautare.SelectedItem.ToString();
            string valoareCautata = txtCautareAngajat.Text.ToLower();

         
            List<Angajati> rezultateCautare = new List<Angajati>();

            
            switch (criteriu)
            {
                case "Nume":
                    rezultateCautare = membri.Where(angajat => angajat.Nume.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Prenume":
                    rezultateCautare = membri.Where(angajat => angajat.Prenume.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Gen":
                    rezultateCautare = membri.Where(angajat => angajat.Gen.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "ID":
                    if (int.TryParse(valoareCautata, out int idCautat))
                    {
                        rezultateCautare = membri.Where(angajat => angajat.ID == idCautat).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Introduceți un ID valid pentru căutare.");
                        return;
                    }
                    break;
                case "Funcție":
                    rezultateCautare = membri.Where(angajat => angajat.Functie.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Contact":
                    rezultateCautare = membri.Where(angajat => angajat.Contact.ToLower().Contains(valoareCautata)).ToList();
                    break;
            }

            listBoxRezultateCautare.Visible = true;

         
            listBoxRezultateCautare.Items.Clear();
            if (rezultateCautare.Any())
            {
                foreach (Angajati angajat in rezultateCautare)
                {
                    listBoxRezultateCautare.Items.Add($"Nume: {angajat.Nume}, Prenume: {angajat.Prenume}, Gen: {angajat.Gen}, ID: {angajat.ID}, Funcție: {angajat.Functie}, Contact: {angajat.Contact}");
                }
            }
            else
            {
                listBoxRezultateCautare.Items.Add("Niciun rezultat găsit pentru criteriul și valoarea specificate.");
            }
        }

        private void btnEditeazaAngajat_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtIDAngajatEditare.Text))
            {
                MessageBox.Show("Introduceți ID-ul angajatului pentru editare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if (!int.TryParse(txtIDAngajatEditare.Text, out int idEditare))
            {
                MessageBox.Show("ID-ul angajatului nu este valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            Angajati angajatEditat = membri.FirstOrDefault(angajat => angajat.ID == idEditare);

            if (angajatEditat != null)
            {
         
                if (string.IsNullOrWhiteSpace(txtNumeEditare.Text) || string.IsNullOrWhiteSpace(txtPrenumeEditare.Text) || string.IsNullOrWhiteSpace(txtGenEditare.Text) || string.IsNullOrWhiteSpace(txtFunctieEditare.Text) || string.IsNullOrWhiteSpace(txtContactEditare.Text))
                {
                    MessageBox.Show("Completați toate câmpurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                angajatEditat.Nume = txtNumeEditare.Text;
                angajatEditat.Prenume = txtPrenumeEditare.Text;
                angajatEditat.Gen = txtGenEditare.Text;
                angajatEditat.Functie = txtFunctieEditare.Text;
                angajatEditat.Contact = txtContactEditare.Text;

               
                ActualizeazaFisierulDeDateAngajati();

           
                MessageBox.Show("Angajatul a fost actualizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
          
                MessageBox.Show("Nu s-a găsit niciun angajat cu ID-ul specificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaFisierulDeDateAngajati()
        {
           
            string filePath = "Angajati.Txt";

    
            if (File.Exists(filePath))
            {
            
                File.WriteAllText(filePath, string.Empty);

            
                foreach (var angajat in membri)
                {
                    string linieAngajat = $"{angajat.Nume},{angajat.Prenume},{angajat.Gen},{angajat.ID},{angajat.Functie},{angajat.Contact}";
                    File.AppendAllText(filePath, linieAngajat + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Fișierul de date pentru angajați nu există.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnulareAngajati_Click(object sender, EventArgs e)
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
    }
}



