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
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-O9RDJRG\Test; Initial Catalog = test1; user id = userName; password = test");
            SqlCommand sqlCommand = new SqlCommand($"SELECT h From Table_1 WHERE h = '{qwe.Text}'",sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Успех");
            }
            else MessageBox.Show("Ощибка");

            
        }
    }
}
