using System;
namespace farmacia
{
    public class Medicament
    {
        string nume;
        int pret;
        int cantitate;
        public Medicament(string nume, int pret, int cantitate)
        {
            this.nume = nume;
            this.pret = pret;
            this.cantitate = cantitate;
        }
         public int GetCantitate()
        {
            return cantitate;
        }
        public string GetNume()
        {
            return nume;
        }
        public int GetPret()
        {
            return pret;
        }
        public void Add(int nrDeAdaugat)
        {
            cantitate += nrDeAdaugat;
        }
        public void Remove(int nrDeSters)
        {
            if (cantitate > 0)
            {
                cantitate -= nrDeSters;
            }
            
        }
        public void EditPret(int pretNou)
        {
            pret = pretNou;

        }
        public void EditNume(string numeNoua)
        {
            nume = numeNoua;

        }

    }
}
