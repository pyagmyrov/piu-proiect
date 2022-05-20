using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelStocareDate;
using LibrarieModele;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public partial class AddScreen : UserControl
    {
       
        public AddScreen()
        {
            InitializeComponent();
            currencyDropDown.SelectedIndex = 0;

        }

        private void currencyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pretTxtBox.BackColor = Color.FromArgb(30, 39, 46);
            adaugareMedicamentBtn.Text = "Adaugare";
            adaugareMedicamentBtn.BackColor = Color.FromArgb(30, 39, 46);
        }

        private void adaugareMedicamentBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NumeText.Text))
            {
                NumeText.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(pretTxtBox.Text))
            {
                pretTxtBox.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(cantitateTxtBox.Text))
            {
                cantitateTxtBox.BackColor = Color.Red;
            }
            if(String.IsNullOrEmpty(NumeText.Text) || String.IsNullOrEmpty(pretTxtBox.Text) || String.IsNullOrEmpty(cantitateTxtBox.Text))
            {
                adaugareMedicamentBtn.BackColor = Color.Red;
            }
            else
            {
                bool isNumber = int.TryParse(cantitateTxtBox.Text, out int numericValue);
                if (isNumber)
                {
                    double number;
                    if (double.TryParse(cantitateTxtBox.Text, out number))
                    {
                        if (number > 0)
                        {
                            bool isPretNumber = int.TryParse(pretTxtBox.Text, out int nr);
                            if (isPretNumber)
                            {
                                string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                                string caleCompletaFisier = locatieFisierSolutie + "\\" + "medicamenti.txt";
                                AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText(caleCompletaFisier);
                                List<Medicament> medicamenti = adminMedicament.GetMedicament();
                                int id = medicamenti.Count() + 1;
                                Medicament medicament = new Medicament(id, NumeText.Text, pretTxtBox.Text + " " + currencyDropDown.Text, Convert.ToInt32(cantitateTxtBox.Text));
                                id++;
                                adminMedicament.AddMedicament(medicament);
                                NumeText.Text = "";
                                pretTxtBox.Text = "";
                                cantitateTxtBox.Text = "";
                                adaugareMedicamentBtn.Text = "Added";
                                adaugareMedicamentBtn.BackColor = Color.Green;
                            }
                            else
                            {
                                pretTxtBox.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            cantitateTxtBox.BackColor = Color.Red; 
                        }
                    }
                   
                }
                else
                {
                    cantitateTxtBox.BackColor = Color.Red;
                }
            }
          

      
        }

        private void NumeText_TextChanged(object sender, EventArgs e)
        {
            NumeText.BackColor = Color.FromArgb(30, 39, 46);
            adaugareMedicamentBtn.Text = "Adaugare";
            adaugareMedicamentBtn.BackColor = Color.FromArgb(30, 39, 46);
        }

        private void cantitateTxtBox_TextChanged(object sender, EventArgs e)
        {
            cantitateTxtBox.BackColor = Color.FromArgb(30, 39, 46);
            adaugareMedicamentBtn.Text = "Adaugare";
            adaugareMedicamentBtn.BackColor = Color.FromArgb(30, 39, 46);
        }
    }
}
