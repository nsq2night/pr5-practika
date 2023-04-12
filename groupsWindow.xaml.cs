using pract5.pr5DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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

namespace pract5
{
    public partial class groupsWindow : Window
    {
        groupsTableAdapter groups = new groupsTableAdapter();
        studentsTableAdapter student = new studentsTableAdapter();
        public groupsWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = groups.GetData();
            ComboBox1.ItemsSource = student.GetData();
            ComboBox1.DisplayMemberPath = "Full_name";
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox1.SelectedItem as DataRowView).Row[1];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string date = Convert.ToString(TextBox1.Text);
                string[] parts = date.Split('-');
                int god = int.Parse(parts[0]);
                int den = int.Parse(parts[1]);
                int hours = int.Parse(parts[2]);


                if (den > 30 || den < 0 || hours > 12 || hours < 0 || god > 2023 || god < 0)
                {
                    MessageBox.Show("Неверно введен формат времени");
                }
                else
                {
                    if (ComboBox1.SelectedValue == null || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        string input1 = TextBox1.Text;
                        string input2 = TextBox2.Text;
                        string input3 = TextBox3.Text;


                        if (System.Text.RegularExpressions.Regex.IsMatch(input1, "^[a-zA-Z0-9-.]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z0-9-.]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Z0-9-.]+$"))
                        {
                            groups.InsertQuery(Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), TextBox1.Text, TextBox2.Text, TextBox3.Text);
                            DataGrid.ItemsSource = groups.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Не верный формат");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверно введен формат времени");
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object id = (DataGrid.SelectedItem as DataRowView).Row[0];
                groups.DeleteQuery(Convert.ToInt32(id));
                DataGrid.ItemsSource = groups.GetData();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string date = Convert.ToString(TextBox1.Text);
                string[] parts = date.Split('-');
                int god = int.Parse(parts[0]);
                int den = int.Parse(parts[1]);
                int hours = int.Parse(parts[2]);


                if (den > 30 || den < 0 || hours > 12 || hours < 0 || god > 2023 || god < 0)
                {
                    MessageBox.Show("Неверно введен формат времени");
                }
                else
                {
                    if (ComboBox1.SelectedValue == null || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        string input1 = TextBox1.Text;
                        string input2 = TextBox2.Text;
                        string input3 = TextBox3.Text;


                        if (System.Text.RegularExpressions.Regex.IsMatch(input1, "^[0-9-.]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input2, "^[0-9-]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Z0-9]+$"))
                        {
                            object Original_id_groups = (DataGrid.SelectedItem as DataRowView).Row[0];
                            groups.UpdateQuery(Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), TextBox1.Text, TextBox2.Text, TextBox3.Text, Convert.ToInt32(Original_id_groups));
                            DataGrid.ItemsSource = groups.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Не верный формат");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверно введен формат времени");
            }



        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SecondRoleWindow sdf = new SecondRoleWindow();
            this.Close();
            sdf.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                if (DataGrid.SelectedItem != null)
                {
                    object cell1 = (DataGrid.SelectedItem as DataRowView).Row[1];
                    object cell2 = (DataGrid.SelectedItem as DataRowView).Row[2];
                    object cell3 = (DataGrid.SelectedItem as DataRowView).Row[3];


                    TextBox1.Text = Convert.ToString(cell2);
                    TextBox2.Text = Convert.ToString(cell1);
                    TextBox3.Text = Convert.ToString(cell3);


                }
            }
            catch
            {
                MessageBox.Show("Вы выбрали пустую строку");
            }
        }
    }
}
