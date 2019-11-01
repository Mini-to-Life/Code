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
    public partial class MTL_Register_Mini : Form
    {
        public MTL_Register_Mini()
        {
            InitializeComponent();
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            string Naam = TB_ModelName.Text;
            MiniToLifePlayerRegister settingsForm = new MiniToLifePlayerRegister(Naam);
            this.Close();
        }
    }
}
