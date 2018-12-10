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
    public partial class EditMsc : Form
    {
        private bool edit;
        private MIEJSCOWOSC msc;
        private PKSTEntities1 BAZA = new PKSTEntities1();

        public EditMsc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public EditMsc(MIEJSCOWOSC msc)
        {
            InitializeComponent();
            edit = true;
            this.msc = msc;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = msc.NAZWA.ToString();
            textBox2.Text = msc.KOD_POCZTOWY.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LU = new MiastUpForm();
            LU.Closed += (s, args) => this.Close();
            LU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {

                string query = "INSERT INTO dbo.MIEJSCOWOSC (NAZWA, KOD_POCZTOWY) " +
                           "VALUES (@NAZWA, @KOD_POCZTOWY) ";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@NAZWA", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@KOD_POCZTOWY", SqlDbType.VarChar, 50).Value = textBox2.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            else
            {
                string query = "UPDATE dbo.MIEJSCOWOSC SET NAZWA = @NAZWA, KOD_POCZTOWY =  @KOD_POCZTOWY WHERE M_ID = @M_ID";

                // create connection and command
                string connectionString = @"Data Source=DESKTOP-NV4L2O0;Initial Catalog=PKST;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@M_ID", SqlDbType.Int).Value = msc.M_ID;
                    cmd.Parameters.Add("@NAZWA", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@KOD_POCZTOWY", SqlDbType.VarChar, 50).Value = textBox2.Text;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }
    }
}
