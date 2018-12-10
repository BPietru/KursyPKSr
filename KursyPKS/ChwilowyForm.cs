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
    public partial class ChwilowyForm : Form
    {

        PKSTEntities1 BAZA = new PKSTEntities1();

        public ChwilowyForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BckBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dsg = new DsgForm();
            Dsg.Closed += (s, args) => this.Close();
            Dsg.Show();
        }

        private void ChwBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Source.DataSource = BAZA.KIEROWCY_W_TRASIE(DateTime.Parse(DataBox1.Text)).ToList();
            }
            catch(Exception v)
            {
                MessageBox.Show("Podaj dzisiejszą datę");
            }
        }
    }
}
