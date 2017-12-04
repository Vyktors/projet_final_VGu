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

            plutonium = new cPlutonium();
            uranium = new cUranium();
            metauxLourds = new cMetauxLourds();
            terreContaminee = new cTerreCont();
            residusCombusFos = new cResidusCombusFos();


            attribuerRessources();
        }

        /*Capacité du vaisseau en m3*/
        public int capaciteVaisseau { get; set; }

        public int qtMatiereVaisseau { get; set; }

        /*Quantité de plutonium*/
        public cPlutonium plutonium { get; set; }

        /*Quantité d'uranium*/
        public cUranium uranium { get; set; }

        /*Quantité de métaux lourds*/
        public cMetauxLourds metauxLourds { get; set; }

        /*Quantité de terre contaminée*/
        public cTerreCont terreContaminee { get; set; }

        /*Quantité de résidus de combustible fossile*/
        public cResidusCombusFos residusCombusFos { get; set; }

        //Attribu les ressouces de façon aléatoire au vaisseau
        protected void attribuerRessources()
        {

            int ratio;
            int qtAjoute;

            reste = capaciteVaisseau - 5;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            plutonium.quantite = 1 + qtAjoute ;
            reste -= qtAjoute;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            uranium.quantite = 1 + qtAjoute;
            reste -= qtAjoute;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            metauxLourds.quantite = 1 + qtAjoute;
            reste -= qtAjoute;

            ratio = nbRandom.Next(0, 101);
            qtAjoute = (reste * ratio / 100);
            terreContaminee.quantite = 1 + qtAjoute;
            reste -= qtAjoute;

            residusCombusFos.quantite = 1 + reste;
        }

        public void verifierQuantiteMatiere()
        {
            qtMatiereVaisseau = plutonium.quantite + uranium.quantite + metauxLourds.quantite + terreContaminee.quantite + residusCombusFos.quantite;
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
