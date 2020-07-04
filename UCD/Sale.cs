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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Customer";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Customer";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox15.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox16.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox17.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox18.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox19.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox20.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox21.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox22.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox23.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox24.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox25.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home E = new Home();
            E.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox15.Text;

            textBox15.Text = null;

            if (a != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                String del = "DELETE FROM Customer WHERE v_no='" + a + "' ";

                SqlCommand cmd = new SqlCommand(del, con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DELETE SUCCESSFULL");

                    textBox15.Text = null;

                    textBox16.Text = null;
                    textBox17.Text = null;
                    textBox18.Text = null;
                    textBox19.Text = null;
                    textBox20.Text = null;
                    textBox21.Text = null;
                    textBox22.Text = null;
                    textBox23.Text = null;
                    textBox24.Text = null;
                    textBox25.Text = null;
                    textBox13.Text = null;




                }
                catch (SqlException se)
                {
                    MessageBox.Show("" + se);
                }
            }
            else
            {
                MessageBox.Show("Fill Colom");
            }

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM Customer";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"];
        }
    }
}
