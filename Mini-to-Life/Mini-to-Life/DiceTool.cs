using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_to_Life
{
    public partial class DiceTool : Form
    {
        public DiceTool()
        {
            InitializeComponent();
        }

        private void BT_rollDice_Click(object sender, EventArgs e)
        {
            var DicesD6 = new List<int>();
            int D6 = Convert.ToInt32(NUD_D6.Value);
            int dice6;
            Random randomD6 = new Random();
            for (int i = 0; i != D6; i++)
            {
                dice6 = randomD6.Next(1, 7);
                if (CB_R1.Checked)
                {
                    dice6 = randomD6.Next(1, 7);
                    DicesD6.Add(dice6);
                }
                else
                {
                    DicesD6.Add(dice6);
                }
            }
            string resultD6 = string.Join(", ", DicesD6);
            TB_Rolled_D6.Text = resultD6;

            var DicesD3 = new List<int>();
            int D3 = Convert.ToInt32(NUD_D3.Value);
            int dice3;
            Random randomD3 = new Random();
            for (int i = 0; i != D3; i++)
            {
                dice3 = randomD3.Next(1, 4);
                if (CB_R1.Checked)
                {
                    dice3 = randomD3.Next(1, 4);
                    DicesD3.Add(dice3);
                }
                else
                {
                    DicesD3.Add(dice3);
                }
            }
            string resultD3 = string.Join(", ", DicesD3);
            TB_Rolled_D3.Text = resultD3;

            int TotaalD6 = 0;
            foreach (int num in DicesD6)
            {
               TotaalD6 = TotaalD6 + num;
            }
            TB_Totaal_D6.Text = Convert.ToString(TotaalD6);

            int TotaalD3 = 0;
            foreach (int num in DicesD3)
            {
                TotaalD3 = TotaalD3 + num;
            }
            TB_Totaal_D3.Text = Convert.ToString(TotaalD3);
        }
    }
}
