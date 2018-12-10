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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.SelectedIndex = 0;
        }

        private void DyzBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    this.Hide();
                    var Dsg0 = new Dsg0();
                    Dsg0.Closed += (s, args) => this.Close();
                    Dsg0.Show();
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    this.Hide();
                    var Dsg = new DsgForm();
                    Dsg.Closed += (s, args) => this.Close();
                    Dsg.Show();
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    this.Hide();
                    var Dsg = new PsgForm();
                    Dsg.Closed += (s, args) => this.Close();
                    Dsg.Show();
                }
            }
            catch(Exception v)
            {
                MessageBox.Show("Wybierz uzytkownika");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
