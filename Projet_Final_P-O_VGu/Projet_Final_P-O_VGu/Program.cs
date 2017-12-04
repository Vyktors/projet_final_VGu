using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class Program
    {
        static void Main(string[] args)
        {

            cFilesCentre listeCentreDeTri = new cFilesCentre();
            cTraitement t = new cTraitement();
            cCentrePair centreDepart = new cCentrePair(0);
            cVaisseau tempVaisseau;


            //Demande à l'utilisateur le nombre de vaisseau, les créer et les stocks dans listeDépart
            

            t.selectionnerNbVaisseau(centreDepart.fileDepart);

            listeCentreDeTri.ajouterCentre(centreDepart);
            t.selectionnerNbCentre(listeCentreDeTri);

            do
            {

                transferer(centreDepart.CentrePrecedent);                

            }while(centreDepart.fileDepart.cptVaisseau > 0);

            
            void transferer(cCentreTri prochainCentre)
            {
                //Si la file d'arrivée du centre de tri n'est pas à sa capactié maximum de vaisseau, en ajouter
                if (prochainCentre.fileArrivee.cptVaisseau < prochainCentre.capaciteFile)
                {
                    tempVaisseau = prochainCentre.CentreSuivant.fileDepart.retirerVaisseauFile();
                    prochainCentre.fileArrivee.ajouterVaisseau(tempVaisseau);
                }
                //Décharger un vaisseau
                if (prochainCentre.fileArrivee.cptVaisseau >= 1)
                {
                    //Décaharge le vaisseau
                    prochainCentre.dechargerVaisseau(prochainCentre.fileArrivee.finFile);

                    //Transfère le vaisseau vide de la file d'arrivée à la file de départ
                    tempVaisseau = prochainCentre.fileArrivee.retirerVaisseauFile();
                    prochainCentre.fileDepart.ajouterVaisseau(tempVaisseau);
                }


                if(prochainCentre.numCentre == listeCentreDeTri.cptCentre -1 && centreDepart.fileDepart.cptVaisseau == 0)
                {
                    Console.WriteLine("Dernier Centre");
                    Console.ReadKey();
                }
                else if (prochainCentre.CentrePrecedent != null)
                {
                    transferer(prochainCentre.CentrePrecedent);
                }
                else return;
                
            }




            Console.ReadKey();
        }
    }
}
