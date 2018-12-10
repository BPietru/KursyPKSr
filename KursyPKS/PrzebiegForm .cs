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
    public partial class PrzebiegForm : Form
    {
        PKSTEntities1 BAZA = new PKSTEntities1();

        public PrzebiegForm()
        {
            InitializeComponent();
        }

        private void TygBtn2_Click(object sender, EventArgs e)
        {
            Source.DataSource = BAZA.PRZEBIEG_TRASY(Int32.Parse(textBox1.Text)).ToList();
        }

        private void BckBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Fnd = new PsgForm();
            Fnd.Closed += (s, args) => this.Close();
            Fnd.Show();
        }
    }
}
