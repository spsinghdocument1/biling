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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, RoutedEventArgs e)
        {


            string u = uname.Text;
            string p = passw.Password;
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Login where UserName='" + u + "' and password='" + p + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully");
                MainWindow mainw = new MainWindow();
                mainw.Show();
                uname.Text = "";
                passw.Password = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter Valid User/Password");
                uname.Text = "";
               passw.Password = "";
            }     
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        void logHyperlink(object sencler, RoutedEventArgs e)
        {
            logingNewuser lon = new logingNewuser();
            lon.Show();

        }
        void logHyperupdate(object sencler, RoutedEventArgs e)
        {
            updatelogin ulon = new updatelogin();
            ulon.Show();

        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }

       

       
    }
}
