using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
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
using Microsoft.Identity.Client.Extensions.Msal;

namespace sql_wpf_forum_01_03_2022
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        const string sqlSource = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = academy_top;
Integrated Security=True";

        public Window1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            
            SqlConnection con = new SqlConnection();
            
            //описываем соединение 
            con = new SqlConnection(sqlSource);

          

            //открываем соединение
            con.Open();
                string query = "insert into students (studName, studFname, studAge, gropeName, grants) " +
                    "values (@studName, @studFname, @studAge, @gropeName, @grants)";

                //создаем комманду на соединение
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddRange(GetSqlParameters());
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Данные успешно добавлены...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }

        }
        private SqlParameter[] GetSqlParameters() 
        {
        SqlParameter studName = new SqlParameter("@studName",SqlDbType.NVarChar);
            studName.Value = name_t.Text;

            SqlParameter studSone = new SqlParameter("@studFname", SqlDbType.NVarChar);
            studSone.Value = so_name_t.Text;

            SqlParameter studAge = new SqlParameter("@studAge", SqlDbType.Int);
            studAge.Value = Int32.Parse( age_t.Text);

            SqlParameter studGroup = new SqlParameter("@gropeName", SqlDbType.NVarChar);
            studGroup.Value = group_t.Text;

            SqlParameter studGrant = new SqlParameter("@grants", SqlDbType.Int);
            studGrant.Value = Int32.Parse (grant_t.Text);

            return new SqlParameter[] { studName,studSone, studAge, studGroup, studGrant};

        }


    }
}
