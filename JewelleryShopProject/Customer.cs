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

namespace JewelleryShopProject
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void populate()
        {
            con.Open();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("Select * from Customer", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            CustomerDVG.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            items ob = new items();
            ob.Show();
            //ob.Hide();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIL1JHR\\MSSQL2016;Initial Catalog=Windowproject;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public int ID { get; set; }
        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerName.Text == "" || textBoxCustomerPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    SqlParameter p1 = new SqlParameter("@CustomerName", SqlDbType.VarChar);
                    p1.Value = textBoxCustomerName.Text.Trim().ToString();



                    SqlParameter p2 = new SqlParameter("@CustomerPhone", SqlDbType.VarChar);
                    p2.Value = textBoxCustomerPhone.Text.Trim().ToString();

                    cmd.Parameters.Clear();
                    //step4
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);


                    //step5
                    cmd.Connection = con;
                    // step 6
                    cmd.CommandText = "insert into Customer (CusName,CusPhone) values (@CustomerName,@CustomerPhone)";

                    //step 7
                    con.Open();
                    // step 8
                    cmd.ExecuteNonQuery();
                    //step9
                    con.Close();

                    MessageBox.Show("Customer Data Save Successfully..................");
                    populate();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCustomerName.Text = "";
            textBoxCustomerPhone.Text = "";

        }

        private void CustomerDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(CustomerDVG.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxCustomerName.Text = CustomerDVG.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCustomerPhone.Text = CustomerDVG.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter p1 = new SqlParameter("@CustomerName", SqlDbType.VarChar);
                p1.Value = textBoxCustomerName.Text.Trim().ToString();



                SqlParameter p2 = new SqlParameter("@CustomerPhone", SqlDbType.VarChar);
                p2.Value = textBoxCustomerPhone.Text.Trim().ToString();

                cmd.Parameters.Clear();
                //step4
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                //step5
                cmd.Connection = con;
                // step 6
         
                cmd.CommandText = "Update Customer SET CusName=@CustomerName,CusPhone=@CustomerPhone  where CusID=" + ID;
                //step 7
                con.Open();
                // step 8
                cmd.ExecuteNonQuery();
                //step9
                con.Close();

                MessageBox.Show("Customer Data Updated Successfully..................");
                populate();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "Delete from Customer where CusID=" + ID;

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Customer Data Deleted Successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
                populate();
            }


        }

        

        private void lblbill_Click(object sender, EventArgs e)
        {
            Bill ob = new Bill();
            ob.Show();
           // ob.Hide();

        }
    }
}
        
