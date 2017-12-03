using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_P_O_VGu
{
    class Program
    {
        static void Main(string[] args)
        {

            cTraitement t = new cTraitement();

            t.selectionnerNbVaisseau();

            cCentrePair centreTest = new cCentrePair();


            Console.ReadKey();
        }
    }
}
