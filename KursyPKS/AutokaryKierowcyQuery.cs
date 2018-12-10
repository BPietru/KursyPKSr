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
    public partial class AutokaryKierowcyQuery : Form
    {

        PKSTEntities1 BAZA = new PKSTEntities1();

        public AutokaryKierowcyQuery()
        {
            InitializeComponent();
            this.CenterToScreen();
            Source.DataSource = BAZA.AUTOKARY_KIEROWCY.ToList();
        }

        private void BckBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new DsgForm();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }
    }
}
