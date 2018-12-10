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
    public partial class PsgForm : Form
    {
        public PsgForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BckBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Wlcm = new WelcomeForm();
            Wlcm.Closed += (s, args) => this.Close();
            Wlcm.Show();
        }

        private void LstBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Lst = new PolaczeniaForm();
            Lst.Closed += (s, args) => this.Close();
            Lst.Show();
        }

        private void ZndBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Fnd = new FindForm();
            Fnd.Closed += (s, args) => this.Close();
            Fnd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Fnd = new PrzebiegForm();
            Fnd.Closed += (s, args) => this.Close();
            Fnd.Show();
        }
    }
}
