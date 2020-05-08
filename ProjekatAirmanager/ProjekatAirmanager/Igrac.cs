using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Igrac
    {
        List<ParkingMesto> parkingM;
        List<AvionskaLinija> linije;
        List<Avion> avioni;
        double novac;
        double kvalitetosoblja;
        double marketing;
        double odrzavanje;
        double bezbednost;
        public Igrac(List<ParkingMesto> p,List<AvionskaLinija> al,List<Avion> a,double n,double ko,double m,double o,double b)
        {
            parkingM = p;
            linije = al;
            avioni = a;
            novac = n;
            kvalitetosoblja = ko;
            marketing = m;
            odrzavanje = o;
            bezbednost = b;
        }

        public double Novac { get => novac; set => novac = value; }
        public double Kvalitetosoblja { get => kvalitetosoblja; set => kvalitetosoblja = value; }
        public double Marketing { get => marketing; set => marketing = value; }
        public double Odrzavanje { get => odrzavanje; set => odrzavanje = value; }
        public double Bezbednost { get => bezbednost; set => bezbednost = value; }
        public List<ParkingMesto> ParkingM { get => parkingM; set => parkingM = value; }
        public List<AvionskaLinija> Linije { get => linije; set => linije = value; }
        public List<Avion> Avioni { get => avioni; set => avioni = value; }
        public void izvrsiLet(int dan, int sat, int brojLinije)
        {
            
            AvionskaLinija avionlinija = linije[brojLinije];
            Avion a = avionlinija.Avioni[avionlinija.Raspored[dan,sat]];
            int brojPutnika = Convert.ToInt32(Math.Round(nasum(Convert.ToDouble(avionlinija.ProsecanBrPutnika), 1.0)));

           // Let l = new Let(avionlinija.PocetniAerodrom.Rastojanje(avionlinija.KrajnjiAerodrom) / a.Brzina, a,  );
        }
        public static double nasum(double mean, double stDev)
        {
            Random rand = new Random(Convert.ToInt32((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) % Int32.MaxValue)); 
            double u1 = rand.NextDouble(); 
            double u2 = rand.NextDouble();
            while(u1==0)
            {
                u1 = rand.NextDouble();
            }
            while(u2==0)
            {
                u2 = rand.NextDouble();
            }
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =
                         mean + stDev * randStdNormal; //random normal(mean,stdDev^2)
            return randNormal;
        }
    }
}
