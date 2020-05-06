using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Let
    {
        double duzinaTrajanja;
        double zarada;
        List<Putnik> nizPutnika;
        Avion airplane;
        bool desioSeIncident;

        public Let(Let l)
        {
            duzinaTrajanja = l.duzinaTrajanja;
            zarada = l.zarada;
            
            airplane = l.airplane;
            desioSeIncident = l.desioSeIncident;
            this.nizPutnika = new List<Putnik>(l.nizPutnika);
        }

        public Let(double duztr, double zar, Avion a, bool inc, List<Putnik> niz)
        {
            duzinaTrajanja = duztr;
            zarada = zar;
            airplane = a;
            desioSeIncident = inc;
            this.nizPutnika = new List<Putnik>(niz);
            
        }

        public double DuzinaTrajanja
        {
            get { return duzinaTrajanja; }
            set { duzinaTrajanja = value; }
        }

        public double Zarada
        {
            get { return zarada; }
            set { zarada = value; }
        }

        public int BrojPutnika
        {
            get { return nizPutnika.Count; }
        }

        public Avion Airplane
        {
            get { return airplane; }
            set { airplane = value; }
        }

        public bool DesioSeIncident
        {
            get { return desioSeIncident; }
            set { desioSeIncident = value; }
        }

        public Putnik this[int i]
        {
            get { return nizPutnika[i]; }
            set { nizPutnika[i] = value; }
        }

    }
}