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
        int nbVaisseauLeger, nbVaisseauCargo;

        public cTraitement()
        {

        }

        /*L'utilisateur décide du nombre de vaisseau léger et cargo*/
        public void selectionnerNbVaisseau()
        {
            Console.Write("Entrez le nombre de vaisseaux légers désiré (Le ratio vaisseau leger/ vaisseau cargo est de 1:1): ");
            nbVaisseauLeger = Convert.ToInt32(Console.ReadLine())/2;
            nbVaisseauCargo = nbVaisseauLeger;

            affecterQuantite(nbVaisseauLeger, nbVaisseauCargo);

        }

        /*Créer tous les vaisseaux de départ , et affecte de façon aléatoire, la quantité de chaque matière pour chaque vaisseau*/
        private void affecterQuantite(int nombreVaissLeger, int nombreVaissCargo)
        {
            Random rndQtMatiere;
            int qtPlutonium, qtUranium, qtML, qtTerre, qtRes, qtVaisseau;

            rndQtMatiere = new Random();

            qtPlutonium = 0;
            qtUranium = 0;
            qtML = 0;
            qtTerre = 0;
            qtRes = 0;

            for (int i = 0; i < nombreVaissLeger; i++)
            {
                qtVaisseau = 108;

                qtPlutonium = rndQtMatiere.Next(1, qtVaisseau - 4);
                qtVaisseau -= qtPlutonium;


                qtUranium = rndQtMatiere.Next(1, qtVaisseau - 3);
                qtVaisseau -= qtUranium;


                qtML = rndQtMatiere.Next(1, qtVaisseau - 2);
                qtVaisseau -= qtML;


                qtTerre = rndQtMatiere.Next(1, qtVaisseau - 1);
                qtVaisseau -= qtTerre;


                qtRes = rndQtMatiere.Next(1, qtVaisseau);
                qtVaisseau -= qtRes;

            cVaisseauLeger vaisseauLeger = new cVaisseauLeger(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);

            }



            for (int i = 0; i < nombreVaissCargo; i++)
            {
                qtVaisseau = 367;

                qtPlutonium = rndQtMatiere.Next(1, qtVaisseau - 4);
                qtVaisseau -= qtPlutonium;


                qtUranium = rndQtMatiere.Next(1, qtVaisseau - 3);
                qtVaisseau -= qtUranium;


                qtML = rndQtMatiere.Next(1, qtVaisseau - 2);
                qtVaisseau -= qtML;


                qtTerre = rndQtMatiere.Next(1, qtVaisseau - 1);
                qtVaisseau -= qtTerre;


                qtRes = rndQtMatiere.Next(1, qtVaisseau);
                qtVaisseau -= qtRes;

                cVaisseauCargo vaisseauCargo = new cVaisseauCargo(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);
            }

        }
    }
}
