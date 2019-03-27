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
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace Pr1_4_
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

        private void Sql_Click(object sender, RoutedEventArgs e)
        {
            if (database.Text != "" && command.Text != "")
            {
                string dbase = database.Text;
                string com = command.Text;
                SqlClientFactory scf = new SqlClientFactory();
                string connectionString = scf.CreateConnection().connect(dbase);
                string comm = scf.CreateCommand().comman(com);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(comm, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable schemaTable = reader.GetSchemaTable();
                    show.ItemsSource = schemaTable.DefaultView;
                    reader.Close();
                }
            }
            else
            {
                SqlClientFactory scf1 = new SqlClientFactory();
                string connectionString1 = scf1.CreateConnection().connectionString;
                string comm1 = scf1.CreateCommand().command;

                using (SqlConnection connection = new SqlConnection(connectionString1))
                {
                    SqlCommand command = new SqlCommand(comm1, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable schemaTable = reader.GetSchemaTable();
                    show.ItemsSource = schemaTable.DefaultView;
                    reader.Close();
                }
            }
            database.Text = "";
            command.Text = "";
        }

        private void Access_Click(object sender, RoutedEventArgs e)
        {
            if (database.Text != "" && command.Text != "")
            {
                string dbase = database.Text;
                string com = command.Text;
                OleDbFactory olf = new OleDbFactory();
                string connectionString = olf.CreateConnection().connect(dbase);
                string comm = olf.CreateCommand().comman(com);

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(comm, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    DataTable schemaTable = reader.GetSchemaTable();
                    show.ItemsSource = schemaTable.DefaultView;
                    reader.Close();
                }
            }
            else
            {
                OleDbFactory olf1 = new OleDbFactory();
                string connectionString1 = olf1.CreateConnection().connectionString;
                string comm1 = olf1.CreateCommand().command;

                using (OleDbConnection connection = new OleDbConnection(connectionString1))
                {
                    OleDbCommand command = new OleDbCommand(comm1, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    DataTable dt = reader.GetSchemaTable();
                    show.ItemsSource = dt.DefaultView;
                    reader.Close();
                }
            }
            database.Text = "";
            command.Text = "";
        }
    }
}
