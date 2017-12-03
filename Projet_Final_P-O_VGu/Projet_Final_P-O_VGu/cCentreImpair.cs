using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentreImpair:cCentreTri
    {
        
        public cCentreImpair(int nb):base( nb)
        {
            capaciteFile = 45;
            capacitePlutonium = 3067;
            capaciteUranium = 2456;
            capaciteMetauxLourds = 561;
            capaciteTerreContaminee = 2658;
            capaciteResidusCombusFos = 8234;
        }


    }
}
