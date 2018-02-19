using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraCLI
{
    public partial class FormGra : Form
    {
        public FormGra()
        {
            InitializeComponent();
        }

        private void labelWylosowano_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrzerwij_Click(object sender, EventArgs e)
        {
            panelStatystyki.Visible = true;
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            panelStatystyki.Visible = false;
        }
    }
}
