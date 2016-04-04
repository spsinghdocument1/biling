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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public void sp()
        {
            MainWindow m = new MainWindow();
            m.Show();

        }
        protected void Exit_click(object sencler, RoutedEventArgs e)
    {
        MessageBox.Show("Click exit");
    
    }
        void about_click(object sencler, RoutedEventArgs e)
        {
            aboutus about = new aboutus();
            
            about.Show();
         
           }
        void window_click(object sencler, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            

            win.Show();

        }
        void import_click(object sencler, RoutedEventArgs e)
        {
            import im = new import();
            im.Show();

        }
        void Export_click(object sencler, RoutedEventArgs e)
        {
            Export ex = new Export();
            ex.Show();

        }

        void company_click(object sencler, RoutedEventArgs e)
        {
            Company com = new Company();
            com.Show();

        }
        void costomerDetails_click(object sencler, RoutedEventArgs e)
        {
            CostomerDetails csd = new CostomerDetails();
            csd.Show();
      

        }
        void SustomerDetails_click(object sencler, RoutedEventArgs e)
        {
            SustomerDetails sud = new SustomerDetails();
            sud.Show();
      

        }
        void unitName_click(object sencler, RoutedEventArgs e)
        {
            unit uni = new unit();
            uni.Show();


        }
        void Group_click(object sencler, RoutedEventArgs e)
        {
            Group gro = new Group();
            gro.Show();


        }
        void Brand_click(object sencler, RoutedEventArgs e)
        {
            Brand brd = new Brand();
            brd.Show();


        }
        void Tax_click(object sencler, RoutedEventArgs e)
        {
            Tax Ta = new Tax();
            Ta.Show();


        }
         void ProductDetails_click(object sencler, RoutedEventArgs e)
        {
            ProductDetails brd = new ProductDetails();
            brd.Show();


        }
         void Purchase_click(object sencler, RoutedEventArgs e)
         {
             Purchase pur = new Purchase();
             pur.Show();


         }
         void PurcReturn_click(object sencler, RoutedEventArgs e)
         {
             PurchaseReturn purr = new PurchaseReturn();
             purr.Show();


         }
         void Sale_click(object sencler, RoutedEventArgs e)
         {
             SalesMaster surr = new SalesMaster();
             surr.Show();


         }
         void SaleR_click(object sencler, RoutedEventArgs e)
         {
           SalesReturn surrr = new SalesReturn ();
           surrr.Show();
             

         }
         void REcustomer_click(object sencler, RoutedEventArgs e)
         {
             RCustomer rcu = new RCustomer();
             rcu.Show();

         }
         void REsu_click(object sencler, RoutedEventArgs e)
         {
             RSupplier Resu = new RSupplier();
             Resu.Show();
             

         }
         void Unt_click(object sencler, RoutedEventArgs e)
         {
             Report_Unit uni = new Report_Unit();
           
             uni.Show();


         }
         void Rgroup_click(object sencler, RoutedEventArgs e)
         {

             Report_Group gni = new Report_Group();
             gni.Show();


         }
         void Rbrand_click(object sencler, RoutedEventArgs e)
         {
             Report_Brand RPni = new Report_Brand();
             RPni.Show();


         }
         void RTac_click(object sencler, RoutedEventArgs e)
         {
             Report_Tasc RTac = new Report_Tasc();
             RTac.Show();


         }
         void Rpro_click(object sencler, RoutedEventArgs e)
         {
             Report_Product Rprac = new Report_Product();
             Rprac.Show();


         }
         void Rpstock_click(object sencler, RoutedEventArgs e)
         {
             Report_Stock Rstrac = new Report_Stock();
             Rstrac.Show();


         }
         void rPurch_click(object sencler, RoutedEventArgs e)
         {
             Report_PurchaseDetail Rpurrac = new Report_PurchaseDetail();
             Rpurrac.Show();


         }
         //void Rbpurch_click(object sencler, RoutedEventArgs e)
         //{
         //    Report_PurchaseBillDetail RBpurrac = new Report_PurchaseBillDetail();
         //    RBpurrac.Show();


         //}
         void Rsaled_click(object sencler, RoutedEventArgs e)
         {
             Report_SalesDetail Rsaled = new Report_SalesDetail();
             Rsaled.Show();


         }
         //void Rsabilsumer_click(object sencler, RoutedEventArgs e)      
         //{
         //    Report_SalesBillsSummary RsaleSum = new Report_SalesBillsSummary();
         //    RsaleSum.Show();


         //}
         void Logout_click(object sencler, RoutedEventArgs e)
         {
             Window2 logout = new Window2();
             logout.Show();
             this.Close();


         }
         void sto_setting_click(object sencler, RoutedEventArgs e)
         {
             Setting srt = new Setting();
             srt.Show();


         }
         void cange_setting_click(object sencler, RoutedEventArgs e)
         {
             ChangeDataFromat chdafor = new ChangeDataFromat();
             chdafor.Show();


         }
         void printer_setting_click(object sencler, RoutedEventArgs e)
         {
             PrinterSetting PrintSe = new PrinterSetting();
             PrintSe.Show();


         }
         void Currency_setting_click(object sencler, RoutedEventArgs e)
         {
             CurrencySetting Cur = new CurrencySetting();
             Cur.Show();


         }
         void TaxS_setting_click(object sencler, RoutedEventArgs e)
         {
             TaxSetting TurS = new TaxSetting();
             TurS.Show(); 


         }
         void LangeS_setting_click(object sencler, RoutedEventArgs e)
         {
             LanguageSetting languurS = new LanguageSetting();
             languurS.Show();


         }
         void EExport_click(object sencler, RoutedEventArgs e)
         {
             PurchaseInvoice exp = new PurchaseInvoice();
             exp.Show();


         }
         void iimport_click(object sencler, RoutedEventArgs e)
         {
             SalesInvoice imp = new SalesInvoice();
             imp.Show();


         }
    }
}
