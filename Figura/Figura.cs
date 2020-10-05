using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Figura
    {
        int gverdi1, gverdi2, gverdi3, perimetri;
        double fartobi;

        public Figura(int gverdi1)
        {
            this.gverdi1 = gverdi1;
            perimetri = this.gverdi1 * 4;
            fartobi = this.gverdi1 * this.gverdi1;
        }


        public Figura(int gverdi1, int gverdi2)
        {
            this.gverdi1 = gverdi1;
            this.gverdi2 = gverdi2;
            perimetri = (this.gverdi1 + this.gverdi2);
            fartobi = this.gverdi1 * this.gverdi2;
        }

        public Figura(int gverdi1, int gverdi2, int gverdi3)
        {
            this.gverdi1 = gverdi1;
            this.gverdi2 = gverdi2;
            this.gverdi3 = gverdi3;
            perimetri = this.gverdi1 + this.gverdi2 + this.gverdi3;
            fartobi = this.gverdi1 * this.gverdi2 / 2;

        }

       


        public int Perimetri()
        {
            return perimetri;

        }

        public double Fartobi()
        {
            return fartobi;

        }

        
    }
}
