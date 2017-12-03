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
            cTraitement t = new cTraitement();
            cCentrePair centreTest = new cCentrePair();
            cVaisseau tempVaisseau;


            //Demande à l'utilisateur le nombre de vaisseau, les créer et les stocks dans listeDépart

            t.selectionnerNbVaisseau(listeDepart);

            do
            {
                //Si la file d'arrivée du centre de tri n'est pas à sa capactié maximum de vaisseau, en ajouter
                if(centreTest.fileArrivee.cptVaisseau < centreTest.capaciteFile)
                {
                    tempVaisseau = listeDepart.retirerVaisseauFile();
                    centreTest.fileArrivee.ajouterVaisseau(tempVaisseau);
                }
                //Décharger un vaisseau
                if (centreTest.fileArrivee.cptVaisseau >= 1)
                {
                    centreTest.dechargerVaisseau(centreTest.fileArrivee.finFile);
                    tempVaisseau = centreTest.fileArrivee.retirerVaisseauFile();
                    centreTest.fileDepart.ajouterVaisseau(tempVaisseau);
                }
                
            }while(listeDepart.cptVaisseau > 0);

            





            Console.ReadKey();
        }
    }
}
