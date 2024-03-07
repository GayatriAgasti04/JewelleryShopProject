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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            populate();
            DisplayCus();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIL1JHR\\MSSQL2016;Initial Catalog=Windowproject;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public int ID { get; set; }
        private void populate()
        {
            con.Open();
           SqlDataAdapter sda;
            sda = new SqlDataAdapter("Select * from Item", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            itemDVG.DataSource = ds.Tables[0];
            con.Close();

        }

        private void DisplayCus()
        {
            con.Open();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("Select * from Customer", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            CustomerDVG.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Update()
        {
            try
            {
                //con.Open();
                //string query="Update  Item  SET 
                //    SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show(
                
                //
                //SqlParameter p5 = new SqlParameter("@ItemQty", SqlDbType.Int);
                //p5.Value = Convert.ToInt32(textBoxQuantity.Text);

                
                //cmd.Parameters.Add(p5);

                //step5
                cmd.Connection = con;
                // step 6
                int newstock = stock - Convert.ToInt32(textBoxQuantity.Text);
                cmd.CommandText = "Update Item SET ItemQty=" +newstock+ "where  ItemID=" + ID;
               


                //step 7
                con.Open();
                // step 8
                cmd.ExecuteNonQuery();
                //step9
                con.Close();

                MessageBox.Show("Item Updated Successfully..................");
                populate();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        int n = 0, GrdTotal = 0;
        int stock = 0;
        private void buttonAddtobill_Click(object sender, EventArgs e)
        {
            ///check this code
            if(textBoxQuantity.Text==" " ||Convert.ToInt32(textBoxQuantity.Text)>stock)
            {
                MessageBox.Show("NO Stock");
            }
            else
            {
                int total = Convert.ToInt32(textBoxQuantity.Text) * Convert.ToInt32(textBoxprice.Text);
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(BillDVG);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = textBoxProductName.Text;
                newrow.Cells[2].Value = textBoxprice.Text;
                newrow.Cells[3].Value = textBoxQuantity.Text;
                newrow.Cells[4].Value = total;
                BillDVG.Rows.Add(newrow);
                GrdTotal = GrdTotal + total;
                lbltotal.Text = "Rs" + GrdTotal;
                n++;
                Update();
            }

        }
       

        private void CustomerDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(CustomerDVG.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxCustomerName.Text = CustomerDVG.Rows[e.RowIndex].Cells[1].Value.ToString();
           

        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperBill", 285, 600);
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void itemDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(itemDVG.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxProductName.Text = itemDVG.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxprice.Text = itemDVG.Rows[e.RowIndex].Cells[4].Value.ToString();


            //extBoxQuantity.Text = itemDVG.Rows[e.RowIndex].Cells[5].Value.ToString();
            stock = Convert.ToInt32(itemDVG.Rows[e.RowIndex].Cells[5].Value.ToString());
            //if((textBoxCustomerName.Text==""))
            //{
            //    stock = 0;
            //}
        }
    }
}
