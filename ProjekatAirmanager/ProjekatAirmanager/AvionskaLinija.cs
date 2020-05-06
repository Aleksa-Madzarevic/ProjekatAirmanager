using ProjekatAirmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class AvionskaLinija
    {
        Aerodrom pocetniAerodrom;
        Aerodrom krajnjiAerodrom;
        public int razdaljina;

        public AvionskaLinija(AvionskaLinija al)
        {
            pocetniAerodrom = al.pocetniAerodrom;
            krajnjiAerodrom = al.krajnjiAerodrom;
            razdaljina = al.razdaljina;
        }

        public AvionskaLinija(Aerodrom poc, Aerodrom kr, int r)
        {
            pocetniAerodrom = poc;
            krajnjiAerodrom = kr;
            razdaljina = r;
        }

        public int Razdaljina
        {
            get { return razdaljina; }
            set { razdaljina = value; }
        }

        public Aerodrom PocetniAerodrom
        {
            get { return pocetniAerodrom; }
            set { pocetniAerodrom = value; }
        }

        public Aerodrom KrajnjiAerodrom
        {
            get { return krajnjiAerodrom; }
            set { krajnjiAerodrom = value; }
        }
    }
}
