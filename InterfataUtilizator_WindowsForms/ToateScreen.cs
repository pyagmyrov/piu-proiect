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
   

    public partial class ToateScreen : UserControl
    {
    
    
        


        public ToateScreen()
        {
            InitializeComponent();
           
            dataGridMedicament.ColumnCount = 3;
      
            dataGridMedicament.Columns[0].Name = "Nume";
            dataGridMedicament.Columns[1].Name = "Pret";
            dataGridMedicament.Columns[2].Name = "Cantiate";


        
            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
            List<Medicament> medicamenti = adminMedicament.GetMedicament();

            for (int i = 0; i < medicamenti.Count(); i++)
            {
      
                int cantiate = medicamenti[i].GetCantitate();
                string cantitateS = Convert.ToString(cantiate);

                String[] row = { medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS};
                dataGridMedicament.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
      

        }

        private void ToateScreen_Load(object sender, EventArgs e)
        {
            
          


        }

        private void dataGridMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridMedicament.Rows.Clear();
           
            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
            List<Medicament> medicamenti = adminMedicament.GetMedicament();

            for (int i = 0; i < medicamenti.Count(); i++)
            {

                int cantiate = medicamenti[i].GetCantitate();
                string cantitateS = Convert.ToString(cantiate);

                String[] row = { medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                dataGridMedicament.Rows.Add(row);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
            List<Medicament> medicamenti = adminMedicament.GetMedicament();
           
            string medicamentToSearch = searchText.Text;
            if(medicamentToSearch == String.Empty)
            {
                dataGridMedicament.Rows.Clear();
                for (int i = 0; i < medicamenti.Count(); i++)
                {

                    int cantiate = medicamenti[i].GetCantitate();
                    string cantitateS = Convert.ToString(cantiate);

                    String[] row = { medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                    dataGridMedicament.Rows.Add(row);
                }

            }
            else
            {
                bool found = false;
                for (int i = 0; i < medicamenti.Count(); i++)
                {
                    if (medicamenti[i].GetNume() == medicamentToSearch)
                    {
                        found = true;
                        dataGridMedicament.Rows.Clear();
                        int cantiate = medicamenti[i].GetCantitate();
                        string cantitateS = Convert.ToString(cantiate);
                        String[] row = { medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                        dataGridMedicament.Rows.Add(row);
                    }

                }
                if (found)
                {
                    searchBtn.BackColor = Color.FromArgb(46, 204, 113);
                }
                else
                {
                    searchBtn.BackColor = Color.FromArgb(232, 65, 24);
                }

            }
          

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.FromArgb(30, 39, 46);
        }

    }
}
