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
    /// Interaction logic for PurchaseInvoice.xaml
    /// </summary>
    /// 
   
    public partial class PurchaseInvoice : Window
    {
        DataTable dt;
        public void ad()
        {

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  Products_Name from Product", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            comboBox1 .ItemsSource = ds.Tables[0].DefaultView;
            comboBox1.DisplayMemberPath = ds.Tables[0].Columns["Products_Name"].ToString();
            comboBox1.SelectedValuePath = ds.Tables[0].Columns["Products_Name"].ToString(); 
        }

        //public void fetch()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=KAMAKHYA-PC\\sqlexpress;Initial Catalog=Billing;Integrated Security=True");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    string str = " Select price from Goods where Goods_Name= '" + comboBox1.Text + "' ";
        //    cmd = new SqlCommand(str, con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    cmd.ExecuteNonQuery();
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        textBox6.Text = (ds.Tables[0].Rows[i][0].ToString());
        //    }
        //    con.Close();

        //}
        public PurchaseInvoice()
        {
            InitializeComponent();
            sp5();
           ad();
           dt = new DataTable();
           dt.Columns.Add("Date", typeof(string));
           dt.Columns.Add("Bill_NO", typeof(string));
           dt.Columns.Add("Party_name", typeof(string));
           dt.Columns.Add("Discription_of_Goods", typeof(string));
           dt.Columns.Add("Total_Quantity", typeof(decimal));
           dt.Columns.Add("Price", typeof(decimal));
           dt.Columns.Add("Total_Price", typeof(decimal));
           dt.Columns.Add("Tax", typeof(decimal));
            
        }

        private void dataGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void sp5()
        {
            int a;
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand(" select top 1 Bill_NO from BILL order by Bill_NO desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                // textBox1.Text = dr[0].ToString();
                a = Convert.ToInt16(dr[0].ToString()) + 1;
                textBox1.Text = a.ToString();
            }

        }
        public void sp6() 
        {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into BILL values(@Bill_NO)", con);
            cmd.Parameters.AddWithValue("@Bill_NO", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        
        }

        public void sp()
        {
            decimal a, b, c,e,f,h;
            try
            {
            a = decimal.Parse(textBox5.Text);
            b = decimal.Parse(textBox6.Text);
            e = decimal.Parse(textBox30.Text);
           // c = (a * b)*(e%100);
            c = (a * b);
            f = (c) * (e / 100);
            h = c + f;
            // MessageBox.Show(""+c);
           
                DataRow dr = dt.NewRow();
                dr["Date"] = DATEE.Text;
                dr["Bill_NO"] = textBox1.Text;
                dr["Party_name"] = textBox2.Text;
                //dr["Party_name"] = e;
                dr["Discription_of_Goods"] = comboBox1.SelectedValue.ToString();
                dr["Total_Quantity"] = a;
                dr["Price"] = b;
                dr["Tax"] = e;
                dr["Total_Price"] = h;

                // dr["ADD"] = ((Convert.ToDouble(textBox1.Text)) + (Convert.ToDouble(textBox2.Text)));
                dt.Rows.Add(dr);
                dataGrid1.ItemsSource = null;
                dataGrid1.ItemsSource = dt.DefaultView;
                // object b = dt.Compute("SUM(Total_Quantity)", "");
                object z = dt.Compute("SUM(Total_Quantity)", "");
                textBox3.Text = z.ToString();
                object y = dt.Compute("SUM(Total_Price)", "");
                textBox4.Text = y.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            sp();

            //decimal a=100, b=10, c, f;

            //c = a / b;
            //MessageBox.Show(""+c);
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedValue.ToString());

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string str = " Select Sales_Prices from Product where Products_Name= '" + comboBox1.SelectedValue.ToString() + "' ";

            cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                textBox6.Text = (ds.Tables[0].Rows[i][0].ToString());
            }
            if (ds.Tables[0].Rows.Count >= 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                textBox6.Text = dr[0].ToString();
            }
            con.Close();
            sp2();
        }
        public void sp2()
        {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string str = " Select Tax_Type from Product where Products_Name= '" + comboBox1.SelectedValue.ToString() + "' ";

            cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            da.Fill(ds);
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    textBox30.Text = (ds.Tables[0].Rows[i][0].ToString());
            //}
            if (ds.Tables[0].Rows.Count >= 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                textBox30.Text = dr[0].ToString();
            }
            con.Close();
        
        
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog myPrintDialog = new PrintDialog();
            
            if (myPrintDialog.ShowDialog() == true)
            {
                myPrintDialog.PrintVisual(dataGrid1,"Form All Controls Print");
               // myPrintDialog.PrintVisual((dataGrid1),(),"Form All Controls Print");
               
              
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBox6.Text = "";
            DATEE.Text = "";
            textBox1.Text = "";
                textBox2.Text = "";
               // comboBox1.Text = "";
                    textBox5.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
           // PurchaseInvoice2

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into PurchaseInvoice2 values(@Date,@Bill_NO,@Party_Name,@Total_Quantity,@Total_Price)", con);
            cmd.Parameters.AddWithValue("@Date", DATEE.Text);
            cmd.Parameters.AddWithValue("@Bill_NO", textBox1.Text);
            cmd.Parameters.AddWithValue("@Party_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Total_Quantity", textBox3.Text);
            cmd.Parameters.AddWithValue("@Total_Price", textBox4.Text);
            //cmd.Parameters.AddWithValue("@Pin_Code", textBox6.Text);
            //cmd.Parameters.AddWithValue("@Mobile_Number", textBox7.Text);
            //cmd.Parameters.AddWithValue("@Phone_Number", textBox8.Text);
            //cmd.Parameters.AddWithValue("@E_Mail_Id", textBox9.Text);
            //cmd.Parameters.AddWithValue("@Tin_Number", textBox10.Text);
            //cmd.Parameters.AddWithValue("@CST_Number", textBox11.Text);
            //cmd.Parameters.AddWithValue("@CST_Date", datePicker1.Text);
            //cmd.Parameters.AddWithValue("@Pan_Number", textBox12.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record has been saved successfully");
            sp6();
            textBox6.Text = "";
            DATEE.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            // comboBox1.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

       
       

                  
    }
}
