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
            Random rndQtMatiere;
            int qtPlutonium, qtUranium, qtML, qtTerre, qtRes, matiereRemplie, qtVaisseau;

            rndQtMatiere = new Random();

            qtPlutonium = 0;
            qtUranium = 0;
            qtML = 0;
            qtTerre = 0;
            qtRes = 0;

            for (int i = 0; i < nombreVaissLeger; i++)
            {
                qtVaisseau = 108;
                matiereRemplie = 0;

                while (qtVaisseau > 0 && matiereRemplie != 5)
                {
                    qtVaisseau = 108;
                    matiereRemplie = 0;

                    qtPlutonium = rndQtMatiere.Next(1,109);
                    if (qtPlutonium < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtPlutonium;


                    qtUranium = rndQtMatiere.Next(1,109);
                    if (qtUranium < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtUranium;

                    qtML = rndQtMatiere.Next(1, 109);
                    if (qtML < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtML;

                    qtTerre = rndQtMatiere.Next(1, 109);
                    if (qtTerre < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtTerre;

                    qtRes = rndQtMatiere.Next(1, 109);
                    if (qtRes < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtRes;

                }

                cVaisseauLeger vaisseauLeger = new cVaisseauLeger(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);

            }

            for (int i = 0; i < nombreVaissCargo; i++)
            {
                qtVaisseau = 367;
                matiereRemplie = 0;

                while (qtVaisseau > 0 && matiereRemplie != 5)
                {
                    qtVaisseau = 367;
                    matiereRemplie = 0;

                    qtPlutonium = rndQtMatiere.Next(1, 368);
                    if (qtPlutonium < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtPlutonium;


                    qtUranium = rndQtMatiere.Next(1, 368);
                    if (qtUranium < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtUranium;

                    qtML = rndQtMatiere.Next(1, 368);
                    if (qtML < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtML;

                    qtTerre = rndQtMatiere.Next(1, 368);
                    if (qtTerre < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtTerre;

                    qtRes = rndQtMatiere.Next(1, 368);
                    if (qtRes < 0)
                    {
                        matiereRemplie++;
                    }
                    qtVaisseau -= qtRes;

                }

                cVaisseauCargo vaisseauCargo = new cVaisseauCargo(qtPlutonium, qtUranium, qtML, qtTerre, qtRes);
            }

        }
    }
}
