using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjekatAirmanager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Avion> avioni = new List<Avion>();
        StreamReader sr = new StreamReader("");

        private void Form2_Load(object sender, EventArgs e)
        {
            while(!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] st = new string[100];
                st = s.Split(';') ;
                string[] d = new string[3];
                string str = s[6].ToString();
                d = str.Split('*');
                Avion a = new Avion(st[0], Convert.ToDouble(st[1]), Convert.ToInt32(st[2]), Convert.ToInt32(st[3]), Convert.ToInt32(st[4]), Convert.ToDouble(st[5]), Convert.ToDouble(d[0]), Convert.ToDouble(d[1]), Convert.ToDouble(d[2]), Convert.ToDouble(st[7]));
                avioni.Add(a);
                
            }

        }
    }
}
