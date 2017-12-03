using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cTraitement
    {

        cListe listeDepart = new cListe();
        cListe listeArrivee = new cListe();
        int nbVaisseauLeger, nbVaisseauCargo;

        public cTraitement()
        {

        }

        /*L'utilisateur décide du nombre de vaisseau léger et cargo*/
        public void selectionnerNbVaisseau()
        {
            Console.Write("Entrez le nombre de vaisseaux légers désiré : ");
            nbVaisseauLeger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez le nombre de vaisseaux cargos désiré : ");
            nbVaisseauCargo = Convert.ToInt32(Console.ReadLine());

            affecterQuantite(nbVaisseauLeger, nbVaisseauCargo);

        }

        /*Affecte, da façon aléatoire, la quantité de chaque matière pour chaque vaisseau*/
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


                qtRes = rndQtMatiere.Next(qtVaisseau);
                qtVaisseau -= qtRes;

                cVaisseauLeger vaisseauLeger = new cVaisseauLeger(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);

                l.ajouterVaisseau(vaisseauLeger);

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


                qtRes = rndQtMatiere.Next(qtVaisseau);
                qtVaisseau -= qtRes;

                cVaisseauCargo vaisseauCargo = new cVaisseauCargo(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);

                l.ajouterVaisseau(vaisseauCargo);
            }

        }
    }
}
