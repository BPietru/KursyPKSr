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
    public partial class EditKursy : Form
    {

        private bool edit;
        private KURSY krs;
        private PKSTEntities1 BAZA = new PKSTEntities1();


        public EditKursy()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public EditKursy(KURSY krs)
        {
            InitializeComponent();
            edit = true;
            this.krs = krs;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = krs.A_ID.ToString();
            textBox2.Text = krs.POCZATEK_ID.ToString();
            textBox3.Text = krs.KONIEC_ID.ToString();
            textBox4.Text = krs.ID_KIERUNKU.ToString();
            textBox5.Text = krs.DATA.ToString();
            textBox6.Text = krs.CZAS_WYJAZDU.ToString();
            textBox7.Text = krs.PASAZEROWIE.ToString();
            textBox8.Text = krs.SYGNATURA_KURSU.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LU = new KursyUpForm();
            LU.Closed += (s, args) => this.Close();
            LU.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {

                string query = "INSERT INTO dbo.KURSY (A_ID, POCZATEK_ID, KONIEC_ID, ID_KIERUNKU, DATA, CZAS_WYJAZDU, PASAZEROWIE, SYGNATURA_KURSU ) " +
                           "VALUES (@A_ID, @POCZATEK_ID, @KONIEC_ID, @ID_KIERUNKU, @DATA, @CZAS_WYJAZDU, @PASAZEROWIE, @SYGNATURA_KURSU) ";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@A_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@POCZATEK_ID", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@KONIEC_ID", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@ID_KIERUNKU", SqlDbType.VarChar, 50).Value = textBox4.Text;
                    cmd.Parameters.Add("@DATA", SqlDbType.Date, 50).Value = textBox5.Text;
                    cmd.Parameters.Add("@CZAS_WYJAZDU", SqlDbType.Time, 50).Value = textBox6.Text;
                    cmd.Parameters.Add("@PASAZEROWIE", SqlDbType.VarChar, 50).Value = textBox7.Text;
                    cmd.Parameters.Add("@SYGNATURA_KURSU", SqlDbType.VarChar, 50).Value = textBox8.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            else
            {
                string query = "UPDATE dbo.KURSY SET A_ID = @A_ID, POCZATEK_ID =  @POCZATEK_ID, KONIEC_ID = @KONIEC_ID, ID_KIERUNKU = @ID_KIERUNKU, DATA =  @DATA, CZAS_WYJAZDU = @CZAS_WYJAZDU, PASAZEROWIE = @PASAZEROWIE, SYGNATURA_KURSU =  @SYGNATURA_KURSU WHERE KU_ID = @KU_ID";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@KU_ID", SqlDbType.Int).Value = krs.KU_ID;
                    cmd.Parameters.Add("@A_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@POCZATEK_ID", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@KONIEC_ID", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@ID_KIERUNKU", SqlDbType.VarChar, 50).Value = textBox4.Text;
                    cmd.Parameters.Add("@DATA", SqlDbType.Date, 50).Value = textBox5.Text;
                    cmd.Parameters.Add("@CZAS_WYJAZDU", SqlDbType.Time, 50).Value = textBox6.Text;
                    cmd.Parameters.Add("@PASAZEROWIE", SqlDbType.VarChar, 50).Value = textBox7.Text;
                    cmd.Parameters.Add("@SYGNATURA_KURSU", SqlDbType.VarChar, 50).Value = textBox8.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }

        }
    }
}
