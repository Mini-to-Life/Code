using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Mini_to_Life
{
    public partial class Progress : Form
    {

        public Progress()
        {
            InitializeComponent();
            label1.Text = "Registering Model";
            System.Threading.Thread.Sleep(5000);
            label2.Text = "Succesfully Registered";
            System.Threading.Thread.Sleep(3000);
            this.Close();
        }
    }
}

