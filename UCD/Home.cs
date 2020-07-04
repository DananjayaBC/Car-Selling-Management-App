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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicalInventory b = new VehicalInventory();
            b.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale d = new Sale();
            d.Show();
            this.Hide();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIN g = new LogIN();
            g.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee h = new Employee();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          


        }
    }
}
