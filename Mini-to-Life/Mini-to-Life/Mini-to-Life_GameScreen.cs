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
        public MiniToLife()
        {
            InitializeComponent();
        }

        private void PB_logo_Click(object sender, EventArgs e)
        {
            MiniToLifePlayerRegister settingsForm = new MiniToLifePlayerRegister();
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
