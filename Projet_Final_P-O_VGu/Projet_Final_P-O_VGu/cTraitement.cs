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
        

        



        public cTraitement()
        {
            
        }

        /*L'utilisateur décide du nombre de vaisseau léger et cargo*/
        public void selectionnerNbVaisseau(cFiles lstDepart)
        {
            Console.Write("Entrez le nombre de vaisseaux désiré : ");
            nbVaisseau = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Appuyer sur une touche pour attribuer les ressources aux vaisseaux");
            Console.ReadKey();
            affecterQuantite(nbVaisseau, lstDepart);

            Console.WriteLine("Tous les vaisseaux sont chargés");

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
