using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;
using LibrarieModele;
using NivelStocareDate;
using System.Collections.Generic;


namespace InterfataUtilizator_WindowsForms
{


   

    public partial class Farmacia : Form
    {

        
    
        private void ChangeScreen(string screen)
        {
            switch (screen)
            {
                case "acasa":
                    AcasaBtn.BackColor = Color.FromArgb(34, 47, 62);
                    despreButton.BackColor = Color.Transparent;
                    addButton.BackColor = Color.Transparent;
                    updateButton.BackColor = Color.Transparent;
                    addScreen1.Hide();
                    updateScreen1.Hide();
                    despreScreen1.Hide();
                    toateScreen2.Show();
                    toateScreen2.BringToFront();
                    break;
                case "add":
                    addButton.BackColor = Color.FromArgb(34, 47, 62);
                    updateButton.BackColor = Color.Transparent;
                    AcasaBtn.BackColor = Color.Transparent;
                    despreButton.BackColor = Color.Transparent;
                    toateScreen2.Hide();
                    updateScreen1.Hide();
                    despreScreen1.Hide();
                    addScreen1.Show();
                    addScreen1.BringToFront();
                    break;
                case "update":
                    addButton.BackColor = Color.Transparent;
                    updateButton.BackColor = Color.FromArgb(34, 47, 62);
                    AcasaBtn.BackColor = Color.Transparent;
                    despreButton.BackColor = Color.Transparent;
                    addScreen1.Hide();
                    toateScreen2.Hide();
                    despreScreen1.Hide();
                    updateScreen1.Show();
                    updateScreen1.BringToFront();
                    break;
                case "despre":
                    despreButton.BackColor = Color.FromArgb(34, 47, 62);
                    updateButton.BackColor = Color.Transparent;
                    addButton.BackColor = Color.Transparent;
                    AcasaBtn.BackColor = Color.Transparent;
                    toateScreen2.Hide();
                    addScreen1.Hide();
                    updateScreen1.Hide();
                    despreScreen1.Show();
                    despreScreen1.BringToFront();
                    break;
                default:
                    AcasaBtn.BackColor = Color.FromArgb(34, 47, 62);
                    addScreen1.Hide();
                    updateScreen1.Hide();
                    despreScreen1.Hide();
                    toateScreen2.Show();
                    toateScreen2.BringToFront();
                    break;


            }
        }

        public Farmacia()
        {
            InitializeComponent();
        }
     

        private void Farmacia_Load(object sender, EventArgs e)
        {
         
            AcasaBtn.BackColor = Color.FromArgb(34, 47, 62);
            addScreen1.Hide();
            toateScreen2.Dock = DockStyle.Fill;
            updateScreen1.Dock = DockStyle.Fill;
            despreScreen1.Dock = DockStyle.Fill;
            addScreen1.Dock = DockStyle.Fill;
            updateScreen1.Hide();
            despreScreen1.Hide();
            toateScreen2.Show();
            toateScreen2.BringToFront();

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeScreen("despre");
        }

        private void Acasa_Click(object sender, EventArgs e)
        {
            ChangeScreen("acasa");

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ChangeScreen("add");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ChangeScreen("update");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toateScreen2_Load(object sender, EventArgs e)
        {

        }
    }
}
