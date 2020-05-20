using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatAirmanager
{
    class Igrac
    {
        private static readonly double sansaDaSeNacrtaLet; //broj između 0 i 1
        List<ParkingMesto> parkingM;
        List<AvionskaLinija> linije;
        List<Avion> avioni;
        List<Putnik> putnici;
        List<Let> flights;
        int novac;
        double osoblje; //broj između 0 i 1 koji određuje koliko se izdvaja za osoblje
        double marketing; //broj između 0 i 1 koji određuje koliko se izdvaja za marketing
        double odrzavanje; //broj između 0 i 1 koji određuje koliko se izdvaja za održavanje aviona
        double bezbednost; //broj između 0 i 1 koji određuje koliko se izdvaja za bezbednost
        public Igrac(List<ParkingMesto> p,List<AvionskaLinija> al,List<Avion> a,int n,double ko,double m,double o,double b)
        {
            parkingM = p;
            linije = al;
            avioni = a;
            novac = n;
            osoblje = ko;
            marketing = m;
            odrzavanje = o;
            bezbednost = b;
            putnici = new List<Putnik>();
        }

        public int Novac { get => novac; set => novac = value; }
        public double Kvalitetosoblja { get => osoblje; set => osoblje = value; }
        public double Marketing { get => marketing; set => marketing = value; }
        public double Odrzavanje { get => odrzavanje; set => odrzavanje = value; }
        public double Bezbednost { get => bezbednost; set => bezbednost = value; }
        public List<ParkingMesto> ParkingM { get => parkingM; set => parkingM = value; }
        public List<AvionskaLinija> Linije { get => linije; set => linije = value; }
        public List<Avion> Avioni { get => avioni; set => avioni = value; }
        public void izvrsiLet(int dan, int sat, int brojLinije, Form1 form)
        {
            AvionskaLinija avionlinija = linije[brojLinije];
            Avion a = avionlinija.Avioni[avionlinija.Raspored[dan,sat]];
            int brojPutnika = Convert.ToInt32(Math.Round(nasum(Convert.ToDouble(avionlinija.ProsecanBrPutnika), 1.0)));
            List<Putnik> nizPutnika = new List<Putnik>(brojPutnika);
            Random rand = new Random();
            double prob=0;
            for (int i = 0; i < brojPutnika; i++)
            {
                nizPutnika[i] = putnici[rand.Next(putnici.Capacity)];
                prob += nizPutnika[i].Problem;
            }
            prob /= brojPutnika;
            double probOstalo = (1-osoblje + 1-odrzavanje + 1-bezbednost) / 3;
            prob = (prob + probOstalo) / 2;
            prob = prob * 10000;
            bool incident=false;
            int n = rand.Next(1, 10000);
            if(n<prob)
            {
                incident = true;
            }
            int duration = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < 24; j++)
                {
                    if (avionlinija.Raspored[(dan + i) % 7, (sat + j) % 24] < 0)
                        duration++;
                }
            }
            Let l = new Let(duration, a, incident, nizPutnika);
            flights.Add(l);
            double granica = sansaDaSeNacrtaLet * 10000;
            int c = rand.Next(1,10000);
            if(c<granica)
            {
                form.NacrtajLet(new Aerodrom(avionlinija.PocetniAerodrom), new Aerodrom(avionlinija.KrajnjiAerodrom), incident, a.Brzina);
            }
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
