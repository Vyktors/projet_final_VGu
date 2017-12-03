using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    interface iCentreDeTri
    {
        /*Nombre maximum de vaisseaux pouvant être contenu dans une file de départ/arrivée*/
        int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        int capacitePlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        int capaciteUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        int capaciteMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        int capaciteTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        int capaciteResidusCombusFos { get; set; }

        int qtPlutonium { get; set; }

        int qtUranium { get; set; }

        int qtMetauxLourds { get; set; }

        int qtTerreContaminee { get; set; }

        int qtResidusCombusFos { get; set; }

        void chargerVaisseau(cVaisseau v);

        void dechargerVaisseau(cVaisseau v);

    }
}
