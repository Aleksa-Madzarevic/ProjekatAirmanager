using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class BiznisPutnik:Putnik
    {
        static double CenaKarteOd;

        public BiznisPutnik(double c, double a, int b, bool d, double e) : base (a, b, d, e)
        {
            BiznisPutnik.CenaKarteOd  =  c;
        }
        public BiznisPutnik(BiznisPutnik c) : base (c.Milje, c.God, c.SpecPrtljag, c.Problem)
        {
            
        }

        public double CenaBiz {
            get { return BiznisPutnik.CenaKarteOd; }
        }

    }
}
