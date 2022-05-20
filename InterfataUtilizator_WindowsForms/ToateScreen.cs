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
            dataGridMedicament.ColumnCount = 4;
            dataGridMedicament.Columns[0].Name = "ID";
            dataGridMedicament.Columns[1].Name = "Nume";
            dataGridMedicament.Columns[2].Name = "Pret";
            dataGridMedicament.Columns[3].Name = "Cantiate";


        
            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText("db.txt");
            List<Medicament> medicamenti = adminMedicament.GetMedicament();

            for (int i = 0; i < medicamenti.Count(); i++)
            {
                int id = medicamenti[i].GetIdMedicament();
                string idS = Convert.ToString(id);
                int cantiate = medicamenti[i].GetCantitate();
                string cantitateS = Convert.ToString(cantiate);

                String[] row = {idS, medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS};
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
                int id = medicamenti[i].GetIdMedicament();
                string idS = Convert.ToString(id);
                int cantiate = medicamenti[i].GetCantitate();
                string cantitateS = Convert.ToString(cantiate);

                String[] row = { idS, medicamenti[i].GetNume(), medicamenti[i].GetPret(), cantitateS };
                dataGridMedicament.Rows.Add(row);
            }
        }
    }
}
