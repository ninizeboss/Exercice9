/**
Créer un nouveau projet Exercice9.

Le programme doit permettre de saisir une note en contrôlant que la valeur saisie est bien entre 0 et 20. La saisie est redemandée jusqu’à ce qu’une note correcte soit saisie. Au final, il faudra afficher la note correcte saisie.
 */

using System;

namespace Exercice9
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Appel de la méthode de saisie de la note
            int note = SaisirNote();

            // Affichage du résultat
            AfficherResultat(note);

            Console.ReadLine();
        }

        // Méthode pour la saisie de la note avec contrôle
        public static int SaisirNote()
        {
            int note;

            do
            {
                Console.Write("Saisir la note entre 0 et 20 : ");
                note = int.Parse(Console.ReadLine());
            } while (!EstNoteValide(note)); // Tant que la note n'est pas valide

            return note;
        }

        // Méthode pour vérifier si la note est valide (comprise entre 0 et 20)
        public static bool EstNoteValide(int note)
        {
            return note >= 0 && note <= 20;
        }

        // Méthode pour l'affichage du résultat
        public static void AfficherResultat(int note)
        {
            Console.WriteLine("Note saisie : " + note);
        }
    }
}






