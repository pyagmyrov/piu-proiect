using System;
using System.Configuration;
using LibrarieModele;
using NivelStocareDate;

namespace Farmacia
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeFisier;

            if (args.Length == 0)
            {
                numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            }
            else
            {
                numeFisier = args[0];
            }

            AdministrareMedicament_FisierText adminMedicament = new AdministrareMedicament_FisierText(numeFisier);
            Medicament medicamentNou = new Medicament();
            int nrMedicamenti = 0;
            // acest apel ajuta la obtinerea numarului de studenti inca de la inceputul executiei
            // astfel incat o eventuala adaugare sa atribuie un IdStudent corect noului student
            adminMedicament.GetMedicament(out nrMedicamenti);

            string optiune;
            do
            {
                Console.WriteLine("\n--------------- F A R M A C I E --------------------------");
                Console.WriteLine("\t\t\t\t\t\t\t |");
                Console.WriteLine("R. Citire informatii medicament de la tastatura \t |");
                Console.WriteLine("A. Afisarea ultimului medicament introdus \t\t |");
                Console.WriteLine("F. Afisare medicamenti din fisier\t\t\t |");
                Console.WriteLine("S. Salvare medicament in fisier \t\t\t |");
                Console.WriteLine("N. Edit cantintate la ultimului medicament \t\t |");
                Console.WriteLine("G. Afisare cantitate la ultimului medicament \t\t |");
                Console.WriteLine("T. Lab4 \t\t\t\t\t\t |");
                Console.WriteLine("X. Inchidere program \t\t\t\t\t |");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Alegeti o optiune:");
                
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "R":
                        medicamentNou = CitireStudentTastatura();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "T":
                        AfisareLab4(args);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "A":
                        AfisareMedicament(medicamentNou);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "F":
                        Medicament[] medicamenti = adminMedicament.GetMedicament(out nrMedicamenti);
                        AfisareMedicamentii(medicamenti, nrMedicamenti);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "S":
                        int idStudent = nrMedicamenti + 1;
                        medicamentNou.SetIdMedicament(idStudent);
                        //adaugare medicament in fisier
                        adminMedicament.AddMedicament(medicamentNou);
                        nrMedicamenti = nrMedicamenti + 1;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "N":
                         EditCantitate(medicamentNou);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "G":
                        AfisareCantiate(medicamentNou);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisareMedicament(Medicament medicament)
        {
            string infoStudent = string.Format("\n   id: #{0} \t| nume: {1} \t| pret: {2} |\t cantitate: {3}\n",
                   medicament.GetIdMedicament(),
                   medicament.GetNume() ?? " NECUNOSCUT ",
                   medicament.GetPret() ?? " NECUNOSCUT ",
                   medicament.GetCantitate());
           
            Console.WriteLine(infoStudent);

            
        }

        static void AfisareLab4(string[] args)
        {

            int i, j, l, ok = 0, p, k = 0;
            string[][] vector = new string[26][];
            string buf, buf1;
            string buff, buf2;
            if (args.Length == 0)
                Console.Write("command line doesnt contain any argument");
            string sir = "abcdefghijklmnopqrstuvwxyz";
            for (i = 0; i < sir.Length; i++)
            {
                ok = 0;
                for (j = 0; j < args.Length; j++)
                {
                    buf = args[j];
                    buf1 = args[j].ToLower();
                    if (sir[i] == buf1[0])
                        ok++;
                }
                if (ok > 0)
                {
                    vector[k] = new string[ok];
                    p = 0;
                    for (l = 0; l < args.Length; l++)
                    {
                        buff = args[l];
                        buf2 = args[l].ToLower();
                        if (sir[i] == buf2[0])
                        {
                            vector[k][p] = args[l];
                            p++;
                        }
                    }
                    k++;
                }


            }

            for (i = 0; i < k; i++)
            {

                for (j = 0; j < vector[i].Length; j++)

                    Console.Write("{0} ", vector[i][j]);
                Console.Write("\n");
            }
            Console.ReadKey();
        }

        public static void EditCantitate(Medicament medicament)
        {
            AfisareMedicament(medicament);
            Console.WriteLine("Introduceti noua cantiate");
            string nouCantiate = Console.ReadLine();
            medicament.setCantitae(Convert.ToInt32(nouCantiate));

        }

        public static void AfisareCantiate(Medicament medicament)
        {
            int cantitate = medicament.GetCantitate();
           Console.WriteLine("Cantitate:\n" + cantitate.ToString());

        }

        public static void AfisareMedicamentii(Medicament[] medicamenti, int nrMedicament)
        {
            Console.WriteLine("\n------------------------------ MEDICAMENTII -----------------------------");
            for (int contor = 0; contor < nrMedicament; contor++)
            {
               
                AfisareMedicament(medicamenti[contor]);
            }
            Console.WriteLine("\n-------------------------------------------------------------------------\n");
        }


        public static Medicament CitireStudentTastatura()
        {
            Console.WriteLine("Introduceti nume");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti pret");
            string pret = Console.ReadLine();

            Console.WriteLine("Introduceti cantiate");
            string cantitate = Console.ReadLine();
            int cantiateInt = Convert.ToInt32(cantitate);

            Medicament medicament = new Medicament(0, nume, pret, cantiateInt);

            return medicament;
        }
    }
}
