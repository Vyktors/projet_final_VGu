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
        public cTraitement()
        {
            nbRandom = new Random();
        }

        /*L'utilisateur décide du nombre de vaisseau léger et cargo*/
        public void selectionnerNbVaisseau()
        {
            Console.Write("Entrez le nombre de vaisseaux légers désiré : ");
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

        }

        /*Créer tous les vaisseaux de départ , et affecte de façon aléatoire, la quantité de chaque matière pour chaque vaisseau*/
        private void affecterQuantite(int nombreVaissLeger, int nombreVaissCargo)
        {
            
            int qtPlutonium, qtUranium, qtML, qtTerre, qtRes, qtVaisseau;

            

            qtPlutonium = 0;
            qtUranium = 0;
            qtML = 0;
            qtTerre = 0;
            qtRes = 0;

            for (int i = 0; i < nombreVaissLeger; i++)
            {
                qtVaisseau = 108;

                qtPlutonium = nbRandom.Next(1, qtVaisseau - 4);
                qtVaisseau -= qtPlutonium;


                qtUranium = nbRandom.Next(1, qtVaisseau - 3);
                qtVaisseau -= qtUranium;


                qtML = nbRandom.Next(1, qtVaisseau - 2);
                qtVaisseau -= qtML;


                qtTerre = nbRandom.Next(1, qtVaisseau - 1);
                qtVaisseau -= qtTerre;


                qtRes = nbRandom.Next(1, qtVaisseau);
                qtVaisseau -= qtRes;

            cVaisseauLeger vaisseauLeger = new cVaisseauLeger(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);

            }



            for (int i = 0; i < nombreVaissCargo; i++)
            {
                qtVaisseau = 367;

                qtPlutonium = nbRandom.Next(1, qtVaisseau - 4);
                qtVaisseau -= qtPlutonium;


                qtUranium = nbRandom.Next(1, qtVaisseau - 3);
                qtVaisseau -= qtUranium;


                qtML = nbRandom.Next(1, qtVaisseau - 2);
                qtVaisseau -= qtML;


                qtTerre = nbRandom.Next(1, qtVaisseau - 1);
                qtVaisseau -= qtTerre;


                qtRes = nbRandom.Next(1, qtVaisseau);
                qtVaisseau -= qtRes;

                cVaisseauCargo vaisseauCargo = new cVaisseauCargo(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);
            }

        }
    }
}
