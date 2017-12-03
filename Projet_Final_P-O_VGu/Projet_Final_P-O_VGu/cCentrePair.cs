using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class cCentrePair:iCentreDeTri
    {

        cFiles fileDepart = new cFiles();
        cFiles fileArrivee = new cFiles();

        public cCentrePair()
        {
            capaciteFile = 30;
            capacitePlutonium = 1005;
            capaciteUranium = 857;
            capaciteMetauxLourds = 3456;
            capaciteTerreContaminee = 457;
            capaciteResidusCombusFos = 639;
        }

        /*Capacité de vaisseau dans la file de départ et d'arrivée*/
        public virtual int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        public virtual int capacitePlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        public virtual int capaciteUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        public virtual int capaciteMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        public virtual int capaciteTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        public virtual int capaciteResidusCombusFos { get; set; }

        public virtual int qtPlutonium { get; set; }

        public virtual int qtUranium { get; set; }

        public virtual int qtMetauxLourds { get; set; }

        public virtual int qtTerreContaminee { get; set; }

        public virtual int qtResidusCombusFos { get; set; }

        public void chargerVaisseau(cVaisseau vaisseau)
        {
            
        }

        public void dechargerVaisseau(cVaisseau vaisseau)
        {
            int qtRestante;

            qtRestante = 0;
        
            while (qtPlutonium != capacitePlutonium | qtUranium != capaciteUranium | qtMetauxLourds != capaciteMetauxLourds | qtTerreContaminee != capaciteTerreContaminee | qtResidusCombusFos != capaciteResidusCombusFos)
            {
                if (qtPlutonium + vaisseau.qtPlutonium < capacitePlutonium)
                {
                    qtPlutonium += vaisseau.qtPlutonium;
                }
                else
                {
                    qtRestante = capacitePlutonium - qtPlutonium;

                    qtPlutonium += qtRestante;

                    vaisseau.qtPlutonium -= qtRestante;

                    break;
                }

                if (qtUranium + vaisseau.qtUranium < capaciteUranium)
                {
                    qtUranium += vaisseau.qtUranium;
                }
                else
                {
                    qtRestante = capaciteUranium - qtUranium;

                    qtUranium += qtRestante;

                    vaisseau.qtUranium -= qtRestante;

                    break;
                }

                if (qtMetauxLourds + vaisseau.qtMetauxLourds < capaciteMetauxLourds)
                {
                    qtMetauxLourds += vaisseau.qtMetauxLourds;
                }
                else
                {
                    qtRestante = capaciteMetauxLourds - qtMetauxLourds;

                    qtMetauxLourds += qtRestante;

                    vaisseau.qtMetauxLourds -= qtRestante;

                    break;
                }

                if (qtTerreContaminee + vaisseau.qtTerreContaminee < capaciteTerreContaminee)
                {
                    qtTerreContaminee += vaisseau.qtTerreContaminee;
                }
                else
                {
                    qtRestante = capaciteTerreContaminee - qtTerreContaminee;

                    qtTerreContaminee += qtRestante;

                    vaisseau.qtTerreContaminee -= qtRestante;

                    break;
                }

                if (qtResidusCombusFos + vaisseau.qtResidusCombusFos < capaciteResidusCombusFos)
                {
                    qtResidusCombusFos += vaisseau.qtResidusCombusFos;
                }
                else
                {
                    qtRestante = capaciteResidusCombusFos - qtResidusCombusFos;

                    qtResidusCombusFos += qtRestante;

                    vaisseau.qtResidusCombusFos -= qtRestante;

                    break;
                }

            }

        }

    }
}
