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
            glavna.GameDuration = Convert.ToInt32(gameDuration.Value);
            glavna.NumberOfPlayers = Convert.ToInt32(numberOfPlayers.Value);
            glavna.StartingMoney = Convert.ToInt32(startingMoney.Value);
            glavna.MoveDuration = Convert.ToInt32(moveDuration.Value);
            if (RBtnEkstremno.Checked) glavna.Tezina = 3;
            else if (RBtnTeško.Checked) glavna.Tezina = 2;
            else if (RBtnSrednje.Checked) glavna.Tezina = 1;
            else glavna.Tezina  =  0;

            glavna.Enabled = true;
            this.Close();
        }

        private void UlaznaForma_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
