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
    public partial class VehicalInventory : Form
    {
        public VehicalInventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = textBox4.Text;
            string E = textBox5.Text;
            string f = comboBox1.Text;
            string g = textBox6.Text;
            string h = comboBox3.Text;




            if (a != "" && b != "" && c != "" && d != "" && E != "" && E != "" && f != "" && g != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO vehical VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + E + "','" + f + "','" + g + "','" + h + "')";
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
                    comboBox1.Text = null;
                    textBox6.Text = null;
                    comboBox3.Text=null;


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
            comboBox1.Text = null;
            textBox6.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView1.DataSource = ds.Tables["vehical"];
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
           

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string vehicalName = textBox12.Text;
            string Brand = textBox11.Text;
            string Name = textBox10.Text;
            string Year = textBox9.Text;
            string engunCc = textBox8.Text;
            string fuelType = comboBox2.Text;
            string Price = textBox7.Text;
            string Branch = comboBox4.Text;
            

            textBox12.Text = null;
            textBox11.Text = null;
            textBox10.Text = null;
            textBox9.Text = null;
            textBox8.Text = null;
            textBox7.Text = null;
            
            comboBox2.Text = null;
            comboBox4.Text = null;


            SqlConnection dana = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
            string update = ("UPDATE vehical SET brand='" + Brand + "',v_name='" + Name + "',year='" + Year + "',engine_cc='" + engunCc + "' ,fuel_type='" + fuelType + "',price='" + Price + "',Branch='" + Branch + "' WHERE v_no='" + vehicalName + "'");
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
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView1.DataSource = ds.Tables["vehical"];
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;

            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView2.DataSource = ds.Tables["vehical"];
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string a = textBox14.Text;

            textBox14.Text = null;

            if (a != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                String del = "DELETE FROM vehical WHERE v_no='" + a + "' ";

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
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView2.DataSource = ds.Tables["vehical"];


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;


            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView3.DataSource = ds.Tables["vehical"];
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Home c = new Home();
            c.Show();
            this.Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox15.Text = null;
            textBox16.Text = null;
            textBox17.Text = null;
            textBox18.Text = null;
            textBox19.Text = null;
            textBox24.Text = null;
            textBox23.Text = null;
            textBox22.Text = null;
            textBox21.Text = null;
            textBox24.Text = null;
            textBox20.Text = null;
            textBox25.Text = null;
            textBox13.Text = null;
        }

        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox15.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            textBox20.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            textBox21.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            textBox22.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            textBox23.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            textBox24.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            textBox25.Text = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();




        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string aa = textBox15.Text;
            string b = textBox16.Text;
            string c = textBox17.Text;
            string d = textBox18.Text;
            string E = textBox19.Text;
            string ff = textBox20.Text;
            string gg = textBox21.Text;
            string hh = textBox22.Text;
            string ii = textBox23.Text;
            string jj = textBox24.Text;
            string kk = textBox25.Text;
            string ll = textBox13.Text;
            



            textBox16.Text = null;
            textBox17.Text = null;
            textBox18.Text = null;
            textBox19.Text = null;
            textBox24.Text = null;
            textBox23.Text = null;
            textBox22.Text = null;
            textBox21.Text = null;
            textBox24.Text = null;
            textBox20.Text = null;
            textBox25.Text = null;
            textBox13.Text=  null;
            textBox15.Text = null;
            


            if (aa != "" && b != "" && c != "" && d != "" && E != "" && ff != "" && gg != "" && hh != "" && ii != "" && jj != "" && kk != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");


                string qry = "INSERT INTO Customer VALUES('" + aa + "','" + b + "','" + ll + "','" + c + "','" + d + "','" + E + "','" + ff + "','" + gg + "','" + hh + "','" + ii + "','" + jj + "','" + kk + "')";
                string del = "DELETE FROM vehical WHERE v_no='" + aa + "' ";

                SqlCommand cmd = new SqlCommand(del, con);

                SqlCommand cm = new SqlCommand(qry, co);


                try
                {
                    con.Open();
                    co.Open();
                    cm.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Done");

                    String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
                    string qr = "SELECT *FROM vehical";

                    SqlDataAdapter da = new SqlDataAdapter(qr, conString);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "vehical");
                    dataGridView3.DataSource = ds.Tables["vehical"];
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

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_2(object sender, EventArgs e)
        {

            string a = textBox15.Text;

            textBox15.Text = null;

            if (a != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30");
                String del = "DELETE FROM vehical WHERE v_no='" + a + "' ";

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
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView2.DataSource = ds.Tables["vehical"];


        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;


            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT *FROM vehical";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "vehical");
            dataGridView4.DataSource = ds.Tables["vehical"];
        }

        private void dataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox31.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            textBox30.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            textBox29.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            textBox28.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            textBox27.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            textBox26.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
            textBox32.Text = dataGridView4.SelectedRows[0].Cells[6].Value.ToString();
            textBox33.Text = dataGridView4.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        
        {
              searchbyid(txtSearch.Text.Trim());
              txtSearch.Text = null;
        }
        protected void searchbyid(string searchText)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("No Name to search!");

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Pictures\UCD\UCD\Car.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    string sql = "SELECT * FROM vehical WHERE v_name = '" + txtSearch.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("v_name", txtSearch.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView4.DataSource = dt;

                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                }
            }
        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}



