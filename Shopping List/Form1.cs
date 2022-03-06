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


namespace Shopping_List
{
    public partial class List : Form
    {

        //declare gloabal variables
        //path to database
        string path = @"Data Source=DESKTOP-CC8GJQQ\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        int ID;
        string importance;
        DataTable dt;
        SqlDataAdapter adapter;


        public List()
        {
            InitializeComponent();
            conn = new SqlConnection(path);
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());//has the table ID
            txtBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numUpDown1.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            comboBox1.SelectedIndex = comboBox1.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            
            btnDelete.Enabled=true;
            btnUpdate.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "" || comboBox1.Text == "" || numUpDown1.Value == 0)
            {
                MessageBox.Show("Input item to add and its importance");
            }
            else 
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into Items(Item_Name,Item_Quantity,Item_Importance) values('" + txtBoxName.Text.ToString().Trim() + "','" + numUpDown1.Text + "','" + comboBox1.Text.ToString().Trim() + "' ) ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your data has been saved in the database");

                    //call the clear function to empty the textbox
                    clear();
                    //display soon as you press save
                    display();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        //clear the textbox
        public void clear()
        {
            txtBoxName.Text = "";
            comboBox1.Text = "";

        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new SqlDataAdapter("select * from Items", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void List_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Urgent");
            comboBox1.Items.Add("Not Urgent");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("delete from Items where Item_Id='" + ID + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("You have succesfully deleted the entry!");
                display();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "" || comboBox1.Text == "" || numUpDown1.Value == 0)
            {
                MessageBox.Show("Fill in the empty places");
            }
            else 
            {
                conn.Open();
                cmd = new SqlCommand("update Items set Item_Name='" + txtBoxName.Text + "', Item_Quantity='" + numUpDown1.Value + "', Item_Importance='" + comboBox1.Text + "' where Item_Id='" + ID + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                //,
                MessageBox.Show("Your data has been updated");
                display();
            }
            
            
        }
    }
}
