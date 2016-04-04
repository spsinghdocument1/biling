﻿using System;
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


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Group.xaml
    /// </summary>
    public partial class Group : Window
    {
        public Group()
        {
            InitializeComponent();
        }

     private void Button12_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Group_Enter values(@Group_Name)", con);
            cmd.Parameters.AddWithValue("@Group_Name", textUnit.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Record has been saved successfully");
            textUnit.Text = string.Empty;
        }
         private void Button4_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
         private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textUnit.Text = string.Empty;
            textUnit2.Text = string.Empty;
        }

         private void ButtonDelete_Click(object sender, RoutedEventArgs e)
         {
             try
             {
                 SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
                 con.Open();
                 SqlCommand cmd = new SqlCommand("DELETE FROM Group_Enter", con);
                 cmd.ExecuteNonQuery();
                 con.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             MessageBox.Show("ALL Record has been Delete successfully");
         }


         private void Button_Click(object sender, RoutedEventArgs e)
         {

             try
             {
                 string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                 SqlConnection connection = new SqlConnection(connectionString);

                 connection.Open();
                 DataTable dt = new DataTable();

                 SqlCommand cmd = new SqlCommand("SELECT * FROM Group_Enter WHERE Group_Name LIKE '" + textUnit2.Text + "' ", connection);

                 SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                 dataadapter.Fill(dt);

                 dataGrid1.AutoGenerateColumns = true;
                 dataGrid1.ItemsSource = dt.DefaultView;
                 connection.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             
             }
         }

         private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
         {

         }

         private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
         {

         }

         private void Image_ImageFailed_2(object sender, ExceptionRoutedEventArgs e)
         {

         }

         private void Image_ImageFailed_3(object sender, ExceptionRoutedEventArgs e)
         {

         }

         private void Image_ImageFailed_4(object sender, ExceptionRoutedEventArgs e)
         {

         }

       
        }

       
    }

