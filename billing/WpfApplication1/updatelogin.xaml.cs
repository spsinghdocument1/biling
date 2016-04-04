using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for updatelogin.xaml
    /// </summary>
    public partial class updatelogin : Window
    {
        public updatelogin()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection mycon = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");

            mycon.Open();
            string cmdstr = "select count(*) from Login where UserName ='" + un.Text + "'";
            SqlCommand checkuser = new SqlCommand(cmdstr, mycon);
            int temp = Convert.ToInt32(checkuser.ExecuteScalar().ToString());
            if (temp == 1)
            {
                string cmdstr2 = "select Password from Login where UserName='" + un.Text + "'";
                SqlCommand last = new SqlCommand(cmdstr2, mycon);
                string Password = last.ExecuteScalar().ToString();
                if (Password == oldpwd.Password)
                {
                    int i = 0;
                    if (newpwd.Password == conpwd.Password)
                    {
                        i = 1;
                    }
                    else
                    {
                        i = 0;
                    }

                    if (i == 1)
                    {
                        SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
                        //SqlCommand cmd = new SqlCommand("update Login set Password ='" + newpwd + "', where UserName ='" + un.Text + "')", con);
                        //cmd.Parameters.AddWithValue("@UserName", un.Text);
                        //cmd.Parameters.AddWithValue("@Password", newpwd.Password);
                        SqlCommand comm = new SqlCommand();
                        string myInsertQuery = "UPDATE [Login] SET [UserName] = @UserName, [Password] = @Password WHERE [UserName] = @UserName";
                        comm.CommandText = myInsertQuery;
                        comm.Connection = con;
                        con.Open();
                        comm.Parameters.AddWithValue("@UserName", un.Text);
                        comm.Parameters.AddWithValue("@Password", newpwd.Password);
                        comm.ExecuteNonQuery();
                        con.Close();
                        comm.Connection.Close();
                        MessageBox.Show("User Updated Successfully");
                        un.Text = "";
                        oldpwd.Password = "";
                        newpwd.Password = "";
                        conpwd.Password = "";
                    }
                    else
                    {
                        MessageBox.Show("Password Don't Match");
                    }
                }
                else { MessageBox.Show("Old Password Don't Match"); }
            }
            //Window2 m = new Window2();
            //m.Show();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
