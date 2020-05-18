using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatAirmanager
{
    public partial class Form1 : Form
    {
        //1 minut = 1 dan
        public struct Avionce
        {
            PictureBox slicica;
            Tuple<double, double> A;
            Tuple<double, double> B;
            bool SrusioSe;
            double koef;// ovo je izmedju 0 i 1
            double brzina;
        }

        public Form1()
        {
            InitializeComponent();
        }
        //Graphics g
        List<Avionce> Avioni;
        int trajanjePoteza; //u sekundama
        Igrac[] players;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public static void nacrtajLet(Graphics g, Tuple<double, double> A, Tuple<double, double> B, bool inc, double brzina, double k)
        {/*
            Avionce avion = new Avionce
            {
                A = A,
                B = B,
                SrusioSe = inc,
                koef = k,
                brzina = brz
            };

            Avioni.Add(avion);

            */
        }
        public static void pomeriAvione()
        {
           /* for (int i = 0; i < Avionce.capacity; i++) { 
                
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            UlaznaForma ulazna = new UlaznaForma(this);
            ulazna.Show();

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
