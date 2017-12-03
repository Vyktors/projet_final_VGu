using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    //

    class cTraitement
    {

        int nbVaisseau, nbVaisseauLeger, nbVaisseauCargo, ratioLegerCargo;
        Random nbRandom;

        cCentrePair cc = new cCentrePair();

        cFiles listeDepart = new cFiles();
        cFiles listeArrivee = new cFiles();


        public cTraitement()
        {
            nbRandom = new Random();
        }

        /*L'utilisateur décide du nombre de vaisseau léger et cargo*/
        public void selectionnerNbVaisseau()
        {
            Console.Write("Entrez le nombre de vaisseaux désiré : ");
            nbVaisseau = Convert.ToInt32(Console.ReadLine());

            ratioLegerCargo = nbRandom.Next(0, 101);
            nbVaisseauLeger = nbVaisseau * ratioLegerCargo / 100;
            nbVaisseauCargo = nbVaisseau - nbVaisseauLeger;

            Console.WriteLine("Le nombre de vaisseaus Legers à été attribué aléatoirement à : " + ratioLegerCargo + "%");
            Console.WriteLine("     " + nbVaisseauLeger + " Vaisseaux légers");
            Console.WriteLine("     " + nbVaisseauCargo + " Vaisseaux Cargo");

            Console.WriteLine("Appuyer sur une touche pour attribuer les ressources aux vaisseaux");
            Console.ReadKey();
            affecterQuantite(nbVaisseauLeger, nbVaisseauCargo);

            Console.WriteLine("Tous les vaisseaux sont chargés");

        }

        /*Créer tous les vaisseaux de départ , et affecte de façon aléatoire, la quantité de chaque matière pour chaque vaisseau*/
        private void affecterQuantite(int nombreVaissLeger, int nombreVaissCargo)
        {
            for (int i = 0; i < nombreVaissLeger; i++)
            {
                cVaisseauLeger vaisseauLeger = new cVaisseauLeger();
            }


            for (int i = 0; i < nombreVaissCargo; i++)
            {
                cVaisseauCargo vaisseauCargo = new cVaisseauCargo();

                //l.ajouterVaisseau(vaisseauCargo);
            }

        }
    }
}
