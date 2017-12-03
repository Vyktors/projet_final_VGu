using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cVaisseauCargo:cVaisseau
    {
        public cVaisseauCargo() : base()
        {
            capaciteVaisseau = 367;
            attribuerRessources();
        }
    }
}
