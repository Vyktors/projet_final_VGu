using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cMatiere
    {

        public cMatiere()
        {
            tempsDechargement = 0;
            quantite = 0;
        }

        /*Nom de la matière*/
        public string Nom { get; set; }

        /*Temps de déchargement de  la matière en m3/secondes*/
        public int tempsDechargement { get; set; }

        /*Quantité en m3*/
        public int quantite { get; set; }





    }
}
