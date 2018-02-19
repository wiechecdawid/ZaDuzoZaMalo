using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraGUI
{
    public partial class ZaDuzoZaMalo : Form
    {
        public ZaDuzoZaMalo()
        {
            InitializeComponent();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (buttonStartStop.Text == "Nowa gra") buttonStartStop.Text = "Przerwij";
            else buttonStartStop.Text = "Nowa gra";
        }
    }
}
