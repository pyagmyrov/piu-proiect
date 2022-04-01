using System;

namespace LibrarieModele
{
    public class Medicament
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRET = 2;
        private const int CANT = 3;
        //proprietati auto-implemented
        private int idMedicament; //identificator unic medicament
        private string nume;
        private string pret;
        private int cantitate;
        //contructor implicit
        public Medicament()
        {
            nume = pret = string.Empty;
        }

        //constructor cu parametri
        public Medicament(int idMedicament, string nume, string pret, int cantitate)
        {
            this.idMedicament = idMedicament;
            this.nume = nume;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idMedicament = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            pret = dateFisier[PRET];
            cantitate = Convert.ToInt32(dateFisier[CANT]
            );
            
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idMedicament.ToString(),
                (nume ?? " NECUNOSCUT "),
                (pret ?? " NECUNOSCUT "),
                cantitate.ToString());

            return obiectMedicamentPentruFisier;
        }

        public string GetPret()
        {
            return pret;
        }
        public void setCantitae(int cantitate)
        {
            this.cantitate = cantitate;
        }

        public int GetCantitate()
        {
            return cantitate;
        }

        public int GetIdMedicament()
        {
            return idMedicament;
        }

        public string GetNume()
        {
            return nume;
        }

        public void SetIdMedicament(int idMedicament)
        {
            this.idMedicament = idMedicament;
        }
    }

}
