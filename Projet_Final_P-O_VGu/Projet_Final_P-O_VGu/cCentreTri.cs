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

        public cCentreTri(int nb)
        {
            qtPlutonium = new cPlutonium();
            qtUranium = new cUranium();
            qtMetauxLourds = new cMetauxLourds();
            qtTerreContaminee = new cTerreCont();
            qtResidusCombusFos = new cResidusCombusFos();

            fileDepart = new cFiles();
            fileArrivee = new cFiles();

            numCentre = nb;
        }

        //Numero du centre
        public int numCentre { get; set; }

        /*Capacité de vaisseau dans la file de départ et d'arrivée*/
        public int capaciteFile { get; set; }

        /*Quantité maximum de plutonium*/
        public int capacitePlutonium { get; set; }
        public cPlutonium qtPlutonium { get; set; }

        /*Quantité maximum d'uranium*/
        public int capaciteUranium { get; set; }
        public cUranium qtUranium { get; set; }

        /*Quantité maximm de métaux lourds*/
        public int capaciteMetauxLourds { get; set; }
        public cMetauxLourds qtMetauxLourds { get; set; }

        /*Quantité maximum de terre contaminée*/
        public int capaciteTerreContaminee { get; set; }
        public cTerreCont qtTerreContaminee { get; set; }

        /*Quantité maximum de résidus de combustible fossile*/
        public int capaciteResidusCombusFos { get; set; }
        public cResidusCombusFos qtResidusCombusFos { get; set; }

        public cFiles fileDepart { get; set; }

        public cFiles fileArrivee { get; set; }

        public void chargerVaisseau(cMatiere matiere)
        {
            int qtRestante, qtMatiere;

            qtRestante = 0;

            qtMatiere = this.fileDepart.finFile.qtMatiereVaisseau;

            switch (matiere.Nom)
            {
                case "Plutonium":
                    if ((qtMatiere += matiere.quantite) > this.fileDepart.finFile.capaciteVaisseau)
                    {
                        qtRestante = this.fileDepart.finFile.capaciteVaisseau - qtMatiere;

                        this.fileDepart.finFile.plutonium.quantite += qtRestante;

                        matiere.quantite -= qtRestante;
                    }
                    else
                    {
                        this.fileDepart.finFile.plutonium.quantite += matiere.quantite;
                    }
                    break;

                case "Uranium":
                    if ((qtMatiere += matiere.quantite) > this.fileDepart.finFile.capaciteVaisseau)
                    {
                        qtRestante = this.fileDepart.finFile.capaciteVaisseau - qtMatiere;

                        this.fileDepart.finFile.uranium.quantite += qtRestante;

                        matiere.quantite -= qtRestante;

                    }
                    else
                    {
                        this.fileDepart.finFile.uranium.quantite += matiere.quantite;
                    }
                    break;

                case "Métaux Lourds":
                    if ((qtMatiere += matiere.quantite) > this.fileDepart.finFile.capaciteVaisseau)
                    {
                        qtRestante = this.fileDepart.finFile.capaciteVaisseau - qtMatiere;

                        this.fileDepart.finFile.metauxLourds.quantite += qtRestante;

                        matiere.quantite -= qtRestante;

                    }
                    else
                    {
                        this.fileDepart.finFile.metauxLourds.quantite += matiere.quantite;
                    }
                    break;

                case "Terre contaminée":
                    if ((qtMatiere += matiere.quantite) > this.fileDepart.finFile.capaciteVaisseau)
                    {
                        qtRestante = this.fileDepart.finFile.capaciteVaisseau - qtMatiere;

                        this.fileDepart.finFile.terreContaminee.quantite += qtRestante;

                        matiere.quantite -= qtRestante;

                    }
                    else
                    {
                        this.fileDepart.finFile.terreContaminee.quantite += matiere.quantite;
                    }
                    break;

                case "Résidus de combustibles fossibles":
                    if ((qtMatiere += matiere.quantite) > this.fileDepart.finFile.capaciteVaisseau)
                    {
                        qtRestante = this.fileDepart.finFile.capaciteVaisseau - qtMatiere;

                        this.fileDepart.finFile.residusCombusFos.quantite += qtRestante;

                        matiere.quantite -= qtRestante;

                    }
                    else
                    {
                        this.fileDepart.finFile.residusCombusFos.quantite += matiere.quantite;
                    }
                    break;
            }
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

                chargerVaisseau(qtPlutonium);

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

                chargerVaisseau(qtUranium);

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

                chargerVaisseau(qtMetauxLourds);

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

                chargerVaisseau(qtTerreContaminee);

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

                chargerVaisseau(qtResidusCombusFos);

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
