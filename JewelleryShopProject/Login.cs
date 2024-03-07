using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //for password property 
            txtpassword.UseSystemPasswordChar = true;
        }

        private void buttoncross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtuserName.Text = "";
            txtpassword.Text = " ";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (txtuserName.Text == "" && txtpassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else if (txtuserName.Text == "Admin" && txtpassword.Text == "Admin123")
                {
                    MessageBox.Show("Login Successfully");
                    items ob = new items();
                    ob.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Enter Valid Name And Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void lblContinueAsSeller_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }

