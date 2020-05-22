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
    public partial class NapraviLinijuF : Form
    {
        public NapraviLinijuF()
        {
            InitializeComponent();
        }

        /*checkedListBox1.Items.Add(0,"Belgrade 44 20");
        checkedListBox1.Items.Add("New York");
        checkedListBox1.Items.Add("Melbourne");
        checkedListBox1.Items.Add("Rio");
        checkedListBox1.Items.Add("London 51 0");
        checkedListBox1.Items.Add("Beijing");
        checkedListBox1.Items.Add("Tokyo");

        checkedListBox2.Items.Add("Belgrade 44 20");
        checkedListBox2.Items.Add("New York");
        checkedListBox2.Items.Add("Melbourne");
        checkedListBox2.Items.Add("Rio");
        checkedListBox2.Items.Add("London 51 0");
        checkedListBox2.Items.Add("Beijing");
        checkedListBox2.Items.Add("Tokyo");*/

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zavrsiPotez_Click(object sender, EventArgs e)
        {
            int ind2 = -1;
            bool uRedu = true;
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                CheckState st = checkedListBox2.GetItemCheckState(checkedListBox2.Items.IndexOf(i));
                if (st == CheckState.Checked)
                {
                    if(ind2 != -1)
                    {
                        uRedu = false;
                    }
                    else
                    {
                        ind2 = i;
                    }
                }    
            }

            int ind1 = -1;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState st = checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(i));
                if (st == CheckState.Checked)
                {
                    if (ind1 != -1)
                    {
                        uRedu = false;
                    }
                    else
                    {
                        ind1 = i;
                    }
                }
            }

            if(!uRedu)
            {
                MessageBox.Show("Greska. Mozete samo jedan aerodrom da izaberete.");
            }
            
        }
    }
}
