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
    public partial class EditAutokary : Form
    {
        private bool edit;
        private AUTOKARY bus;
        private PKSTEntities1 BAZA = new PKSTEntities1();

        public EditAutokary()
        {
            InitializeComponent();
            this.CenterToScreen();
            edit = false;
        }

        public EditAutokary(AUTOKARY bus)
        {
            InitializeComponent();
            edit = true;
            this.bus = bus;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = bus.K_ID.ToString();
            textBox2.Text = bus.NR_REJ.ToString();
            textBox3.Text = bus.MARKA.ToString();
            textBox5.Text = bus.MODEL.ToString();
            textBox4.Text = bus.LICZBA_MIEJSC.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LU = new LookUpForm(1);
            LU.Closed += (s, args) => this.Close();
            LU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {

                string query = "INSERT INTO dbo.AUTOKARY (K_ID, NR_REJ, MARKA, MODEL, LICZBA_MIEJSC) " +
                           "VALUES (@K_ID, @NR_REJ, @MARKA, @MODEL, @LICZBA_MIEJSC) ";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@K_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@NR_REJ", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@MARKA", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.VarChar, 50).Value = textBox5.Text;
                    cmd.Parameters.Add("@LICZBA_MIEJSC", SqlDbType.VarChar, 50).Value = textBox4.Text;


                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            else
            {
                string query = "UPDATE dbo.AUTOKARY SET K_ID = @K_ID, NR_REJ =  @NR_REJ, MARKA = @MARKA, MODEL = @MODEL, LICZBA_MIEJSC = @LICZBA_MIEJSC WHERE A_ID = @A_ID";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@A_ID", SqlDbType.Int).Value = bus.K_ID;
                    cmd.Parameters.Add("@K_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@NR_REJ", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@MARKA", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.VarChar, 50).Value = textBox5.Text;
                    cmd.Parameters.Add("@LICZBA_MIEJSC", SqlDbType.VarChar, 50).Value = textBox4.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }
    }
}
