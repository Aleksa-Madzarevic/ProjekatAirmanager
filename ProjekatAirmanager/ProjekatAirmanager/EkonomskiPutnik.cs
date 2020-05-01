using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class EkonomskiPutnik:Putnik
    {
        static double CenaKarteOd;

        public EkonomskiPutnik(double c, double a, int b, bool d, double e) : base(a, b, d, e)
        {
            EkonomskiPutnik.CenaKarteOd = c;
        }
        public EkonomskiPutnik(EkonomskiPutnik c) : base(c.Milje, c.God, c.SpecPrtljag, c.Problem)
        {
            this.CenaEk = c.CenaEk;

        }

        public double CenaEk
        {
            get { return EkonomskiPutnik.CenaKarteOd; }
            set { CenaEk = value; }
        }

    }
}
