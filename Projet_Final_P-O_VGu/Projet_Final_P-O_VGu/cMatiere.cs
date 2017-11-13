using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cMatiere
    {

        public cMatiere(string _nom, int _tempsDechargement)
        {
            Nom = _nom;
            tempsDechargement = _tempsDechargement;
        }

        /*Nom de la matière*/
        public string Nom { get; set; }

        /*Temps de déchargement de  la matière en m3/secondes*/
        int tempsDechargement { get; set; }





    }
}
