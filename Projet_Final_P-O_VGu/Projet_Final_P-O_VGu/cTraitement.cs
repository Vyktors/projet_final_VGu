using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cTraitement
    {
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
            bool qtPleine;
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
                qtPleine = false;
                qtVaisseau = 108;

                do
                {
                    qtVaisseau = 108;

                    qtPlutonium = rndQtMatiere.Next(1, 109);
                    qtVaisseau -= qtPlutonium;


                    qtUranium = rndQtMatiere.Next(1, 109);
                    qtVaisseau -= qtUranium;


                    qtML = rndQtMatiere.Next(1, 109);
                    qtVaisseau -= qtML;


                    qtTerre = rndQtMatiere.Next(1, 109);
                    qtVaisseau -= qtTerre;


                    qtRes = rndQtMatiere.Next(1, 109);
                    qtVaisseau -= qtRes;

                    if (qtVaisseau == 0)
                    {
                        qtPleine = true;
                    }

                }
                while (qtPleine == false);

                cVaisseauLeger vaisseauLeger = new cVaisseauLeger(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);

            }



            for (int i = 0; i < nombreVaissCargo; i++)
            {
                qtPleine = false;
                qtVaisseau = 367;


                do
                {
                    qtVaisseau = 367;

                    qtPlutonium = rndQtMatiere.Next(1, 368);
                    qtVaisseau -= qtPlutonium;


                    qtUranium = rndQtMatiere.Next(1, 368);
                    qtVaisseau -= qtUranium;


                    qtML = rndQtMatiere.Next(1, 368);
                    qtVaisseau -= qtML;


                    qtTerre = rndQtMatiere.Next(1, 368);
                    qtVaisseau -= qtTerre;


                    qtRes = rndQtMatiere.Next(1, 368);
                    qtVaisseau -= qtRes;


                    if (qtVaisseau == 0)
                    {
                        qtPleine = true;
                    }

                }
                while (qtPleine == false);

                cVaisseauCargo vaisseauCargo = new cVaisseauCargo(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);
            }

        }
    }
}
