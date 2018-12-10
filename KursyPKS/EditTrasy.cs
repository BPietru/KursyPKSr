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
    public partial class EditTrasy : Form
    {

        private bool edit;
        private TRASA trs;
        private PKSTEntities1 BAZA = new PKSTEntities1();

        public EditTrasy()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public EditTrasy(TRASA trs)
        {
            InitializeComponent();
            edit = true;
            this.trs = trs;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = trs.KU_ID.ToString();
            textBox2.Text = trs.M_ID.ToString();
            textBox3.Text = trs.NUMER_PRZYSTANKU.ToString();
            textBox4.Text = trs.CZAS_PRZEJAZDU.ToString();
            textBox5.Text = trs.CENA_BILETU.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LU = new TrasaUpForm();
            LU.Closed += (s, args) => this.Close();
            LU.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {

                string query = "INSERT INTO dbo.TRASA (KU_ID, M_ID, NUMER_PRZYSTANKU, CZAS_PRZEJAZDU, CENA_BILETU ) " +
                           "VALUES (@KU_ID, @M_ID, @NUMER_PRZYSTANKU, @CZAS_PRZEJAZDU, @CENA_BILETU) ";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@KU_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@M_ID", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@NUMER_PRZYSTANKU", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@CZAS_PRZEJAZDU", SqlDbType.Time, 50).Value = textBox4.Text;
                    cmd.Parameters.Add("@CENA_BILETU", SqlDbType.Money, 50).Value = textBox5.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            else
            {
                string query = "UPDATE dbo.TRASA SET KU_ID = @KUI_ID, M_ID = @MI_ID, NUMER_PRZYSTANKU = @NUMER_PRZYSTANKU, CZAS_PRZEJAZDU = @CZAS_PRZEJAZDU, CENA_BILETU = @CENA_BILETU WHERE KU_ID = @KU_ID AND M_ID = @M_ID";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@KU_ID", SqlDbType.Int).Value = trs.KU_ID;
                    cmd.Parameters.Add("@M_ID", SqlDbType.Int).Value = trs.M_ID;
                    cmd.Parameters.Add("@KUI_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@MI_ID", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@NUMER_PRZYSTANKU", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@CZAS_PRZEJAZDU", SqlDbType.Time, 50).Value = textBox4.Text;
                    cmd.Parameters.Add("@CENA_BILETU", SqlDbType.Money, 50).Value = textBox5.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        private void EditTrasy_Load(object sender, EventArgs e)
        {

        }
    }
}
