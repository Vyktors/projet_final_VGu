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
            capaciteFileDepart = 45;
            capaciteFileArrivee = 45;
        }

        public virtual int capaciteFileDepart { get; set; }

        public virtual int capaciteFileArrivee { get; set; }

    }
}
