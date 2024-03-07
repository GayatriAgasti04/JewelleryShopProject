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
    

namespace JewelleryShopProject
{
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
          //  populate();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIL1JHR\\MSSQL2016;Initial Catalog=Windowproject;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public int ID { get; set; }
        private void populate()
        {
            con.Open();
            //string query = "select * from Item";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //itemDVG.DataSource = ds.Tables[0];
            //con.Close();

            SqlDataAdapter sda;
            sda = new SqlDataAdapter("Select * from Item", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            itemDVG.DataSource = ds.Tables[0];
            con.Close();

        }

        private void FilterByCat()
        {


            string query = "select * from Item where ItemCat='"+FilterCat.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            itemDVG.DataSource = ds.Tables[0];
            con.Close();

        }

        private void FilterByTypes()
        {


            string query = "select * from Item where ItemType='" + FilterTypes.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            itemDVG.DataSource = ds.Tables[0];
            con.Close();

        }
        private void buttonsave_Click(object sender, EventArgs e)
        {
            if(textBoxItems.Text==""||textBoxprice.Text==""||textBoxQuantity.Text==""||comboBoxCategories.SelectedIndex==-1||comboBoxTypes.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
              try
                {
                    SqlParameter p1 = new SqlParameter("@ItemName", SqlDbType.VarChar);
                    p1.Value = textBoxItems.Text.Trim().ToString(); 
                       

                    SqlParameter p2 = new SqlParameter("@ItemCat", SqlDbType.VarChar);
                    p2.Value =comboBoxCategories.SelectedItem.ToString();
                    

                    SqlParameter p3 = new SqlParameter("@ItemType", SqlDbType.VarChar);
                    p3.Value = comboBoxTypes.SelectedItem.ToString();

                    SqlParameter p4 = new SqlParameter("@ItemPrice", SqlDbType.Int);
                    p4.Value = Convert.ToInt32(textBoxprice.Text);

                    SqlParameter p5 = new SqlParameter("@ItemQty", SqlDbType.Int);
                    p5.Value= Convert.ToInt32(textBoxQuantity.Text);

                    cmd.Parameters.Clear();
                    //step4
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);

                    //step5
                    cmd.Connection = con;
                    // step 6
                    cmd.CommandText = "insert into Item (ItemName,ItemCat,ItemType,ItemPrice,ItemQty) values (@ItemName,@ItemCat,@ItemType,@ItemPrice,@ItemQty)";

                    //step 7
                    con.Open();
                    // step 8
                    cmd.ExecuteNonQuery();
                    //step9
                    con.Close();

                    MessageBox.Show("Item Save Successfully..................");
                    populate();
                   
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void itemDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxItems.Text = itemDVG.SelectedRows[0].Cells[1].Value.ToString();
            //comboBoxCategories.SelectedItem= itemDVG.SelectedRows[0].Cells[2].Value.ToString();
            //comboBoxTypes.SelectedItem= itemDVG.SelectedRows[0].Cells[3].Value.ToString();
            //textBoxprice.Text= itemDVG.SelectedRows[0].Cells[4].Value.ToString();
            //textBoxQuantity.Text= itemDVG.SelectedRows[0].Cells[5].Value.ToString();
            ////if(textBoxItems.Text=="")
            //{
            //    ID = 0;
            //}
            //else
            //{
            //    ID = Convert.ToInt32(itemDVG.SelectedRows[0].Cells[0].Value.ToString());
            //}

            //cmbproductName.SelectedItem = ProductDVG.Rows[e.RowIndex].Cells[1].Value.ToString();
            ID = Convert.ToInt32(itemDVG.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxItems.Text = itemDVG.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxCategories.Text = itemDVG.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxTypes.Text = itemDVG.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxprice.Text = itemDVG.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxQuantity.Text = itemDVG.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxItems.Text = "";
            comboBoxCategories.SelectedIndex = -1;
            comboBoxTypes.SelectedIndex = -1;
            textBoxprice.Text = "";
            textBoxQuantity.Text = "";

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter p1 = new SqlParameter("@ItemName", SqlDbType.VarChar);
                p1.Value = textBoxItems.Text.Trim().ToString();


                SqlParameter p2 = new SqlParameter("@ItemCat", SqlDbType.VarChar);
                p2.Value = comboBoxCategories.SelectedItem.ToString();


                SqlParameter p3 = new SqlParameter("@ItemType", SqlDbType.VarChar);
                p3.Value = comboBoxTypes.SelectedItem.ToString();

                SqlParameter p4 = new SqlParameter("@ItemPrice", SqlDbType.Int);
                p4.Value = Convert.ToInt32(textBoxprice.Text);

                SqlParameter p5 = new SqlParameter("@ItemQty", SqlDbType.Int);
                p5.Value = Convert.ToInt32(textBoxQuantity.Text);

                cmd.Parameters.Clear();
                //step4
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                //step5
                cmd.Connection = con;
                // step 6
                cmd.CommandText = "Update Item SET ItemName=@ItemName,ItemCat=@ItemCat,ItemType=@ItemType,ItemPrice=@ItemPrice,ItemQty=@ItemQty  where ItemID="+ID;
                   
                //step 7
                con.Open();
                // step 8
                cmd.ExecuteNonQuery();
                //step9
                con.Close();

                MessageBox.Show("Item Updated Successfully..................");
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
                string query = "Delete from Item where ItemID="+ID;

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Item Deleted Successfully");
                
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

        private void items_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            Customer ob = new Customer();
            ob.Show();
            this.Hide();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            items ob = new items();
            ob.Show();
            ob.Hide();
        }

        private void FilterCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCat();
        }

        private void FilterTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByTypes();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
    }

