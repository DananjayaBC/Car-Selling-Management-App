using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UCD
{
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM login WHERE userName='" + UserName + "' AND password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    Home a = new Home();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorect User Name or Password");

                    textBox1.Text = null;
                    textBox2.Text = null;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
 }

