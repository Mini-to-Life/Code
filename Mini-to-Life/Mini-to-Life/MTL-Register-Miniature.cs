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
        public string ModelNaam;
        public MTL_Register_Mini()
        {
            InitializeComponent();
        }

        public void BT_OK_Click(object sender, EventArgs e)
        {
            //string ModelNaam = TB_ModelName.Text;
            this.Close();
        }

        private void MTL_Register_Mini_Load(object sender, EventArgs e)
        {

        }
    }
}
