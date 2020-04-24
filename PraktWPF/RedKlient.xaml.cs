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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace PraktWPF
{
    /// <summary>
    /// Логика взаимодействия для RedKlient.xaml
    /// </summary>
    public partial class RedKlient : Window
    {
        public int vid;
        MySqlConnection connection;
        public  DataRowView view;
        public RedKlient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            connection = new MySqlConnection("host = localhost; uid=root; pwd = student123; database = inventar");
            connection.Open();
            naim.Text = view["name"].ToString();
            tip.Text = view["tip"].ToString();
            adres.Text = view["adres"].ToString();
            rekv.Text = view["rekvizit"].ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (vid == 1)
            {
                MySqlCommand com1 = new MySqlCommand($"INSERT INTO klient(name,tip,adres,rekvizit) VALUES(@names,@tip,@adres,@rekvizit)", connection);
                com1.Parameters.AddWithValue("@names", naim.Text);
                com1.Parameters.AddWithValue("@tip", tip.Text);
                com1.Parameters.AddWithValue("@adres", adres.Text);
                com1.Parameters.AddWithValue("@rekvizit", rekv.Text);
                com1.ExecuteNonQuery();
                MessageBox.Show("Данные внесены");
                MainWindow main = new MainWindow();
                connection.Close();
                this.Close();

                main.ShowDialog();
            }
            else
            {
                MySqlCommand com1 = new MySqlCommand($"UPDATE klient SET name = '{naim.Text}',tip = '{tip.Text}', adres = '{adres.Text}', rekvizit='{rekv.Text}' WHERE idklient='{view["idklient"].ToString()}'", connection);
                com1.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
                MainWindow main = new MainWindow();
                connection.Close();
                this.Close();
                main.ShowDialog();
            }
        }
    }
}
