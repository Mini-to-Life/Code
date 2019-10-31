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
    public partial class MiniToLifePlayerRegister : Form
    {
        public MiniToLifePlayerRegister()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            MiniToLife settingsForm = new MiniToLife();
            settingsForm.Show();
            this.Hide();
        }
    }
}
