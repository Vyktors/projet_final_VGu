using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentrePair:cCentreTri
    {

        public cCentrePair(int nb) : base(nb)
        {

            capaciteFile = 30;
            capacitePlutonium= 1005;
            capaciteUranium = 857;
            capaciteMetauxLourds = 3456;
            capaciteTerreContaminee = 457;
            capaciteResidusCombusFos = 639;

            
        }

        

    }
}
