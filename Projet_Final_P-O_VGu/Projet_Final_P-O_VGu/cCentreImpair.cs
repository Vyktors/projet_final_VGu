using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentreImpair:iCentreDeTri
    {
        cFiles fileDepart = new cFiles();
        cFiles fileArrivee = new cFiles();
        public cCentreImpair()
        {
            capaciteFile = 45;
            capacitePlutonium = 3067;
            capaciteUranium = 2456;
            capaciteMetauxLourds = 561;
            capaciteTerreContaminee = 2658;
            capaciteResidusCombusFos = 8234;
        }

        /*Capacité de vaisseau dans la file de départ et d'arrivée*/
        public virtual int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        public virtual int capacitePlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        public virtual int capaciteUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        public virtual int capaciteMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        public virtual int capaciteTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        public virtual int capaciteResidusCombusFos { get; set; }

        public virtual int qtPlutonium { get; set; }

        public virtual int qtUranium { get; set; }

        public virtual int qtMetauxLourds { get; set; }

        public virtual int qtTerreContaminee { get; set; }

        public virtual int qtResidusCombusFos { get; set; }

        public void chargerVaisseau(cVaisseau vaisseau)
        {

        }

        public void dechargerVaisseau(cVaisseau vaisseau)
        {

        }
    }
}
