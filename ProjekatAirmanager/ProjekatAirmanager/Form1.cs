﻿using ProjekatAirmanager.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace ProjekatAirmanager
{
    public partial class Form1 : Form
    {
        public List<Aerodrom> aerodromi;
        public struct Avionce
        {
            PictureBox slicica;
            Tuple<double, double> a;
            Tuple<double, double> b;
            double inc; //broj između 0 i 1, koji određuje gde se desio incident, ako se desio, inace ima vrednost 0 ukoliko se incident nije desio
            double koef;// ovo je izmedju 0 i 1 i određuje gde se nalazi avion
            double brzina;
            double korak; //broj koji određuje za koliko se uvećava koeficijent pri svakoj iteraciji

            public PictureBox Slicica { get => slicica; set => slicica = value; }
            public Tuple<double, double> A { get => a; set => a = value; }
            public Tuple<double, double> B { get => b; set => b = value; }
            public double Koef { get => koef; set => koef = value; }
            public double Brzina { get => brzina; set => brzina = value; }
            public double Inc { get => inc; set => inc = value; }
            public double Korak { get => korak; set => korak = value; }
        }

        

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        Graphics g;
        List<Avionce> VisualAirplanes;
        public double brzinaAviona;
        int moveDuration; //u sekundama
        private Igrac[] players;
        Label[] lblPlayers;
        int gameDuration; //in days
        int numberOfPlayers;
        int startingMoney;
        int ratio;//this number represents the width of the pictureBox divided by the width of the picture of the plane
        double realTimeRatio; //= 1440 minutes in the real world divided by the equivalent amount of time in the game (in minutes) 
        private int currentPlayer;
        int timeLeft;//in seconds
        int day;
        int dayOfTheWeek;
        #region svojstva
        public Graphics G { get => g; set => g = value; }
        public int GameDuration { get => gameDuration; set => gameDuration = value; }
        public int NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
        public int StartingMoney { get => startingMoney; set => startingMoney = value; }
        public int MoveDuration { get => moveDuration; set => moveDuration = value; }
        internal Igrac[] Players { get => players; set => players = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void NacrtajLet(Aerodrom A, Aerodrom B, bool inc, double brzina)
        {
            Tuple<double, double> a = A.Kord;
            Tuple<double, double> b = B.Kord;
            Avionce avion = new Avionce
            {
                A = a,
                B = b,

                Koef = 0.001,
                Brzina = brzina
            };
            if (inc == true)
            {
                Random rand = new Random();
                int t = rand.Next(0, 10);
                if (t < 5)
                    avion.Inc = 0.990;
                else
                {
                    Random rand2 = new Random();
                    avion.Inc = rand2.Next(1, 999) / 1000;

                }
            }
            else
                avion.Inc = 0;
            avion.Slicica = new PictureBox();
            Image AirplaneImg = new Bitmap(Resources.avion);
            avion.Slicica.BackgroundImage = RotateImage(AirplaneImg, Convert.ToSingle((180 / Math.PI) * A.Ugao(B)));
            avion.Slicica.BackgroundImageLayout = ImageLayout.Stretch;
            avion.Slicica.Width = pictureBox1.Width / ratio;
            avion.Slicica.Height = avion.Slicica.Width;
            avion.Slicica.Location = new Point(pictureBox1.Location.X + Convert.ToInt32(Math.Round(GraphicsCoordinates(a).Item1)), pictureBox1.Location.Y + Convert.ToInt32(Math.Round(GraphicsCoordinates(b).Item2)));
            this.Controls.Add(avion.Slicica);

            avion.Korak = (Math.Round((((realTimeRatio * timer.Interval) / (A.Rastojanje(B) / brzina))) * 1000)) / 1000;

            VisualAirplanes.Add(avion);


        }
        public void PomeriAvione()
        {
            for (int i = 0; i < VisualAirplanes.Count; i++)
            {
                Avionce t = VisualAirplanes[i];
                t.Koef += t.Korak;
                Tuple<float, float> location = LocationOfThePlane(t.A, t.B, t.Koef);
                if (t.Koef >= t.Inc && t.Inc != 0)
                {
                    t.Slicica = new PictureBox();
                    t.Slicica.BackgroundImage = Resources.incident;
                    t.Slicica.BackgroundImageLayout = ImageLayout.Stretch;
                    t.Slicica.Width = pictureBox1.Width / ratio;
                    t.Slicica.Height = t.Slicica.Width;
                }
                if (t.Koef >= 0.999)
                {
                    this.Controls.Remove(t.Slicica);
                    VisualAirplanes.RemoveAt(i);
                }
                else { t.Slicica.Location = new Point(Convert.ToInt32(location.Item1) + pictureBox1.Location.X, Convert.ToInt32(location.Item2) + pictureBox1.Location.Y); }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            UlaznaForma ulazna = new UlaznaForma(this);
            ulazna.Show();
            ulazna.Visible = true;
            this.TopMost = false;
            ulazna.TopMost = true;
            
        }
        internal void ContinueLoading()
        {
            this.TopMost = true;
            players = new Igrac[numberOfPlayers];
            lblPlayers = new Label[numberOfPlayers];
            ratio = 100;
            realTimeRatio = 1440;
            currentPlayer = 0;
            lblVreme.Text = Convert.ToString(moveDuration);
            timeLeft = moveDuration;
            lblDan.Text = "1/" + Convert.ToString(gameDuration);
            string str="";
            dayOfTheWeek = new Random().Next(0, 7);
            switch(dayOfTheWeek)
            {
                case 0: str = "ponedeljak"; break;
                case 1: str = "utorak"; break;
                case 2: str = "sreda"; break;
                case 3: str = "četvrtak"; break;
                case 4: str = "petak"; break;
                case 5: str = "subota"; break;
                case 6: str = "nedelja"; break;
            }
            lblDanUNedelji.Text = str;
            int w=0;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players[i] = new Igrac(new List<ParkingMesto>(), new List<AvionskaLinija>(), new List<Avion>(), startingMoney);
                Label l = new Label();
                l.Location = new Point(lblDanUNedelji.Location.X + lblDanUNedelji.Width+50+w, lblDanUNedelji.Location.Y);
                l.Text = Convert.ToString(startingMoney);
                w = l.Width + w;
                l.AutoSize = true;
                Controls.Add(l);
                lblPlayers[i] = l;
                generatePassengers(100, i);
            }
            lblPlayers[currentPlayer].ForeColor = Color.Red;
            timer.Start();
        }

        private void generatePassengers(int v, int i)
        {
            for (i = 0; i < v; i++)
            {
                bool b;
                Random r = new Random();
                if (r.Next(1, 101) < 6)
                    b = true;
                else
                    b = false;
                players[i].Putnici.Add(new Putnik(0,Igrac.nasum(30.9,Math.Sqrt(2)/2),b));
            }
        }

        private void timer_Tick(object sender, EventArgs e) { 
            for (int i = 0; i < players.Length(); i++) {
                for (int j = 0; j < players[i].Linije.Count; j++) { 
                    
                }          
            }          
        }
        private void KrajPoteza()
        {

        }
        private Tuple<float, float> GraphicsCoordinates(Tuple<double, double> coordinates)
        {
            float x = (float)coordinates.Item1;
            float y = (float)coordinates.Item2;
            y -= 90;
            y *= -1;
            y *= (pictureBox1.Height / 180);
            x += 180;
            x *= (pictureBox1.Width / 360);
            return new Tuple<float, float>(x, y);
        }
        private Tuple<float, float> LocationOfThePlane(Tuple<double, double> A, Tuple<double, double> B, double koef)
        {
            Tuple<float, float> a = GraphicsCoordinates(A);
            Tuple<float, float> b = GraphicsCoordinates(B);

            float X = (float)koef * (b.Item1 - a.Item1) + a.Item1;
            float Y = (float)koef * (b.Item2 - a.Item2) + a.Item2;
            Tuple<float, float> x = new Tuple<float, float>(X, Y);

            return x;
        }
        /// <summary>
        /// method to rotate an image either clockwise or counter-clockwise
        /// </summary>
        /// <param name="img">the image to be rotated</param>
        /// <param name="rotationAngle">the angle (in degrees).
        /// NOTE: 
        /// Positive values will rotate clockwise
        /// negative values will rotate counter-clockwise
        /// </param>
        /// <returns></returns>
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void LinijeForma_Click(object sender, EventArgs e)
        {
            var LinijeForma = new Form1();
            LinijeForma.Show();
        }
    }
}
