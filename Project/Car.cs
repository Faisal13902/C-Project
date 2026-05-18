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
using System.Data.SqlClient;

namespace Project
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
      
        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\faisa\OneDrive\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void populate()
        {
            Con.Open();
            string query = "select * from CarTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDataGridView1.DataSource = ds.Tables[0];
            Con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNmTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text =="" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTb1 values(" + RegNmTb.Text + ",'" + BrandTb.Text + "','" + ModelTb.Text + "','"+AvailableCb.SelectedItem.ToString()+"',"+PriceTb.Text+ ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cars Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(RegNmTb.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTb1 where RegNum='" + RegNmTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Succesfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                } 
            }
        }

        private void CarsDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNmTb.Text = CarsDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarsDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AvailableCb.Text = CarsDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CarsDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNmTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update from CarTb1 set Brand='" + BrandTb.Text + "',Model= '" +ModelTb.Text + "', Available ='" +AvailableCb.SelectedItem.ToString() +"', Price="+PriceTb.Text +"Where RegNum='"+ RegNmTb.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Succesfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
 