using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentrePair:iCentreDeTri
    {

        public cCentrePair()
        {
            capaciteFileDepart = 30;
            capaciteFileArrivee = 30;
        }

        public virtual int capaciteFileDepart { get; set; }

        public virtual int capaciteFileArrivee { get; set; }

    }
}
