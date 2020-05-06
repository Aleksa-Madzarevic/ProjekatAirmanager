using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class ParkingMesto
    {
        private Dimenzije dimenzije;
        int CenaPoSatu;

        public ParkingMesto(Dimenzije d, int c)
        {
            dimenzije = d;
            CenaPoSatu = c;
        }

        public ParkingMesto(ParkingMesto p)
        {
            dimenzije = p.dimenzije;
            CenaPoSatu = p.CenaPoSatu;
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

    }

    class ParkingMestoZaIznajmljivanje: ParkingMesto
    {

    }
}
