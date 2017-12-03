using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cVaisseau
    {

        public cVaisseau()
        {

        }

        /*Capacité du vaisseau en m3*/
        public int capaciteVaisseau { get; set; }

        /*Quantité de plutonium*/
        public int qtPlutonium { get; set; }

        /*Quantité d'uranium*/
        public int qtUranium { get; set; }

        /*Quantité de métaux lourds*/
        public int qtMetauxLourds { get; set; }

        /*Quantité de terre contaminée*/
        public int qtTerreContaminee { get; set; }

        /*Quantité de résidus de combustible fossile*/
        public int qtResidusCombusFos { get; set; }



    }
}
