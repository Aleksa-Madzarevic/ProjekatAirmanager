using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    class Putnik
    {
        double m;
        int god;
        bool SpecPr;
        double Prob; //double između 0 i 1 koji predstavlja verovatnoću da se dogodi problem

        public Putnik(double a, int b, bool d, double e)
        {
            m = a;
            god = b;
            SpecPr = d;
            Prob = e;
        }

        public Putnik(Putnik p){
            m = p.m;
            god = p.god;
            SpecPr = p.SpecPr;
            Prob = p.Prob;
        }

        public double Milje {
            get { return m; }
            set { m = value; }
        }

        public int God
        {
            get { return god; }
            set { god = value; }
        }

        public bool SpecPrtljag
        {
            get { return SpecPr; }
            set { SpecPr = value; }
        }

        public double Problem
        {
            get { return Prob; }
            set { Prob = value; }
        }
    }
}
