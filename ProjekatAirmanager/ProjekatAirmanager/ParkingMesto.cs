using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    public class ParkingMesto
    {
        private Dimenzije dimenzije;
        int CenaPoSatu;
        Aerodrom a;
        public ParkingMesto(Dimenzije d, int c, Aerodrom a)
        {
            dimenzije = d;
            CenaPoSatu = c;
            this.a = a;
        }

        public ParkingMesto(ParkingMesto p)
        {
            dimenzije = p.dimenzije;
            CenaPoSatu = p.CenaPoSatu;
            this.a = p.a;
        }

        public Dimenzije Dimenzije
        {
            get { return dimenzije; }
            set { dimenzije = value; }
        }

        public int CenaNaSat
        {
            get { return CenaPoSatu; }
            set { CenaPoSatu = value; }
        }

        public Aerodrom Aerodrom
        {
            get { return a; }
            set { a = value; }
        }
    }

}
