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
    public partial class TrasaUpForm : Form
    {

        PKSTEntities1 BAZA = new PKSTEntities1();

        public TrasaUpForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            Source.DataSource = BAZA.TRASAs.OrderBy(X => X.KU_ID).ToList();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dsg = new Dsg0();
            Dsg.Closed += (s, args) => this.Close();
            Dsg.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dsg = new EditTrasy();
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
                    int t2 = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
                    var trs = BAZA.TRASAs.Where(x => x.KU_ID.Equals(t) && x.M_ID.Equals(t2)).FirstOrDefault();
                    EditTrasy okno = new EditTrasy(trs);
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
            string query = " DELETE FROM dbo.TRASA WHERE KU_ID = @KU_ID AND M_ID = @M_ID ";

            // create connection and command
            string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values

                int t = dataGridView1.CurrentCell.RowIndex;
                string str, str2;
                str = dataGridView1.Rows[t].Cells[0].Value.ToString();
                str2 = dataGridView1.Rows[t].Cells[1].Value.ToString();
                int tc = Int32.Parse(str);
                int tc2 = Int32.Parse(str2);
                // int sel = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cmd.Parameters.Add("@KU_ID", SqlDbType.Int).Value = tc;
                cmd.Parameters.Add("@M_ID", SqlDbType.Int).Value = tc2;
                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                //RefreshGrids();

            }

            Source.DataSource = BAZA.TRASAs.OrderBy(X => X.KU_ID).ToList();
        }
    }
}
