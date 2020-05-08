using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Aerodrom
    {
        List<ParkingMesto> parkingM;
        Tuple<double, double> kord;
        double cenaPoGejtu;

        public Aerodrom(List<ParkingMesto> parkingM, Tuple<double, double> kord, double cenaPoGejtu)
        {
            this.parkingM = parkingM;
            this.kord = kord;
            this.cenaPoGejtu = cenaPoGejtu;
        }
        public Aerodrom(Aerodrom a)
        {
            this.parkingM = a.parkingM;
            this.kord = a.kord;
            this.cenaPoGejtu = a.cenaPoGejtu;
        }

        public double Rastojanje(Tuple<double, double> poz)
        {
            return Math.Sqrt((kord.Item1 - poz.Item1) * (kord.Item1 - poz.Item1) + (kord.Item2 - poz.Item2) * (kord.Item2 - poz.Item2));
        }
        public double Rastojanje(Aerodrom a)
        {
            return Math.Sqrt((kord.Item1 - a.kord.Item1) * (kord.Item1 - a.kord.Item1) + (kord.Item2 - a.kord.Item2) * (kord.Item2 - a.kord.Item2));
        }

        public double CenaPoGejtu
        {
            get { return cenaPoGejtu; }
            set { cenaPoGejtu = value; }
        }
        public List<ParkingMesto> ParkingM
        {
            get { return parkingM; }
            set { parkingM = value; }
        }
        public Tuple<double, double> Kord
        {
            get { return kord; }
            set { kord = value; }
        }
    }
}
