using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autofact
{
    public partial class detailsclient : Form
    {
        public string nom;
        public string prenom;

        public detailsclient()
        {
            InitializeComponent();
        }

        private void detailsclient_Load(object sender, EventArgs e)
        {
            label_nom.Text = nom;
            label_prenom.Text = prenom;
        }

        private void label_nom_Click(object sender, EventArgs e)
        {

        }
    }
}
