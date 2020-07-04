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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = textBox4.Text;
            string E = textBox5.Text;
            




            if (a != "" && b != "" && c != "" && d != "" && E != "" && E != "" )
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO employee VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + E + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry Recorded");

                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    


                }
                catch (SqlException se)
                {
                    MessageBox.Show("" + se);
                }
            }
            else
            {
                MessageBox.Show("Fill All Coloms");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM employee";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "employee");
            dataGridView1.DataSource = ds.Tables["employee"];
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM employee";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "employee");
            dataGridView2.DataSource = ds.Tables["employee"];
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox15.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox14.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox13.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox12.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox11.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = textBox15.Text;
            string b = textBox14.Text;
            string c = textBox13.Text;
            string d = textBox12.Text;
            string E = textBox11.Text;
            

            textBox15.Text = null;
            textBox14.Text = null;
            textBox13.Text = null;
            textBox12.Text = null;
            textBox11.Text = null;
            


            SqlConnection dana = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
            string update = ("UPDATE employee SET emp_name='" + a + "',address='" + c + "',phone_no='" + d + "',emp_email='" + E + "' WHERE e_id='" + b + "'");
            SqlCommand cmd = new SqlCommand(update, dana);

            try
            {
                dana.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Successfull");
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM employee";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "employee");
            dataGridView2.DataSource = ds.Tables["employee"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM employee";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "employee");
            dataGridView3.DataSource = ds.Tables["employee"];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = textBox16.Text;

            textBox16.Text = null;

            if (a != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                String del = "DELETE FROM employee WHERE e_id='" + a + "' ";

                SqlCommand cmd = new SqlCommand(del, con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DELETE SUCCESSFULL");

                    textBox1.Text = null;
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
            string qry = "SELECT *FROM employee";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "employee");
            dataGridView3.DataSource = ds.Tables["employee"];

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Home i = new Home();
            i.Show();
            this.Hide();
        }
    }
    }

