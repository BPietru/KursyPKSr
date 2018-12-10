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
    public partial class DsgForm : Form
    {
        public DsgForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BckBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Wlcm = new WelcomeForm();
            Wlcm.Closed += (s, args) => this.Close();
            Wlcm.Show();
        }

        private void TygBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Tyg = new TygodniowyForm();
            Tyg.Closed += (s, args) => this.Close();
            Tyg.Show();
        }

        private void AktBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Chw = new ChwilowyForm();
            Chw.Closed += (s, args) => this.Close();
            Chw.Show();
        }

        private void HarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Hmg = new HarmonogramForm();
            Hmg.Closed += (s, args) => this.Close();
            Hmg.Show();
        }

        private void AutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new LookUpForm(1);
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }

        private void KurBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            var Loo = new KursyUpForm();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();

        }

        private void MscBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new MiastUpForm();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }

        private void KrcBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new KierowcyUpForm();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }

        private void TraBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new TrasaUpForm();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }

        private void KieBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new KierunkiUpForm();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new AutokaryKierowcyQuery();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }
    }
}
