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
        public MiniToLifePlayerRegister()
        {
            InitializeComponent();
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
            MiniToLife settingsForm = new MiniToLife();
            settingsForm.Show();
            this.Hide();
        }
    }
}
