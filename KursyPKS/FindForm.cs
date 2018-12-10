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
    public partial class FindForm : Form
    {
        PKSTEntities1 BAZA = new PKSTEntities1();

        public FindForm()
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

        private void TygBtn2_Click(object sender, EventArgs e)
        {
            var tempd = DateTime.Parse(textBox2.Text);
            var tempt = TimeSpan.Parse(textBox3.Text);
           // tempd.Hour = tempt.Hours;

            Console.WriteLine(comboBox1.SelectedIndex + 1);
            Console.WriteLine(comboBox2.SelectedIndex + 1);
            Console.WriteLine(tempd);
            Console.WriteLine(tempt);

            Source.DataSource = BAZA.KURSies.Where(x => x.POCZATEK_ID == (comboBox1.SelectedIndex + 1) && x.KONIEC_ID == (comboBox2.SelectedIndex + 1) && x.DATA == tempd && x.CZAS_WYJAZDU >= tempt).ToList();

        }
    }
}
