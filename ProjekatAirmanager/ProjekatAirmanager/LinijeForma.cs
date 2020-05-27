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
    public partial class LinijeForma : Form
    {
        public LinijeForma(Form1 main)
        {
            this.main = main;
            InitializeComponent();
        }
        Form1 main;
        bool avioni_ok;
        bool drom_ok;
        int[] drom_ind = new int[2];
        Avion[] izabAvioni = new Avion[2];
        Aerodrom[] izabDrom = new Aerodrom[2];

        private void LinijeForma_Load(object sender, EventArgs e)
        {
            drom_ok = false;
            avioni_ok = false;

            duzinaPuta.Text = "";
            trajanjeLeta.Text = "";
            validSve.Text = "Ne";

            List<Avion> listaAvionaIgraca = Form1.players[Form1.currentPlayer].avioni;

            for (int i=0;i<listaAvionaIgraca.Count;i++)
            {
                izborAviona.Items.Add(listaAvionaIgraca[i].uString(), false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //provera da li su aerodromi dobro izabrani
            int dosad = 0;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState st = checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(i));
                if (st == CheckState.Checked)
                {
                    if (dosad >= 2)
                    {
                        drom_ok = false;
                    }
                    else
                    {
                        drom_ind[dosad] = i;
                        dosad++;
                    }
                }
            }

            if (!drom_ok)
            {
                duzinaPuta.Text = "";
                validSve.Text = "Ne";
                trajanjeLeta.Text = "";
                return;
            }

            for(int i=0;i<Form1.aerodromi.Count;i++)
            {
                if(Form1.aerodromi[i].ImeAerodroma == checkedListBox1.Items[drom_ind[0]])
                {
                    izabDrom[0] = new Aerodrom(Form1.aerodromi[i]);
                }
                if(Form1.aerodromi[i].ImeAerodroma == checkedListBox1.Items[drom_ind[1]])
                {
                    izabDrom[1] = new Aerodrom(Form1.aerodromi[i]);
                }
            }

            int duzPut = (int)(izabDrom[0].Rastojanje(izabDrom[1]));
            duzinaPuta.Text = duzPut.toString();
            if (!avioni_ok)
            {
                validSve.Text = "Ne";
                trajanjeLeta.Text = "";
                return;
            }

            int duzina1 = (int)(duzPut / izabAvioni[0].Brzina);
            int duzina2 = (int)(duzPut / izabAvioni[1].Brzina);
            int duzina = (duzina1 + duzina2) / 2;
            if (duzina == 0) duzina = 1;
            trajanjeLeta.Text = duzina.ToString();
            validSve.Text = "Da";
        }
        private void izborAviona_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dosad = 0;
            for (int i = 0; i < izborAviona.Items.Count; i++)
            {
                CheckState st = izborAviona.GetItemCheckState(izborAviona.Items.IndexOf(i));
                if (st == CheckState.Checked)
                {
                    if (dosad >= 2)
                    {
                        avioni_ok = false;
                    }
                    else
                    {
                        izabAvioni[dosad] = new Avion(main.Players[main.CurrentPlayer].Avioni[i]);
                        dosad++;
                    }
                }
            }

            if (!drom_ok)
            {
                duzinaPuta.Text = "";
                validSve.Text = "Ne";
                trajanjeLeta.Text = "";
                return;
            }

            int duzPut = (int)(izabDrom[0].Rastojanje(izabDrom[1]));
            duzinaPuta.Text = duzPut.toString();
            if (!avioni_ok)
            {
                duzinaPuta.Text = duzPut.ToString();
                validSve.Text = "Ne";
                trajanjeLeta.Text = "";
                return;
            }

            int duzina1 = (int)(duzPut / izabAvioni[0].Brzina);
            int duzina2 = (int)(duzPut / izabAvioni[1].Brzina);
            int duzina = (duzina1 + duzina2) / 2;
            if (duzina == 0) duzina = 1;
            trajanjeLeta.Text = duzina.ToString();
            validSve.Text = "Da";
        }

        public int[,] schedule;
        private void napraviLiniju_Click(object sender, EventArgs e)
        {
            if(!drom_ok || !avioni_ok)
            {
                MessageBox.Show("Greska. Molimo Vas da ispoštujete data uputstva.");
                return;
            }


            schedule = new int[7, 24];
            int brojSatiRadnimDanima = Convert.ToInt32(RadniDani.Value);
            int brojSatiVikendom = Convert.ToInt32(Vikend.Value);

            for (int i=0;i<5;i++)
            {
                schedule[i, brojSatiRadnimDanima] = 1;
            }

            for (int i=5;i<7;i++)
            {
                schedule[i, brojSatiVikendom] = 1;
            }

            int rastojanje_aerodroma = (int)(izabDrom[0].Rastojanje(izabDrom[1]));
            int prosecan_br_putnika = (izabAvioni[0].BrPutnika + izabAvioni[1].BrPutnika) / 2;
            AvionskaLinija avioLinija = new AvionskaLinija(izabDrom[0], izabDrom[1], rastojanje_aerodroma, prosecan_br_putnika, schedule);

            main.Players[Form1.currentPlayer].linije.Add(avioLinija);
        }
    }
}
