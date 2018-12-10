using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursyPKS
{
    public partial class PolaczeniaForm : Form
    {
        public PolaczeniaForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BckBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Psg = new PsgForm();
            Psg.Closed += (s, args) => this.Close();
            Psg.Show();
        }
    }
}
