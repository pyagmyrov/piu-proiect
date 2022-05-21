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
    public partial class UpdateScreen : UserControl
    {
        public UpdateScreen()
        {
          
            InitializeComponent(); dataGridViewUpdScren.ColumnCount = 4;
            dataGridViewUpdScren.Columns[0].Name = "ID";
            dataGridViewUpdScren.Columns[1].Name = "Nume";
            dataGridViewUpdScren.Columns[2].Name = "Pret";
            dataGridViewUpdScren.Columns[3].Name = "Cantiate";
            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
            List<Medicament> medicamenti = adminMedicament.GetMedicament();

            for (int i = 0; i < medicamenti.Count(); i++)
            {
                int id = medicamenti[i].GetIdMedicament();
                string idS = Convert.ToString(id);
                int cantiate = medicamenti[i].GetCantitate();
                string cantitateS = Convert.ToString(cantiate);

                String[] row = { idS, medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                dataGridViewUpdScren.Rows.Add(row);
            }

        }

        private void UpdateScreen_Load(object sender, EventArgs e)
        {
            currencyUpdScren.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUpdScren_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void currencyUpdScren_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateButtonUpdScren_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(idTextUpdScren.Text, out int numericValue);
            if (isNumber)
            {
                AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
                List<Medicament> medicamenti = adminMedicament.GetMedicament();
                int id = Convert.ToInt32(idTextUpdScren.Text);
               
                foreach (Medicament medicament in medicamenti)
                {
                    if(id == medicament.GetIdMedicament())
               
                    {
                        if (String.IsNullOrEmpty(numeTextUpdScren.Text) == false)
                        {
                            medicament.SetNume(numeTextUpdScren.Text);
                        }
                        if (String.IsNullOrEmpty(pretTextUpdScren.Text) == false)
                        {
                            medicament.SetPret(pretTextUpdScren.Text + " " + currencyUpdScren.Text);
                        }

                        if (String.IsNullOrEmpty(CantTextUpdScren.Text) == false)
                        {
                            int cantitate = Convert.ToInt32(CantTextUpdScren.Text);
                            medicament.setCantitae(cantitate);
                        }


                    }

                    
                }
                adminMedicament.ClearFile();

                foreach(Medicament medic in medicamenti)
                {
                    adminMedicament.AddMedicament(medic);
                }

               
                dataGridViewUpdScren.Rows.Clear();
                for (int i = 0; i < medicamenti.Count(); i++)
                {
                    int idc = medicamenti[i].GetIdMedicament();
                    string idS = Convert.ToString(idc);
                    int cantiate = medicamenti[i].GetCantitate();
                    string cantitateS = Convert.ToString(cantiate);

                    String[] row = { idS, medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                    dataGridViewUpdScren.Rows.Add(row);
                }



            }
            else
            {
                updateButtonUpdScren.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                dataGridViewUpdScren.Rows.Clear();
               AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
            List<Medicament> medicamenti = adminMedicament.GetMedicament();

            for (int i = 0; i < medicamenti.Count(); i++)
            {
                int id = medicamenti[i].GetIdMedicament();
                string idS = Convert.ToString(id);
                int cantiate = medicamenti[i].GetCantitate();
                string cantitateS = Convert.ToString(cantiate);

                String[] row = { idS, medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                dataGridViewUpdScren.Rows.Add(row);
            }
        }

        private void idTextUpdScren_TextChanged(object sender, EventArgs e)
        {
            updateButtonUpdScren.BackColor = Color.FromArgb(30, 39, 46);
        }
    }
}
