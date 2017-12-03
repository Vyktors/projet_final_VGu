using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentreTri
    {
        cCentreTri centreSuivant, centrePrecedent;
        public cCentreTri()
        {
            qtPlutonium = new cPlutonium();
            qtUranium = new cUranium();
            qtMetauxLourds = new cMetauxLourds();
            qtTerreContaminee = new cTerreCont();
            qtResidusCombusFos = new cResidusCombusFos();

            fileDepart = new cFiles();
            fileArrivee = new cFiles();

        }

        /*Capacité de vaisseau dans la file de départ et d'arrivée*/
        public virtual int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        public virtual int capacitePlutonium { get; set; }
        public virtual cPlutonium qtPlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        public virtual int capaciteUranium { get; set; }
        public virtual cUranium qtUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        public virtual int capaciteMetauxLourds { get; set; }
        public virtual cMetauxLourds qtMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        public virtual int capaciteTerreContaminee { get; set; }
        public virtual cTerreCont qtTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        public virtual int capaciteResidusCombusFos { get; set; }
        public virtual cResidusCombusFos qtResidusCombusFos { get; set; }

        public cFiles fileDepart { get; set; }

        public cFiles fileArrivee { get; set; }

        public void chargerVaisseau()
        {

        }


        public void dechargerVaisseau(cVaisseau vaisseau)
        {
            int qtRestante;

            qtRestante = 0;

            //Si il reste de l'espace dans le centre de tri pour du Plutonium
            if (qtPlutonium.quantite + vaisseau.plutonium.quantite < capacitePlutonium)
            {
                qtPlutonium.quantite += vaisseau.plutonium.quantite;
                vaisseau.plutonium.quantite -= vaisseau.plutonium.quantite;
            }
            else
            {
                Console.WriteLine("Le centre de tri est rempli de Plutonium");
                qtRestante = capacitePlutonium - qtPlutonium.quantite;

                qtPlutonium.quantite += qtRestante;

                vaisseau.plutonium.quantite -= qtRestante;

                chargerVaisseau();

                qtPlutonium.quantite += vaisseau.plutonium.quantite;

                vaisseau.plutonium.quantite -= vaisseau.plutonium.quantite;

            }

            //Si il reste de l'espace dans le centre de tri pour de l'uranium
            if (qtUranium.quantite + vaisseau.uranium.quantite < capaciteUranium)
            {
                qtUranium.quantite += vaisseau.uranium.quantite;
                vaisseau.uranium.quantite -= vaisseau.uranium.quantite;
            }
            else
            {
                Console.WriteLine("Le centre de tri est rempli de Uranium");
                qtRestante = capaciteUranium - qtUranium.quantite;

                qtUranium.quantite += qtRestante;

                vaisseau.uranium.quantite -= qtRestante;

                chargerVaisseau();

                qtUranium.quantite += vaisseau.uranium.quantite;

                vaisseau.uranium.quantite -= vaisseau.uranium.quantite;
            }

            //Si il reste de l'espace dans le centre de tri pour des Métaux lourds
            if (qtMetauxLourds.quantite + vaisseau.metauxLourds.quantite < capaciteMetauxLourds)
            {
                qtMetauxLourds.quantite += vaisseau.metauxLourds.quantite;
                vaisseau.metauxLourds.quantite -= vaisseau.metauxLourds.quantite;
            }
            else
            {
                Console.WriteLine("Le centre de tri est rempli de Metaux Lourds");
                qtRestante = capaciteMetauxLourds - qtMetauxLourds.quantite;

                qtMetauxLourds.quantite += qtRestante;

                vaisseau.metauxLourds.quantite -= qtRestante;

                chargerVaisseau();

                qtMetauxLourds.quantite += vaisseau.metauxLourds.quantite;

                vaisseau.metauxLourds.quantite -= vaisseau.metauxLourds.quantite;
            }

            //Si il reste de l'espace dans le centre de tri pour de la terre contaminee
            if (qtTerreContaminee.quantite + vaisseau.terreContaminee.quantite < capaciteTerreContaminee)
            {
                qtTerreContaminee.quantite += vaisseau.terreContaminee.quantite;
                vaisseau.terreContaminee.quantite -= vaisseau.terreContaminee.quantite;
            }
            else
            {
                Console.WriteLine("Le centre de tri est rempli de Terre Contaminee");
                qtRestante = capaciteTerreContaminee - qtTerreContaminee.quantite;

                qtTerreContaminee.quantite += qtRestante;

                vaisseau.terreContaminee.quantite -= qtRestante;

                chargerVaisseau();

                qtTerreContaminee.quantite += vaisseau.terreContaminee.quantite;

                vaisseau.terreContaminee.quantite -= vaisseau.terreContaminee.quantite;
            }

            //Si il reste de l'espace dans le centre de tri pour des Résidus 
            if (qtResidusCombusFos.quantite + vaisseau.residusCombusFos.quantite < capaciteResidusCombusFos)
            {
                qtResidusCombusFos.quantite += vaisseau.residusCombusFos.quantite;
                vaisseau.residusCombusFos.quantite -= vaisseau.residusCombusFos.quantite;
            }
            else
            {
                Console.WriteLine("Le centre de tri est rempli de Residus de combustible fossile");
                qtRestante = capaciteResidusCombusFos - qtResidusCombusFos.quantite;

                qtResidusCombusFos.quantite += qtRestante;

                vaisseau.residusCombusFos.quantite -= qtRestante;

                chargerVaisseau();

                qtResidusCombusFos.quantite += vaisseau.residusCombusFos.quantite;

                vaisseau.residusCombusFos.quantite -= vaisseau.residusCombusFos.quantite;
            }



        }
        public cCentreTri CentreSuivant
        {
            get { return centreSuivant; }
            set { centreSuivant = value; }
        }



        public cCentreTri CentrePrecedent
        {
            get { return centrePrecedent; }
            set { centrePrecedent = value; }
        }
    }
}
