using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cFilesCentre
    {
        cCentreTri ancre;


        public cFilesCentre()
        {
            ancre = null;
            finFile = null;
            cptCentre = 0;
        }

        private void ajouterCentreDebutFile(cCentreTri centre)
        {
            if (ancre == null)
            {
                centre.CentreSuivant = ancre;
                ancre = finFile = centre;
            }
            else
            {
                centre.CentreSuivant = ancre;
                ancre.CentrePrecedent = centre;
                ancre = centre;

            }

            cptCentre++;
        }

        private void ajouterCentreFinFile(cCentreTri centre)
        {
            finFile.CentreSuivant = centre;
            centre.CentrePrecedent = finFile;
            finFile = centre;

            if (cptCentre == 0)
            {
                ancre = centre;
            }

            cptCentre++;
        }

        public void ajouterCentre(cCentreTri centre)
        {
            cCentreTri centreActuel, centreTemp;

            centreActuel = ancre;
            centreTemp = null;

            if (cptCentre == 0)
            {
                ajouterCentreDebutFile(centre);
            }
            else
            {
                while (centreActuel != null)
                {
                    if (ancre == centreActuel)
                    {
                        ajouterCentreDebutFile(centre);
                        break;
                    }
                    else
                    {
                        centre.CentrePrecedent = centreActuel.CentrePrecedent;
                        centre.CentreSuivant= centreActuel;
                        centreActuel.CentrePrecedent = centre;
                        centreTemp.CentreSuivant= centre;
                        cptCentre++;
                        break;
                    }
                }
            }
        }

        public cCentreTri retirerCentreFile()
        {
            cCentreTri centreRetire;

            centreRetire = ancre;
            ancre.CentrePrecedent = null;
            ancre = centreRetire.CentreSuivant;

            cptCentre--;

            if (cptCentre== 0)
            {
                finFile = ancre;
            }

            return centreRetire;
        }

        public cCentreTri finFile { get; set; }

        public int cptCentre { get; set; }
    }
}
