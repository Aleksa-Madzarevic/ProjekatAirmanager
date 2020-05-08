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
        Avion[] avioni;
        List<Let> letovi;
        public int[,] raspored; //matrica 24x7
        //ako je br recimo na poziciji [3][18] to znači da je avion avioni[br] u stanju leta na ovoj liniji četvrtkom od 18:00 do 19:00
        int prosecanbrputnika;
        public AvionskaLinija(AvionskaLinija al)
        {
            pocetniAerodrom = al.pocetniAerodrom;
            krajnjiAerodrom = al.krajnjiAerodrom;
            razdaljina = al.razdaljina;
            letovi = new List<Let>();
            prosecanbrputnika = al.prosecanbrputnika;
            int[,] raspored = new int[al.raspored.GetLength(0), al.raspored.GetLength(1)];
            for (int i = 0; i < al.raspored.GetLength(0); i++)
            {
                for (int j = 0; j < al.raspored.GetLength(1); j++)
                {
                    raspored[i, j] = al.raspored[i, j];
                }
            }
        }

        public AvionskaLinija(Aerodrom poc, Aerodrom kr, int r,int b, int[,] ras)
        {
            pocetniAerodrom = poc;
            krajnjiAerodrom = kr;
            razdaljina = r;
            letovi = new List<Let>();
            prosecanbrputnika = b;
            int [,] raspored = new int[ras.GetLength(0),ras.GetLength(1)];
            for (int i = 0; i < ras.GetLength(0); i++)
            {
                for (int j = 0; j < ras.GetLength(1); j++)
                {
                    raspored[i, j] = ras[i, j];
                }
            }
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
        public int ProsecanBrPutnika
        {
            get { return prosecanbrputnika; }
        }
        public Avion[] Avioni
        {
            get { return avioni; }
        }
        public int[,] Raspored
        {
            get { return raspored; }
        }
        
    }
}
