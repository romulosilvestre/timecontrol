using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void blocosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void apresentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Apresentacao().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void porQueFazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PorqueFazer().Show();
        }

        private void definaSeusObjetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Objetivo().Show();
        }
    }
}
