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
    /// Interaction logic for logingNewuser.xaml
    /// </summary>
    public partial class logingNewuser : Window
    {
        public logingNewuser()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (passw.Password == cpass.Password)
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
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into Login values(@UserName,@Password)", con);
                cmd.Parameters.AddWithValue("@UserName", un.Text);
                cmd.Parameters.AddWithValue("@Password", passw.Password);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Created Successfully");
                un.Text = "";
                passw.Password = "";
                cpass.Password = "";
            }
            else
            {
                MessageBox.Show("Password Don't Match");
            }
            //Window2 m = new Window2();
            //m.Show();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
