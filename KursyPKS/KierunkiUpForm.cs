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
    public partial class KierunkiUpForm : Form
    {

        PKSTEntities1 BAZA = new PKSTEntities1();

        public KierunkiUpForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            Source.DataSource = BAZA.KIERUNEKs.ToList();
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
            var Dsg = new EditKierunek();
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

                    var Kierunek = BAZA.KIERUNEKs.Where(x => x.ID_KIERUNKU.Equals(t)).FirstOrDefault();
                    EditKierunek okno = new EditKierunek(Kierunek);
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
            string query = " DELETE FROM dbo.KIERUNEK WHERE ID_KIERUNKU = @ID_KIERUNKU ";

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
                cmd.Parameters.Add("@ID_KIERUNKU", SqlDbType.Int).Value = tc;
                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                //RefreshGrids();

            }

            Source.DataSource = BAZA.KIERUNEKs.ToList();
        }
    }
}
