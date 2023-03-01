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
using Microsoft.SqlServer;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;

namespace sql_wpf_forum_01_03_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       const string sqlSource = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = academy_top;
Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void add_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            D_L.ItemsSource = null;

            SqlConnection conn = new SqlConnection(sqlSource);

            string select = "select * from students";

            SqlDataAdapter adapter = new SqlDataAdapter(select,conn);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            MessageBox.Show("Данные успешно загружены");

            D_L.ItemsSource = dataTable.DefaultView;

           D_L.Focus();

        }
    }

}
