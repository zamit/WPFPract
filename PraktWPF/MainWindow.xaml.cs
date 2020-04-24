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
using MySql.Data.MySqlClient;
using System.Data;

namespace PraktWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
       public partial class MainWindow : Window
    {
        MySqlConnection connection;
        DataRowView view;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            connection = new MySqlConnection("host = localhost; uid=root; pwd = student123; database = inventar");
            connection.Open();
            update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (datagrid.SelectedIndex != -1) // проверяем если выделенно что то
            {
                view = datagrid.SelectedItem as DataRowView; // в переменную view помещаем значение текущей строки
                MySqlCommand com1 = new MySqlCommand($"Delete from klient where idklient = '{view["idklient"].ToString()}'", connection); 
                //удаляем строку в которой id равен id выделенной строки
                com1.ExecuteNonQuery(); //выполняем запрос
                MessageBox.Show("Запись удалена");
                update(); //обновляем запрос и datagrid
            }
            }

        public void update()
        {
            MySqlCommand command = new MySqlCommand($"Select * from klient", connection); // в переменную command заносим запрос выборки
            MySqlDataReader datreader = command.ExecuteReader(); // выполняем запрос с возвратом результата
            DataTable table = new DataTable(); // создаем переменную table с типом DataTable куда мы будем помещать данные из выборки
            table.Load(datreader); //загружаем данные в компонент table
            datagrid.ItemsSource = table.DefaultView;// в ресурс datagrid загружаем значения из таблицы
            datreader.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RedKlient redKlient = new RedKlient();
            redKlient.vid = 1;
            this.Close();
            redKlient.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RedKlient redKlient = new RedKlient();
            redKlient.vid = 2;
            redKlient.view = datagrid.SelectedItem as DataRowView;
            this.Close();
            redKlient.ShowDialog();
        }
    }
}
