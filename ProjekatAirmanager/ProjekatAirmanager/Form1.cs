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
        struct Avionce
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
        //struktura SlikaAvion
        List<Avionce> Avioni;
        int trajanjePoteza; //u sekundama
        enum
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public static void nacrtajLet(Graphics g, Tuple<double, double> A, Tuple<double, double> B, bool inc, double brzina)
        {
            Avionce avion=new Avionce();


        }
        public static void pomeriAvione()
        {
            for (int i = 0; i < Avionce.capacity; i++) { 
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
