using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CrawfordTask
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        string connectstring = "Server=interview-testing-server.database.windows.net; Database=Interview; User Id=TestLogin; Password=5D9ej2G64s3sd^;";

        private void closelbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usdtxt.Text != string.Empty || pwdtxt.Text != string.Empty)
            {
                try
                {
                    //Create SqlConnection
                    SqlConnection conn = new SqlConnection(connectstring);
                    SqlCommand cmdlogin = new SqlCommand("Select * from dbo.Users where UserName=@username and Password=@password", conn);
                    cmdlogin.Parameters.AddWithValue("@username", usdtxt.Text);
                    cmdlogin.Parameters.AddWithValue("@password", pwdtxt.Text);
                    conn.Open();

                    SqlDataAdapter adaptlogin = new SqlDataAdapter(cmdlogin);
                    DataSet dslogin = new DataSet();
                    adaptlogin.Fill(dslogin);

                    conn.Close();

                    int count = dslogin.Tables[0].Rows.Count;
                    string active = dslogin.Tables[0].Rows[0]["Active"].ToString();

                    if (count == 1)
                    {
                        if (active.Equals("True"))
                        {
                            welcomelbl.Text = "Welcome " + dslogin.Tables[0].Rows[0]["DisplayName"].ToString();
                            losslbl.Visible = true;
                            lossgridview.Visible = true;

                            SqlCommand cmdloss = new SqlCommand("Select LossTypeId, LossTypeCode, LossTypeDescription from dbo.LossTypes", conn);
                            conn.Open();

                            SqlDataAdapter adapt = new SqlDataAdapter(cmdloss);
                            DataSet dsloss = new DataSet();
                            adapt.Fill(dsloss);
                            lossgridview.DataSource = dsloss.Tables[0];
                        }
                        else
                            MessageBox.Show("Login is inactive, please try different login.");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password, please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter and username and password.");
                return;
            }
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            losslbl.Visible = false;
            lossgridview.Visible = false;
            usdtxt.Text = "";
            pwdtxt.Text = "";
            welcomelbl.Text = "Welcome";
        }
    }
}
