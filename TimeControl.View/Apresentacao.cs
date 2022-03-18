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
    public partial class Apresentacao : Form
    {
        public Apresentacao()
        {
            InitializeComponent();
        }

        private void Apresentacao_Load(object sender, EventArgs e)
        {
            var url = "https://www.google.com.br";
            webBrowser1.Navigate(new Uri(url));
        }
    }
}
