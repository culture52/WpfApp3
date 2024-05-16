using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using db;
using System.Xml.Linq;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        dB database = new dB();
        public Window1()
        {
            InitializeComponent();

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {



            string username = Логин.Text;
            string password = Пароль.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (авторизА.IsChecked == true)
            {
                string querystring = $"select ID, Логин, Пароль from Администратор where Логин = '{username}' and Пароль = '{password}'";
                SqlCommand command = new SqlCommand(querystring, database.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    Window4 window = new Window4();
                    window.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
        
    
            if (пользовательь.IsChecked == true)
            {
                string querystring = $"select ID, Логин, Пароль from Пользователь where Логин = '{username}' and Пароль = '{password}'";
                SqlCommand command = new SqlCommand(querystring, database.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    Window2 window = new Window2();
                    window.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dB database = new dB();
            string name = лог.Text;
            string phonenumber = тел.Text;
            string email = почт.Text;
            string Sex = пар.Text;

            string username = Логин.Text;
            string password = Пароль.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            if (пользовательь.IsChecked == true)
            {
                string querystring = $"insert into Пользователь (Логин, Пароль, Почта, [Номер телефона]) values ('{name}', '{Sex}', '{email}', '{phonenumber}')";

                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                database.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    Window2 window2 = new Window2();

                    window2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
                database.closeConnection();

            }
            if (Админ.IsChecked == true)
            {
                string querystring = $"insert into Администратор (Логин, Пароль, Почта, Телефон) values ('{name}', '{Sex}', '{email}', '{phonenumber}')";

                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                database.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    Window4 window2 = new Window4();

                    window2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
                database.closeConnection();
            }
        }


        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void аторизП_Checked(object sender, RoutedEventArgs e)
        {
           
            
        }




    }
}
    

