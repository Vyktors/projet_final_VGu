using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    interface iCentreDeTri
    {
        /*Capacité de vaisseau dans la file de départ et d'arrivée*/
        int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        int capacitePlutonium { get; set; }
        cPlutonium qtPlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        int capaciteUranium { get; set; }
        cUranium qtUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        int capaciteMetauxLourds { get; set; }
        cMetauxLourds qtMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        int capaciteTerreContaminee { get; set; }
        cTerreCont qtTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        int capaciteResidusCombusFos { get; set; }
        cResidusCombusFos qtResidusCombusFos { get; set; }

        cFiles fileArrivee { get; set; }

        cFiles fileDepart { get; set; }


        void chargerVaisseau();

        void dechargerVaisseau(cVaisseau v);

    }
}
