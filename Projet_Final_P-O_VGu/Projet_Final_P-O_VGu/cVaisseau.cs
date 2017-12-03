using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cVaisseau
    {
        cVaisseau vaisseauSuivant, vaisseauPrecedent;
        public int reste;
        public Random nbRandom;
        public cVaisseau()
        {
            nbRandom = new Random();

            attribuerRessources();
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


        //Attribu les ressouces de façon aléatoire au vaisseau
        protected void attribuerRessources()
        {

            int ratio;
            int qtAjoute;

            reste = capaciteVaisseau - 5;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            qtPlutonium = 1 + qtAjoute ;
            reste -= qtAjoute;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            qtUranium = 1 + qtAjoute;
            reste -= qtAjoute;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            qtMetauxLourds = 1 + qtAjoute;
            reste -= qtAjoute;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            qtTerreContaminee = 1 + qtAjoute;
            reste -= qtAjoute;

            qtResidusCombusFos = 1 + reste;
        }


        //Accesseurs
        public cVaisseau VaisseauSuivant
        {
            get { return vaisseauSuivant; }
            set { vaisseauSuivant = value; }
        }



        public cVaisseau VaisseauPrecedent
        {
            get { return vaisseauPrecedent; }
            set { vaisseauPrecedent = value; }
        }

    }
}
