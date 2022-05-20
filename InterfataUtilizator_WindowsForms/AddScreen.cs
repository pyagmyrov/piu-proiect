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

        }

        private void adaugareMedicamentBtn_Click(object sender, EventArgs e)
        {
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + "medicamenti.txt";
            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText(caleCompletaFisier);
            List<Medicament> medicamenti = adminMedicament.GetMedicament();
            int id = medicamenti.Count() + 1;
            Medicament medicament = new Medicament(id,NumeText.Text, pretTxtBox.Text + " " + currencyDropDown.Text, Convert.ToInt32(cantitateTxtBox.Text));
            id++;
            adminMedicament.AddMedicament(medicament);
            NumeText.Text = "";
            pretTxtBox.Text = "";
            cantitateTxtBox.Text = "";
            adaugareMedicamentBtn.Text = "Added";
            adaugareMedicamentBtn.BackColor = Color.Green;
        }
    }
}
