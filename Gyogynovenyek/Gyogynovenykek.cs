using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyogynovenyek
{
    class Gyogynovenykek
    {
        public string Nev { get; private set; }
        public string Resz { get; private set; }
        public int Kezd { get; private set; }
        public int Veg { get; private set; }
        public int Idotartam { get; private set; }

        public Gyogynovenykek(string sor)
        {
            string[] a = sor.Split(';');
            Nev = a[0];
            Resz = a[1];
            Kezd = Convert.ToInt32(a[2]);
            Veg = Convert.ToInt32(a[3]);
            if (Veg > Kezd)
            {
                Idotartam = Veg - Kezd + 1;
            }
            else
            {
                Idotartam = 12 - Kezd + Veg + 1;
            }
            
        }
    }
}
