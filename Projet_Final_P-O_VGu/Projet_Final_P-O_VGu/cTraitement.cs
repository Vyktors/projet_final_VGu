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

        int nbVaisseau;
        int nbCentreDeTri;

        public cTraitement()
        {
            nbVaisseau = -1;
            nbCentreDeTri = -1;
        }

        /*L'utilisateur décide du nombre de vaisseau léger et cargo*/
        public void selectionnerNbVaisseau(cFiles lstDepart)
        {        
            //Empêche l'utilisateur de rentrez des lettre et ou un nombre négatif ou fractionnaire
            do
            {
                try
                {
                    Console.Write("Entrez le nombre de vaisseaux désiré : "); ;
                    nbVaisseau = Convert.ToInt32(Console.ReadLine());
                    if(nbVaisseau < 0)
                    {
                        Console.WriteLine("Veuillez entrer un nombre positif\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer un nombre valide\n");
                }
            } while (nbVaisseau < 0);           

            Console.WriteLine("Appuyer sur une touche pour attribuer les ressources aux vaisseaux");
            Console.ReadKey();
            affecterQuantite(nbVaisseau, lstDepart);
            Console.WriteLine("Tous les vaisseaux sont chargés");

        }

        public void selectionnerNbCentre(cFilesCentre lstCentreTri)
        {
            cCentreTri centre;
            ////Empêche l'utilisateur de rentrez des lettre et ou un nombre négatif ou fractionnaire
            do
            {
                try
                {
                    Console.Write("Entrez le nombre de centre de tri désiré : "); ;
                    nbCentreDeTri = Convert.ToInt32(Console.ReadLine());
                    if (nbCentreDeTri < 0)
                    {
                        Console.WriteLine("Veuillez entrer un nombre positif\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer un nombre valide\n");
                }
            } while (nbCentreDeTri < 0);


            for (int i = 1 ; i <= nbCentreDeTri - 1; i++)
            {
                if(i%2 == 1)
                {
                    centre = new cCentreImpair(i);
                }
                else
                {
                    centre = new cCentrePair(i);
                }
                lstCentreTri.ajouterCentre(centre);
            }
        }

        /*Créer tous les vaisseaux de départ , et affecte de façon aléatoire, la quantité de chaque matière pour chaque vaisseau*/
        private void affecterQuantite(int nombreVaiss, cFiles listeDepart)
        {
            Random nbRandom = new Random();
            int chance;
            cVaisseau newVaisseau;
            
            for (int i = 0; i < nombreVaiss; i++)
            {
                chance = nbRandom.Next(0, 2);
                if(chance % 2 == 0)
                {
                    newVaisseau = new cVaisseauLeger();
                }
                else
                {
                    newVaisseau = new cVaisseauCargo(); 
                }
                listeDepart.ajouterVaisseau(newVaisseau);
            }


        }


        /* Transfert vaissau d'une file à une autre */
        public void transfert(cVaisseau vaisseau)
        {

        }


    }
}
