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

namespace sql_wpf_forum_01_03_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       const string sqlSource = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;
Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Load2_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }
    }

}
