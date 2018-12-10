using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursyPKS
{
    public partial class KursyUpForm : Form
    {

        PKSTEntities1 BAZA = new PKSTEntities1();

        public KursyUpForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            Source.DataSource = BAZA.KURSies.ToList();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loo = new Dsg0();
            Loo.Closed += (s, args) => this.Close();
            Loo.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dsg = new EditKursy();
            Dsg.Closed += (s, args) => this.Close();
            Dsg.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int t = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                    var krs = BAZA.KURSies.Where(x => x.KU_ID.Equals(t)).FirstOrDefault();
                    EditKursy okno = new EditKursy(krs);
                    okno.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wybierz rekord");
                }
            }
            else
            {
                MessageBox.Show("Wybierz rekord");
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string query = " DELETE FROM dbo.KURSY WHERE KU_ID = @KU_ID ";

            // create connection and command
            string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values

                int t = dataGridView1.CurrentCell.RowIndex;
                string str;
                str = dataGridView1.Rows[t].Cells[0].Value.ToString();
                int tc = Int32.Parse(str);
                // int sel = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cmd.Parameters.Add("@KU_ID", SqlDbType.Int).Value = tc;
                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                //RefreshGrids();

            }

            Source.DataSource = BAZA.KURSies.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                var temp = Int32.Parse(textBox1.Text);
                Source.DataSource = BAZA.KURSies.Where(x => x.KU_ID == temp).ToList();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var temp = Int32.Parse(textBox1.Text);
                Source.DataSource = BAZA.KURSies.Where(x => x.A_ID == temp).ToList();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var temp = Int32.Parse(textBox1.Text);
                Source.DataSource = BAZA.KURSies.Where(x => x.POCZATEK_ID == temp).ToList();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                var temp = Int32.Parse(textBox1.Text);
                Source.DataSource = BAZA.KURSies.Where(x => x.KONIEC_ID == temp).ToList();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                var temp = Int32.Parse(textBox1.Text);
                Source.DataSource = BAZA.KURSies.Where(x => x.ID_KIERUNKU == temp).ToList();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                var temp = DateTime.Parse(textBox1.Text);
                Source.DataSource = BAZA.KURSies.Where(x => x.DATA == temp).ToList();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Source.DataSource = BAZA.KURSies.ToList();
        }
    }
}
