using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static WindowsFormsApp1.stock;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class stock : Form
    {
        private const decimal MinPret = 0;

        private List<Medicament> medicamente;
        public class Medicament
        {
            public string Nume { get; set; }
            public string Producator { get; set; }
            public decimal Pret { get; set; }
            public int Cantitate { get; set; }
            public int ID { get; set; }
            public DateTime DataExpirare { get; set; }


        }


        public stock()
        {
            InitializeComponent();
            medicamente = new List<Medicament>();
            AfiseazaMedicamente();

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
            }

            cmbCriteriuCautareMedicamente.Items.AddRange(new string[] { "Nume", "Furnizor", "Pret", "Cantitate", "ID", "D/E" });
        }

        


        private void AfiseazaMedicamente()
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath,"Medicamente.Txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Fișierul de date nu există și a fost creat!");
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
                        Medicament medicament = new Medicament
                        {
                            Nume = parts[0],
                            Producator = parts[1],
                            Pret = decimal.Parse(parts[2]),
                            Cantitate = int.Parse(parts[3]),
                            ID = int.Parse(parts[4]),
                            DataExpirare = DateTime.Parse(parts[5])
                        };
                        medicamente.Add(medicament);
                        AdaugaMedicamentLaFormular(medicament);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre linii.");
                        return;
                    }
                }
            }
        }

        public enum TipMedicament
        {
            FaraReteta = 1,
            CuReteta = 2
        }
        private void AdaugaMedicamentLaFormular(Medicament medicament)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{medicament.Nume}"
            };

            TextBox textBoxProducator = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{medicament.Producator}"
            };

            TextBox textBoxPret = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{medicament.Pret} lei"
            };

            TextBox textBoxCantitate = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{medicament.Cantitate} bucati"
            };

            TextBox textBoxID = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"{medicament.ID}"


            };

            TextBox textBoxDataExpirare = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = medicament.DataExpirare.ToString("dd/MM/yyyy")
            };

            flowLayoutPanelMedicamente.Controls.Add(textBoxNume);
            flowLayoutPanelMedicamente.Controls.Add(textBoxProducator);
            flowLayoutPanelMedicamente.Controls.Add(textBoxPret);
            flowLayoutPanelMedicamente.Controls.Add(textBoxCantitate);
            flowLayoutPanelMedicamente.Controls.Add(textBoxID);
            flowLayoutPanelMedicamente.Controls.Add(textBoxDataExpirare);
        }

        private void AdaugaMedicamentInFisier(Medicament medicament)
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Medicamente.Txt");
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{medicament.Nume},{medicament.Producator},{medicament.Pret},{medicament.Cantitate},{medicament.ID},{medicament.DataExpirare}");
            }
        }






        private void flowLayoutPanelMedicamente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdaugareMedicamente_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedTab = tabPage2;

        }

        private void btnEditareMedicamente_Click(object sender, EventArgs e)
        {
          
            tabControl1.SelectedTab = tabPage4;
        }

        private void btnCautareMedicamente_Click(object sender, EventArgs e)
        {
           
            tabControl1.SelectedTab = tabPage3;
            listBoxRezultateCautareMedicamente.Visible = false;



        }

        private void btnStergereMedicamente_Click(object sender, EventArgs e)
        {
      
             tabControl1.SelectedTab = tabPage5;
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducator_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDMedicament_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataExpirare_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaMedicamnete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtProducator.Text) || string.IsNullOrWhiteSpace(txtPret.Text) || string.IsNullOrWhiteSpace(txtIDMedicament.Text) || string.IsNullOrWhiteSpace(txtDataExpirare.Text))
            {
                MessageBox.Show("Introduceți date valide pentru medicament!");
                return;
            }

            if (!int.TryParse(txtCantitate.Text, out int cantitate) || cantitate < 0)
            {
                MessageBox.Show("Cantitatea introdusă nu este validă!");
                return;
            }
            if (!int.TryParse(txtIDMedicament.Text, out int id) || id<0)
            {
                MessageBox.Show("ID invalid!");
                return;
            }

        if (!decimal.TryParse(txtPret.Text,out decimal pret) || pret<MinPret)
            {
                MessageBox.Show("Pretul Introdus nu este valid!");
                return;
            }

        if (!DateTime.TryParseExact(txtDataExpirare.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataExpirare))
            {
                MessageBox.Show("Data expirare introdusă nu este validă! Folosiți formatul dd/MM/yyyy.");
                return;
            }


            Medicament medicament = new Medicament
            {
                Nume = txtNume.Text,
                Producator = txtProducator.Text,
                Pret = pret,
                Cantitate = cantitate,
                ID = id


            };

            AdaugaMedicamentInFisier(medicament);
            AdaugaMedicamentLaFormular(medicament);
            MessageBox.Show("Medicamentul a fost adaugat cu succes!");

            // Resetare câmpuri
            txtNume.Text = "";
            txtProducator.Text = "";
            txtPret.Text = "";
            txtCantitate.Text = "";
            txtIDMedicament.Text="";
            txtDataExpirare.Text = "";

           
        }

        private void txtNumeCautat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducatorCautat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPretMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPretMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void CautaMedicamente_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtCautareMedicament.Text) || cmbCriteriuCautareMedicamente.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați un criteriu de căutare și introduceți o valoare pentru căutare.");
                return;
            }

         
            string criteriu = cmbCriteriuCautareMedicamente.SelectedItem.ToString();
            string valoareCautata = txtCautareMedicament.Text.ToLower();
          
            List<Medicament> rezultateCautare = new List<Medicament>();

          
            switch (criteriu)
            {
                case "Nume":
                    rezultateCautare = medicamente.Where(medicament => medicament.Nume.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Producator":
                    rezultateCautare = medicamente.Where(medicament => medicament.Producator.ToLower().Contains(valoareCautata)).ToList();
                    break;
                case "Pret":
                    if (decimal.TryParse(valoareCautata, out decimal pretCautat))
                    {
                        rezultateCautare = medicamente.Where(medicament => medicament.Pret == pretCautat).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Introduceți un preț valid pentru căutare.");
                        return;
                    }
                    break;
                case "Cantitate":
                    if (int.TryParse(valoareCautata, out int cantitateCautata))
                    {
                        rezultateCautare = medicamente.Where(medicament => medicament.Cantitate == cantitateCautata).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Introduceți o cantitate validă pentru căutare.");
                        return;
                    }
                    break;
                case "ID":
                    if (int.TryParse(valoareCautata, out int idCautat))
                    {
                        rezultateCautare = medicamente.Where(medicament => medicament.ID == idCautat).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Introduceți un ID valid pentru căutare.");
                        return;
                    }
                    break;
                case "D/E":
                    if (DateTime.TryParseExact(valoareCautata, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataExpirareCautata))
                    {
                        rezultateCautare = medicamente.Where(medicament => medicament.DataExpirare.Date == dataExpirareCautata.Date).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Introduceți o dată de expirare validă pentru căutare. Folosiți formatul dd/MM/yyyy.");
                        return;
                    }
                    break;

            
            }

            listBoxRezultateCautareMedicamente.Visible = true;

           
            listBoxRezultateCautareMedicamente.Items.Clear();
            if (rezultateCautare.Any())
            {
                foreach (Medicament medicament in rezultateCautare)
                {
                    listBoxRezultateCautareMedicamente.Items.Add($"Nume: {medicament.Nume}, Producator: {medicament.Producator}, Pret: {medicament.Pret} lei, Cantitate: {medicament.Cantitate} bucati, ID: {medicament.ID}, Data Expirare: {medicament.DataExpirare.ToString("dd/MM/yyyy")}");
                }
            }
            else
            {
                listBoxRezultateCautareMedicamente.Items.Add("Niciun rezultat găsit pentru criteriul și valoarea specificate.");
            }

         
        }


        private void ActualizeazaMedicamente_Click(object sender, EventArgs e)
        {
            int idActualizat = int.Parse(txtIDMedicamentActualizat.Text);

            if (string.IsNullOrWhiteSpace(txtNumeActualizat.Text) || string.IsNullOrWhiteSpace(txtProducatorActualizat.Text) || string.IsNullOrWhiteSpace(txtPretActualizat.Text) || string.IsNullOrWhiteSpace(txtCantitateActualizata.Text) || string.IsNullOrWhiteSpace(txtIDMedicamentActualizat.Text) || string.IsNullOrWhiteSpace(txtDataExpirareActualizata.Text))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



          
            if (!decimal.TryParse(txtPretActualizat.Text, out decimal pretActualizat) || pretActualizat < MinPret)
            {
                MessageBox.Show("Prețul introdus nu este valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!int.TryParse(txtCantitateActualizata.Text, out int cantitateActualizata) || cantitateActualizata < 0)
            {
                MessageBox.Show("Cantitatea introdusă nu este validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!DateTime.TryParseExact(txtDataExpirareActualizata.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataExpirareActualizata))
            {
                MessageBox.Show("Data de expirare introdusă nu este validă. Folosiți formatul dd/MM/yyyy.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            var medicamentEditat = medicamente.FirstOrDefault(med => med.ID == idActualizat);

            if (medicamentEditat != null)
            {
               
                medicamentEditat.Nume = txtNumeActualizat.Text;
                medicamentEditat.Producator = txtProducatorActualizat.Text;
                medicamentEditat.Pret = decimal.Parse(txtPretActualizat.Text);
                medicamentEditat.Cantitate = int.Parse(txtCantitateActualizata.Text);
                medicamentEditat.DataExpirare = DateTime.ParseExact(txtDataExpirareActualizata.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

               
                ActualizeazaFisierulDeDate();

               
                MessageBox.Show("Medicamentul a fost actualizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("Nu s-a găsit niciun medicament cu ID-ul specificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        private void ActualizeazaFisierulDeDate()
        {
           
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Medicamente.Txt");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var medicament in medicamente)
                {
                    sw.WriteLine($"{medicament.Nume},{medicament.Producator},{medicament.Pret},{medicament.Cantitate},{medicament.ID},{medicament.DataExpirare}");
                }
            }
        }

        private void StergeMedicamente_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDMedicamentStergere.Text, out int idMedicamentStergere) || idMedicamentStergere < 0)
            {
                MessageBox.Show("Introduceți un ID valid pentru medicamentul de șters.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            var medicamentStergere = medicamente.FirstOrDefault(med => med.ID == idMedicamentStergere);

            if (medicamentStergere != null)
            {
                
                medicamente.Remove(medicamentStergere);

                
                ActualizeazaFisierulDeDate();

               
                MessageBox.Show($"Medicamentul cu ID-ul {idMedicamentStergere} a fost șters cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtIDMedicamentStergere.Text = "";
            }
            else
            {
               
                MessageBox.Show("Nu s-a găsit niciun medicament cu ID-ul specificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnAnulare2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}

