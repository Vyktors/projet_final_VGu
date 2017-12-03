using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cFiles
    {

        cVaisseau ancre;
        
        


        public cFiles()
        {
            ancre = null;
            finFile = null;
            cptVaisseau = 0;
        }

        public void ajouterVaisseauDebutFile(cVaisseau vaisseau)
        {
            if (ancre == null)
            {
                vaisseau.VaisseauSuivant = ancre;
                ancre = finFile = vaisseau;
            }
            else
            {
                vaisseau.VaisseauSuivant = ancre;
                ancre.VaisseauPrecedent = vaisseau;
                ancre = vaisseau;

            }

            cptVaisseau++;
        }

        public void ajouterVaisseauFinFile(cVaisseau vaisseau)
        {
            finFile.VaisseauSuivant = vaisseau;
            vaisseau.VaisseauPrecedent = finFile;
            finFile = vaisseau;

            if (cptVaisseau == 0)
            {
                ancre = vaisseau;
            }

            cptVaisseau++;
        }

        public void ajouterVaisseau(cVaisseau vaisseau)
        {
            cVaisseau vaisseauActuel, vaisseauTemp;

            vaisseauActuel = ancre;
            vaisseauTemp = null;

            if (cptVaisseau == 0)
            {
                ajouterVaisseauDebutFile(vaisseau);
            }
            else
            {
                while (vaisseauActuel != null)
                {
                    if (ancre == vaisseauActuel)
                    {
                        ajouterVaisseauDebutFile(vaisseau);
                        break;
                    }
                    else
                    {
                        vaisseau.VaisseauPrecedent = vaisseauActuel.VaisseauPrecedent;
                        vaisseau.VaisseauSuivant = vaisseauActuel;
                        vaisseauActuel.VaisseauPrecedent = vaisseau;
                        vaisseauTemp.VaisseauSuivant = vaisseau;
                        cptVaisseau++;
                        break;
                    }
                }
            }
        }

        public cVaisseau retirerVaisseauFile()
        {
            cVaisseau vaisseauRetire;

            vaisseauRetire = ancre;
            ancre.VaisseauPrecedent = null;
            ancre = vaisseauRetire.VaisseauSuivant;

            cptVaisseau--;

            if (cptVaisseau == 0)
            {
                finFile = ancre;
            }

            return vaisseauRetire;
        }

        public cVaisseau finFile { get; set; }

        public int cptVaisseau { get; set; }
    }
}
