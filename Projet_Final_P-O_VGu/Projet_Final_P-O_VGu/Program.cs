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
            cFiles listeDepart = new cFiles();
            cFilesCentre listeCentreDeTri = new cFilesCentre();
            cTraitement t = new cTraitement();
            cCentrePair centreTest = new cCentrePair(0);
            cVaisseau tempVaisseau;


            //Demande à l'utilisateur le nombre de vaisseau, les créer et les stocks dans listeDépart

            t.selectionnerNbVaisseau(listeDepart);

            t.selectionnerNbCentre(listeCentreDeTri);

            do
            {

                
                
            }while(listeDepart.cptVaisseau > 0);

            
            void transferer(cCentreTri prochainCentre)
            {
                //Si la file d'arrivée du centre de tri n'est pas à sa capactié maximum de vaisseau, en ajouter
                if (prochainCentre.fileArrivee.cptVaisseau < prochainCentre.capaciteFile)
                {
                    tempVaisseau = prochainCentre.CentrePrecedent.fileDepart.retirerVaisseauFile();
                    prochainCentre.fileArrivee.ajouterVaisseau(tempVaisseau);
                }
                //Décharger un vaisseau
                if (prochainCentre.fileArrivee.cptVaisseau >= 1)
                {
                    prochainCentre.dechargerVaisseau(centreTest.fileArrivee.finFile);
                    tempVaisseau = prochainCentre.fileArrivee.retirerVaisseauFile();
                    prochainCentre.fileDepart.ajouterVaisseau(tempVaisseau);
                }
                transferer(prochainCentre.CentreSuivant);
            }




            Console.ReadKey();
        }
    }
}
