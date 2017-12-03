using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentreImpair:iCentreDeTri
    {
        
        public cCentreImpair()
        {
            qtPlutonium = new cPlutonium();
            qtUranium = new cUranium();
            qtMetauxLourds = new cMetauxLourds();
            qtTerreContaminee = new cTerreCont();
            qtResidusCombusFos = new cResidusCombusFos();

            capaciteFile = 45;
            capacitePlutonium = 3067;
            capaciteUranium = 2456;
            capaciteMetauxLourds = 561;
            capaciteTerreContaminee = 2658;
            capaciteResidusCombusFos = 8234;

            fileDepart = new cFiles();
            fileArrivee = new cFiles();
        }

        /*Capacité de vaisseau dans la file de départ et d'arrivée*/
        public virtual int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        public virtual int capacitePlutonium { get; set; }
        public virtual cPlutonium qtPlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        public virtual int capaciteUranium { get; set; }
        public virtual cUranium qtUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        public virtual int capaciteMetauxLourds { get; set; }
        public virtual cMetauxLourds qtMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        public virtual int capaciteTerreContaminee { get; set; }
        public virtual cTerreCont qtTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        public virtual int capaciteResidusCombusFos { get; set; }
        public virtual cResidusCombusFos qtResidusCombusFos { get; set; }

        public cFiles fileDepart { get; set; }

        public cFiles fileArrivee { get; set; }

        public void chargerVaisseau()
        {

        }

        public void dechargerVaisseau(cVaisseau vaisseau)
        {

        }
    }
}
