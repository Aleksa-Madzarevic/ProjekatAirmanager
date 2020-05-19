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
    public partial class UlaznaForma : Form
    {
        Form1 glavna;
        public UlaznaForma(Form1 forma)
        {
            glavna = forma;
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            glavna.Enabled=true;
            this.Close();
        }
    }
}
