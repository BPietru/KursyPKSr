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
    public partial class EditKierunek : Form
    {
        private bool edit;
        private KIERUNEK Kierunek;
        private PKSTEntities1 BAZA = new PKSTEntities1();

        public EditKierunek()
        {
            InitializeComponent();
            this.CenterToScreen();
            edit = false;
        }
        public EditKierunek(KIERUNEK Kierunek)
        {
            InitializeComponent();
            edit = true;
            this.Kierunek = Kierunek;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = Kierunek.NAZWA_KIERUNKU.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LU = new KierunkiUpForm();
            LU.Closed += (s, args) => this.Close();
            LU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {

                string query = "INSERT INTO dbo.KIERUNEK (NAZWA_KIERUNKU) " +
                           "VALUES (@NAZWA_KIERUNKU) ";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@NAZWA_KIERUNKU", SqlDbType.VarChar, 50).Value = textBox1.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            else
            {
                string query = "UPDATE dbo.KIERUNEK SET NAZWA_KIERUNKU = @NAZWA_KIERUNKU WHERE ID_KIERUNKU = @ID_KIERUNKU";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@ID_KIERUNKU", SqlDbType.Int).Value = Kierunek.ID_KIERUNKU;
                    cmd.Parameters.Add("@NAZWA_KIERUNKU", SqlDbType.VarChar, 50).Value = textBox1.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }
    }
}
