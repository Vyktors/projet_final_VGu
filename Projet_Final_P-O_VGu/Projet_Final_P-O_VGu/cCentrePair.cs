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

        /*Capacité de vaisseau dans la file de départ*/
        public virtual int capaciteFileDepart { get; set; }

        /*Capacité de vaisseau dans la file d'arrivée*/
        public virtual int capaciteFileArrivee { get; set; }

    }
}
