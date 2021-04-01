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

namespace application_2.Forms
{
    public partial class FormAddNewItems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SOFTTRONIX COMPUTER SOLUTIONS\DB\StockDB.mdf;Integrated Security=True;Connect Timeout=30");
        public FormAddNewItems()
        {
            InitializeComponent();
        }

        private void FormAddNewItems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Stock values('" +comboBox1.Text+ "','" +textBox1.Text+ "','" +textBox2.Text+ "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Data Inserted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox2.Text = string.Empty;
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
