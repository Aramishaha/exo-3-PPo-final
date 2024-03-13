using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_2_PPo
{
    class Program
    {
        static void Main(string[] args)
        {

            Compte c1 = new Compte(1, "Aramis", "Mohamed Aramis", 0);
            c1.CrediterCompte(2500);
            c1.DebiterCompte(1000);
            Console.WriteLine("Numero : " + c1.GetNumero());
            Console.WriteLine("Nom : " + c1.GetNom());
            Console.WriteLine("Prenom : " + c1.GetPrenom());
            Console.WriteLine("Solde : " + c1.GetSolde());

            Console.ReadKey();
        }
        

    }
}
