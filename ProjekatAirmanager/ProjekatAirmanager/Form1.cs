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
        Form2 Kupiavion;
        //1 minut = 1 dan
        public struct Avionce
        {
            PictureBox slicica;
            Tuple<double, double> a;
            Tuple<double, double> b;
            double inc; //broj između 0 i 1, koji određuje gde se desio incident, ako se desio, inace ima vrednost 0 ukoliko se incident nije desio
            double koef;// ovo je izmedju 0 i 1 i određuje gde se nalazi avion
            double brzina;

            public PictureBox Slicica { get => slicica; set => slicica = value; }
            public Tuple<double, double> A { get => a; set => a = value; }
            public Tuple<double, double> B { get => b; set => b = value; }

            public double Koef { get => koef; set => koef = value; }
            public double Brzina { get => brzina; set => brzina = value; }
            public double Inc { get => inc; set => inc = value; }
        }

        public Form1(Form2 forma)
        {
            Kupiavion = forma;
            InitializeComponent();
        }
        Graphics g;
        List<Avionce> VisualAirplanes;
        int MoveDuration; //u sekundama
        Igrac[] players;
        int gameDuration;
        int numberOfPlayers;
        int startingMoney;
        public Graphics G { get => g; set => g = value; }
        public int GameDuration { get => gameDuration; set => gameDuration = value; }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void nacrtajLet(Graphics g, Tuple<double, double> A, Tuple<double, double> B, bool inc, double brzina)
        {
            Avionce avion = new Avionce
            {
                A = A,
                B = B,
                
                Koef = 0.001,
                Brzina = brzina
            };
            if (inc == true)
            {
                Random rand = new Random();
                int t = rand.Next(0, 10);
                if (t < 5)
                    avion.Inc = 0.999;
                else
                {
                    Random rand2 = new Random();
                    avion.Inc = rand2.Next(1, 999)/1000;

                }
            }
            else
                avion.Inc = 0;

            VisualAirplanes.Add(avion);

            
        }
        public void pomeriAvione()
        {
            for (int i = 0; i < VisualAirplanes.Count; i++) {

            }
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

        private Tuple<float,float> GraphicsCoordinates(Tuple<double,double> coordinates)
        {
            float x = (float)coordinates.Item1;
            float y = (float)coordinates.Item2;
            y -= 90;
            y = y * -1;
            y = y * (pictureBox1.Height / 180);
            x = x + 180;
            x = x * (pictureBox1.Width / 360);
            return new Tuple<float, float>(x,y);
        }
        private Tuple<float,float> LocationOfThePlane(Tuple<double,double> A, Tuple<double,double> B, double koef)
        {
            Tuple<float, float> a = GraphicsCoordinates(A);
            Tuple<float, float> b = GraphicsCoordinates(B);
        }

        private void KupiAvion_Click(object sender, EventArgs e)
        {
            Kupiavion.Enabled = true;
        }
    }
}
