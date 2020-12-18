using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using System.Net;

namespace WpfApp1
{

    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public static string Site_Load()
        {
            Uri url = new Uri("https://bigpara.hurriyet.com.tr/borsa/canli-borsa/");
            var client = new WebClient();
            string html = client.DownloadString(url);
            return html;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(Site_Load());
            for (int i = 1; i < 98; i++)
            { 
                string veri1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"sortable\"]/ul[" + i + "]/li[1]/a[2]")[0].InnerText;
                string veri2 = dokuman.DocumentNode.SelectNodes("//*[@id=\"sortable\"]/ul[" + i + "]/li[1]/a[2]")[0].InnerText;
                comboBox1.Items.Add(veri1);
                comboBox2.Items.Add(veri2);
            }

        }
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(Site_Load());
            for (int i = 0; i < 7; i++)
            {
                string[] dizi = { "fiyat", "alis", "satis", "yuksek", "dusuk", "aort", "yuzde" };

                if (dizi[i] == "fiyat")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtSon1.Text = Son1;
                }
                if (dizi[i] == "alis")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtAlis1.Text = Son1;
                }
                if (dizi[i] == "satis")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtSatis1.Text = Son1;
                }
                if (dizi[i] == "yuksek")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtYuksek1.Text = Son1;
                }
                if (dizi[i] == "dusuk")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtDusuk1.Text = Son1;
                }
                if (dizi[i] == "aort")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtAort1.Text = Son1;
                }
                if (dizi[i] == "yuzde")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox1.SelectedItem + "\"]")[0].InnerText;
                    txtYuzde1.Text = Son1;
                }
                
            }
        }
        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(Site_Load());
            for (int i = 0; i < 7; i++)
            {
                string[] dizi = { "fiyat", "alis", "satis", "yuksek", "dusuk", "aort", "yuzde" };
                if (dizi[i] == "fiyat")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtSon2.Text = Son1;
                }
                if (dizi[i] == "alis")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtAlis2.Text = Son1;
                }
                if (dizi[i] == "satis")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtSatis2.Text = Son1;
                }
                if (dizi[i] == "yuksek")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtYuksek2.Text = Son1;
                }
                if (dizi[i] == "dusuk")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtDusuk2.Text = Son1;
                }
                if (dizi[i] == "aort")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtAort2.Text = Son1;
                }
                if (dizi[i] == "yuzde")
                {
                    string Son1 = dokuman.DocumentNode.SelectNodes("//*[@id=\"h_td_" + dizi[i] + "_id_" + comboBox2.SelectedItem + "\"]")[0].InnerText;
                    txtYuzde2.Text = Son1;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            exR1.Visibility = Visibility.Hidden;
            exR2.Visibility = Visibility.Hidden;
            exR3.Visibility = Visibility.Hidden;
            exR4.Visibility = Visibility.Hidden;
            exR5.Visibility = Visibility.Hidden;
            exR6.Visibility = Visibility.Hidden;
            exR7.Visibility = Visibility.Hidden;
            exS7.Visibility = Visibility.Hidden;
            exS6.Visibility = Visibility.Hidden;
            exS5.Visibility = Visibility.Hidden;
            exS4.Visibility = Visibility.Hidden;
            exS3.Visibility = Visibility.Hidden;
            exS2.Visibility = Visibility.Hidden;
            exS1.Visibility = Visibility.Hidden;


            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                if (Convert.ToDouble(txtSon1.Text)> Convert.ToDouble(txtSon2.Text))
                    exS1.Visibility = Visibility.Visible;
                else
                    exR1.Visibility = Visibility.Visible;
                if (Convert.ToDouble(txtSatis1.Text) > Convert.ToDouble(txtSatis2.Text))
                    exS2.Visibility = Visibility.Visible;
                else
                    exR2.Visibility = Visibility.Visible;
                if (Convert.ToDouble(txtAlis1.Text) > Convert.ToDouble(txtAlis2.Text))
                    exS3.Visibility = Visibility.Visible;
                else
                    exR3.Visibility = Visibility.Visible;
                if (Convert.ToDouble(txtYuksek1.Text) > Convert.ToDouble(txtYuksek2.Text))
                    exS4.Visibility = Visibility.Visible;
                else
                    exR4.Visibility = Visibility.Visible;
                if (Convert.ToDouble(txtDusuk1.Text) > Convert.ToDouble(txtDusuk2.Text))
                    exS5.Visibility = Visibility.Visible;
                else
                    exR5.Visibility = Visibility.Visible;
                if (Convert.ToDouble(txtAort1.Text) > Convert.ToDouble(txtAort2.Text))
                    exS6.Visibility = Visibility.Visible;
                else
                    exR6.Visibility = Visibility.Visible;
                if (Convert.ToDouble(txtYuzde1.Text) > Convert.ToDouble(txtYuzde2.Text))
                    exS7.Visibility = Visibility.Visible;
                else
                    exR7.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Lütfen seçim yapınız");
        }

    }
}
   