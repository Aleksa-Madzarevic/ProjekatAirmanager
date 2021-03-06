﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatAirmanager
{
    public class Dimenzije
    {
        private double širina;
        private double visina;
        private double dužina;
        public Dimenzije(double širina, double visina, double dužina)
        {
            this.širina = širina;
            this.visina = visina;
            this.dužina = dužina;
        }

        public Dimenzije(string s)
        {
            int prvi_razmak = s.IndexOf(" ");
            širina = Convert.ToDouble(s.Substring(0, prvi_razmak));
            int drugi_razmak=s.LastIndexOf(" ");
            visina = Convert.ToDouble(s.Substring(prvi_razmak + 1, drugi_razmak - prvi_razmak - 1));
            dužina = Convert.ToDouble(s.Substring(drugi_razmak + 1));
        }

        public double Širina
        {
            get { return širina; }
            set { širina = value; }
        }
        public double Visina
        {
            get { return visina; }
            set { visina = value; }
        }
        public double Dužina
        {
            get { return dužina; }
            set { dužina = value; }
        }

        public static bool operator >(Dimenzije d1, Dimenzije d2)
        {
            if (d1.dužina > d2.dužina && d1.širina > d2.širina && d1.visina > d2.visina)
                return true;
            return false;
        }
        public static bool operator <(Dimenzije d1, Dimenzije d2)
        {
            if (d1.dužina < d2.dužina && d1.širina < d2.širina && d1.visina < d2.visina)
                return true;
            return false;
        }

        public string prebaci_dimenzije_u_string()
        {
            return širina.ToString() +" "+ visina.ToString() +" "+ dužina.ToString();
        }
    }
}
