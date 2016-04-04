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
using System.Data.SqlClient;
using System.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
          
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        //public void sp()
        //{
        //   int a ;
        //    SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
        //    con.Open();


        //    SqlCommand cmd = new SqlCommand(" select top 1 Bill_NO from BILL order by Bill_NO desc", con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    if (ds.Tables[0].Rows.Count >= 1)
        //    {
        //        DataRow dr = ds.Tables[0].Rows[0];
        //       // textBox1.Text = dr[0].ToString();
        //        a =Convert.ToInt16 (dr[0].ToString())+1;
        //        textBox1.Text = a.ToString();
           // }
        
       // }

      
    }
}
