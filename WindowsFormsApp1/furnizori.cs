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

namespace WindowsFormsApp1
{
    public partial class furnizori : Form
    {
       
        public class Furnizori
        {
            public string Nume { get; set; }
            public string Contact { get; set; }
            public string ProduseFurnizate { get; set; }
            public string TermeniPlata { get; set; }
            public string IstoricComenzi { get; set; }
            public decimal PreturiProduse { get; set; }
            public string InformatiiFiscale { get; set; }
            public string DisponibilitateStoc { get; set; }
        }
        public furnizori()
        {
            InitializeComponent();


        }

        

        public void AfiseazaFurnizori()
        {
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(directoryPath, "Furnizori.Txt");

            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Fisierul nu exista,asa ca a fost facut unul nou");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach(var line in lines)
            {
                var parts = line.Split(',');
                if(parts.Length==8)
                {
                    try
                    {
                        Furnizori furnizor = new Furnizori()
                        {
                            Nume = parts[0],
                            Contact = parts[1],
                            ProduseFurnizate = parts[2],
                            TermeniPlata = parts[3],
                            IstoricComenzi = parts[4],
                            PreturiProduse = decimal.Parse(parts[5]),
                            InformatiiFiscale = parts[6],
                            DisponibilitateStoc = parts[7]
                        };
                   
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre liniile furnizorilor.");
                        return;
                    }

                }
            }

        }
       





    }
}
