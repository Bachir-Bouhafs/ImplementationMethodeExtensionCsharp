using System;
using System.Collections.Generic;
namespace ImplementationMethodeExtensionCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var etudiants = new List<Etudiant>
            {
                new Etudiant{ nom = "Bouhafs",     prenom = "Bachir",   note = 18},
                new Etudiant{ nom = "Dupont",      prenom = "Edouard",  note = 14},
                new Etudiant{ nom = "Bonapart",    prenom = "Phillipe", note = 11},
                new Etudiant{ nom = "Landel",      prenom = "Patrice",  note = 16},
           
            };

            var listEtudiant = etudiants.Filtrer(e => e.note > 15);

            foreach(var etudiant in listEtudiant)
            {
                Console.WriteLine("{0}, {1}",etudiant.nom, etudiant.prenom);
            }
            Console.ReadLine();


        }
    }
}
