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
    public partial class LookUpForm : Form
    {
        PKSTEntities1 BAZA = new PKSTEntities1();

        private int stan = 0;

        public LookUpForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public LookUpForm(int s)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.stan = s;

            if(this.stan == 1)
            {
                 //Source.DataSource = BAZA.AUTOKARies.Where(x => x.A_ID == 3).ToList();
                 Source.DataSource = BAZA.AUTOKARies.ToList();
            }

        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dsg = new DsgForm();
            Dsg.Closed += (s, args) => this.Close();
            Dsg.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (this.stan == 0)
            {
                this.Hide();
                var EK = new EditKierowcy();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 1)
            {
                this.Hide();
                var EK = new EditAutokary();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 2)
            {
                this.Hide();
                var EK = new EditKierunek();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 3)
            {
                this.Hide();
                var EK = new EditMsc();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 4)
            {
                this.Hide();
                var EK = new EditKursy();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 5)
            {
                this.Hide();
                var EK = new EditTrasy();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (this.stan == 0)
            {
                this.Hide();
                var EK = new EditKierowcy();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 1)
            {
                if (dataGridView1.SelectedCells.Count != 0)
                {
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        int t = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                        var BUS = BAZA.AUTOKARies.Where(x => x.A_ID.Equals(t)).FirstOrDefault();
                        EditAutokary okno = new EditAutokary(BUS);
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

            if (this.stan == 2)
            {
                this.Hide();
                var EK = new EditKierunek();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 3)
            {
                this.Hide();
                var EK = new EditMsc();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 4)
            {
                this.Hide();
                var EK = new EditKursy();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }

            if (this.stan == 5)
            {
                this.Hide();
                var EK = new EditTrasy();
                EK.Closed += (s, args) => this.Close();
                EK.Show();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string query = " DELETE FROM dbo.AUTOKARY WHERE A_ID = @A_ID ";

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
                cmd.Parameters.Add("@A_ID", SqlDbType.Int).Value = tc;
                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                //RefreshGrids();

            }

            Source.DataSource = BAZA.AUTOKARies.ToList();
        }
    }
}
