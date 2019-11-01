using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_to_Life
{
    public partial class MiniToLifePlayerRegister : Form
    {
        List<string> MiniaturesP1 = new List<string>();
        List<string> MiniaturesP2 = new List<string>();
        string ModelNaam;
        public MiniToLifePlayerRegister(string Naam)
        {
            ModelNaam = Naam;
            InitializeComponent();
        }

        private void P1_MR_Click(object sender, EventArgs e)
        {
            MTL_Register_Mini settingsForm = new MTL_Register_Mini();
            settingsForm.Show();
            MiniaturesP1.Add(ModelNaam);
            LB_RM_P1.Items.Add(string.Join(Environment.NewLine, TB_naam_P1.Text));
        }

        private void P2_MR_Click(object sender, EventArgs e)
        {
            MiniaturesP2.Add(TB_naam_P2.Text);
            LB_RM_P2.Items.Add(string.Join(Environment.NewLine, TB_naam_P2.Text));
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection myConnection = new SqlConnection("user id=Project;password=Project;server=192.168.5.170;Trusted_Connection=yes;database=Project;connection timeout=30");
            try
            {
                myConnection.Open();
                MessageBox.Show("It works");
            }
            catch (Exception ex) //gooit een error als string
            {
                MessageBox.Show(ex.ToString(), "Er is een fout");
            }
            */
            MiniToLife settingsForm = new MiniToLife(MiniaturesP1, MiniaturesP2);
            settingsForm.Show();
            this.Hide();
        }
    }
}
