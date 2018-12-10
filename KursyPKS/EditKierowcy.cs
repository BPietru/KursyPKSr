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
    public partial class EditKierowcy : Form
    {
        private bool edit;
        private KIEROWCY Kierowca;
        private PKSTEntities1 BAZA = new PKSTEntities1();

        public EditKierowcy()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public EditKierowcy(KIEROWCY Kierowca)
        {
            InitializeComponent();
            edit = true;
            this.Kierowca = Kierowca;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = Kierowca.IMIE.ToString();
            textBox2.Text = Kierowca.NAZWISKO.ToString();
            textBox3.Text = Kierowca.PESEL.ToString();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LU = new KierowcyUpForm();
            LU.Closed += (s, args) => this.Close();
            LU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {

                string query = "INSERT INTO dbo.KIEROWCY (IMIE, NAZWISKO, PESEL) " +
                           "VALUES (@IMIE, @NAZWISKO, @PESEL) ";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@IMIE", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@NAZWISKO", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@PESEL", SqlDbType.VarChar, 50).Value = textBox3.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            else
            {
                string query = "UPDATE dbo.KIEROWCY SET IMIE = @IMIE, NAZWISKO =  @NAZWISKO, PESEL = @PESEL WHERE K_ID = @K_ID";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@K_ID", SqlDbType.Int).Value = Kierowca.K_ID;
                    cmd.Parameters.Add("@IMIE", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@NAZWISKO", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@PESEL", SqlDbType.VarChar, 50).Value = textBox3.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }
    }
}
