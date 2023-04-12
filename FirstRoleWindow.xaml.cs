using System;
using System.Collections.Generic;
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
using pract5.pr5DataSet1TableAdapters;
namespace pract5
{
    public partial class FirstRoleWindow : Window
    {
        UsersTableAdapter users = new UsersTableAdapter();
        public FirstRoleWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = users.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Full_name.Text == "" || Role.Text == "" || Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string input = Full_name.Text;
                string input2 = Role.Text;
                string input3 = Login.Text;
                string input4 = Password.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Z0-9]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9]+$"))
                {
                    users.InsertQuery(Full_name.Text, Role.Text, Login.Text, Password.Text);
                    DataGrid.ItemsSource = users.GetData();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object id = (DataGrid.SelectedItem as DataRowView).Row[0];
                users.DeleteQuery(Convert.ToInt32(id));
                DataGrid.ItemsSource = users.GetData();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                if (Full_name.Text == "" || Role.Text == "" || Login.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input = Full_name.Text;
                    string input2 = Role.Text;
                    string input3 = Login.Text;
                    string input4 = Password.Text;

                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Z0-9]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9]+$"))
                    {
                        object Original_id_Users = (DataGrid.SelectedItem as DataRowView).Row[0];
                        users.UpdateQuery(Full_name.Text, Role.Text, Login.Text, Password.Text, Convert.ToInt32(Original_id_Users));
                        DataGrid.ItemsSource = users.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                }
            }
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            this.Close();
            a.Show();
        }

        private void ison_Click(object sender, RoutedEventArgs e)
        {
            List<Class2> forImport = Class3.Der<List<Class2>>(); 
            foreach (var item in forImport)
            {
                users.InsertQuery(item.Full_name,item.Role,item.Login, item.Password);
            }
            
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = users.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object cell1 = (DataGrid.SelectedItem as DataRowView).Row[1];
                object cell2 = (DataGrid.SelectedItem as DataRowView).Row[2];
                object cell3 = (DataGrid.SelectedItem as DataRowView).Row[3];
                object cell4 = (DataGrid.SelectedItem as DataRowView).Row[4];

                Full_name.Text = Convert.ToString(cell1);
                Role.Text = Convert.ToString(cell2);
                Login.Text = Convert.ToString(cell3);
                Password.Text = Convert.ToString(cell4);

            }
        }
    }
}