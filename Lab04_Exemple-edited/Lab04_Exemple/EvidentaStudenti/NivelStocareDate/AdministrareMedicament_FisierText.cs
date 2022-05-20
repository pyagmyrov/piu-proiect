using LibrarieModele;
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NivelStocareDate
{
    public class AdministrareMedicament_FisierText
    {
        private const int NR_MAX_MEDICAMENTI = 50;
        private string numeFisier;

        public AdministrareMedicament_FisierText(string numeFisier)
        {
            this.numeFisier = "db.txt";
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open("db.txt", FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddMedicament(Medicament medicament)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            
            using (StreamWriter streamWriterFisierText = new StreamWriter("db.txt", true))
            {
                streamWriterFisierText.WriteLine(medicament.ConversieLaSir_PentruFisier());
            }
        }

        public List<Medicament> GetMedicament()
        {
            ArrayList medicamenti = new ArrayList();
         

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
            

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Medicament medicament = new Medicament(linieFisier);
                    medicamenti.Add(medicament);
                }
            }

            return medicamenti.Cast<Medicament>().ToList();
        }

         public void ClearFile()
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter("db.txt", false))
            {
                streamWriterFisierText.Write(string.Empty);
            }
        }
       
    }
}