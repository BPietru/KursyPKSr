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
    public partial class TygodniowyForm : Form
    {

        PKSTEntities1 BAZA = new PKSTEntities1();

        public TygodniowyForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BckBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dsg = new DsgForm();
            Dsg.Closed += (s, args) => this.Close();
            Dsg.Show();
        }

        private void TygBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                Source.DataSource = BAZA.TYGODNIOWY_RAPORT_P(DateTime.Parse(DataBox1.Text), Int32.Parse(textBox1.Text)).ToList();
            }
            catch (Exception v)
            {
                MessageBox.Show("Podaj dzisiejszą datę");
            }
        }
    }
}
