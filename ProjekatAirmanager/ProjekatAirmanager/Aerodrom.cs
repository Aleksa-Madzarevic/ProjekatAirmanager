using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    public class Aerodrom
    {
        string imeAerodroma;
        List<ParkingMesto> parkingM;
        Tuple<double, double> kord;//prva pripada (-180,180], a druga [-90,90]
        double cenaPoGejtu;

        public Aerodrom(List<ParkingMesto> parkingM, Tuple<double, double> kord, double cenaPoGejtu,string ime)
        {
            this.imeAerodroma  =  ime;
            this.parkingM = parkingM;
            this.kord = kord;
            this.cenaPoGejtu = cenaPoGejtu;
        }
        /*public Aerodrom(string imeAerodroma, Tuple<double,double> kord)
        {
            this.imeAerodroma = imeAerodroma;
            this.kord = kord;
            this.parkingM = null;
            this.cenaPoGejtu = 1;
        }*/

        public Aerodrom(Aerodrom a)
        {
            this.imeAerodroma = a.imeAerodroma;
            this.parkingM = a.parkingM;
            this.kord = a.kord;
            this.cenaPoGejtu = a.cenaPoGejtu;
        }

        public double Rastojanje(Aerodrom a) //vraca rastojanje u kilometrima
        {
            double R = 6400; //aproksimacija da je Zemlja lopta poluprecnika 6400km
            double thisRad1 = this.kord.Item1 / (2 * Math.PI);
            double thisRad2 = this.kord.Item2 / (2 * Math.PI);
            double rad1 = a.kord.Item1;
            double rad2 = a.kord.Item2;

            if (rad1 == thisRad1 && rad2 == thisRad2)
            {
                return 0;
            }

            double thisZ = R * Math.Sin(thisRad2);
            double thisX = R * Math.Cos(thisRad2) * Math.Sin(thisRad1);
            double thisY = R * Math.Cos(thisRad2) * Math.Cos(thisRad1);
            double Z = R * Math.Sin(rad2);
            double X = R * Math.Cos(rad2) * Math.Sin(rad1);
            double Y = R * Math.Cos(rad2) * Math.Cos(rad1);

            double EuclidDis = Math.Sqrt((X - thisX) * (X - thisX) + (Y - thisY) * (Y - thisY) + (Z - thisZ) * (Z - thisZ));

            double sin_HalfAlpha = EuclidDis / (2 * R);
            double cos_HalfAlpha = Math.Sqrt(1 - sin_HalfAlpha * sin_HalfAlpha);
            double sin_Alpha = 2 * sin_HalfAlpha * cos_HalfAlpha;

            double Alpha = Math.Asin(sin_Alpha);

            return R * Alpha;
        }
        public double Euklid(Aerodrom a)
        {
            double disX = this.kord.Item1 - a.kord.Item1;
            double disY = this.kord.Item2 - a.kord.Item2;
            return Math.Sqrt(disX * disX + disY * disY);
        }
        public double Euklid(Tuple<double, double> t)
        {
            double disX = this.kord.Item1 - t.Item1;
            double disY = this.kord.Item2 - t.Item2;
            return Math.Sqrt(disX * disX + disY * disY);
        }
        public double Ugao(Aerodrom b)
        {
            if (b.kord.Item1 == this.kord.Item1)
            {
                if (b.kord.Item2 > this.kord.Item2) return 0;
                else if (b.kord.Item2 == this.kord.Item2) return -1;
                else return Math.PI;
            }

            double disAB = Euklid(b);
            Tuple<double, double> c = new Tuple<double, double>(this.kord.Item1, this.kord.Item2 + disAB);

            double disBC = b.Euklid(c);
            double sin_HalfAlpha = disBC / (2 * disAB);
            double cos_HalfAlpha = Math.Sqrt(1 - sin_HalfAlpha * sin_HalfAlpha);
            double sin_Alpha = 2 * sin_HalfAlpha * cos_HalfAlpha;
            double Alpha = Math.Asin(sin_Alpha);

            if (this.kord.Item1 < b.kord.Item1)
            {
                return Alpha;
            }
            else
            {
                return 2 * Math.PI - Alpha;
            }
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

        public string ImeAerodroma
        {
            get { return imeAerodroma; }
            set { imeAerodroma = value; }
        }
    }
}
