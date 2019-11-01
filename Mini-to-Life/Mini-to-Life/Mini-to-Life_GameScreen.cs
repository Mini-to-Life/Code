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
    public partial class MiniToLife : Form
    {
        List<string> MiniP1 = new List<string>();
        List<string> MiniP2 = new List<string>();
        public MiniToLife(List<string> listP1, List<string> listP2)
        {
            this.MiniP1 = listP1;
            this.MiniP2 = listP2;
            InitializeComponent();
            foreach (string itemP1 in MiniP1)
            {
                CB_Modelselector_player1.Items.Add(itemP1);
            }
            foreach (string itemP2 in MiniP2)
            {
                CB_Modelselector_player2.Items.Add(itemP2);
            }

        }

        private void PB_logo_Click(object sender, EventArgs e)
        {
            MiniToLifePlayerRegister settingsForm = new MiniToLifePlayerRegister(null);
            settingsForm.Show();
            this.Hide();
        }

        private void BT_DiceTool_Click(object sender, EventArgs e)
        {
            DiceTool settingsForm = new DiceTool();
            settingsForm.Show();
        }
    }
}
