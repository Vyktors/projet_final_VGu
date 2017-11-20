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

        /*Capacité de vaisseau dans la file de départ*/
        public virtual int capaciteFileDepart { get; set; }

        /*Capacité de vaisseau dans la file d'arrivée*/
        public virtual int capaciteFileArrivee { get; set; }

    }
}
