using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    public partial class Timetable_of_classesWindow : Window
    {
        Timetable_of_classesTableAdapter timetable_of_classes = new Timetable_of_classesTableAdapter();
        groupsTableAdapter groups = new groupsTableAdapter();

        public Timetable_of_classesWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = timetable_of_classes.GetData();
            ComboBox1.ItemsSource = groups.GetData();
            ComboBox1.DisplayMemberPath = "Class_start_date";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Time = Convert.ToString(TextBox2.Text);
                string[] parts = Time.Split(':');
                int hours = int.Parse(parts[0]);
                int minute = int.Parse(parts[1]);

                if (hours > 23 || hours < 0 || minute > 59 || minute < 0)
                {
                    MessageBox.Show("Неверно введен формат времени ( формат должен быть hh:mm)");
                }
                else
                {
                    if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || ComboBox1.SelectedValue == null)
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        string input = TextBox1.Text;
                        string input4 = TextBox2.Text;
                        string input5 = TextBox3.Text;

                        if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input4, "^[0-9:]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input5, "^[a-zA-Z]+$"))
                        {
                            timetable_of_classes.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]));
                            DataGrid.ItemsSource = timetable_of_classes.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Не все поля заполнены");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверно введен формат времени ( формат должен быть hh:mm)");
            }


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object id = (DataGrid.SelectedItem as DataRowView).Row[0];
                timetable_of_classes.DeleteQuery(Convert.ToInt32(id));
                DataGrid.ItemsSource = timetable_of_classes.GetData();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Time = Convert.ToString(TextBox2.Text);
                string[] parts = Time.Split(':');
                int hours = int.Parse(parts[0]);
                int minute = int.Parse(parts[1]);

                if (hours > 23 || hours < 0 || minute > 59 || minute < 0)
                {
                    MessageBox.Show("Неверно введен формат времени ( формат должен быть hh:mm)");
                }
                else
                {
                    if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || ComboBox1.SelectedValue == null)
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        string input = TextBox1.Text;
                        string input4 = TextBox2.Text;
                        string input5 = TextBox3.Text;

                        if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input4, "^[0-9:]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input5, "^[a-zA-Z]+$"))
                        {
                            object Original_id_timetable_of_classes = (DataGrid.SelectedItem as DataRowView).Row[0];
                            timetable_of_classes.UpdateQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(Original_id_timetable_of_classes));
                            DataGrid.ItemsSource = timetable_of_classes.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Не все поля заполнены");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверно введен формат времени ( формат должен быть hh:mm)");
            }
        }
    
    
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SecondRoleWindow dfs = new SecondRoleWindow();
            this.Close();
            dfs.Show();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox1.SelectedItem as DataRowView).Row[1];
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object cell1 = (DataGrid.SelectedItem as DataRowView).Row[1];
                object cell2 = (DataGrid.SelectedItem as DataRowView).Row[2];
                object cell3 = (DataGrid.SelectedItem as DataRowView).Row[3];


                TextBox1.Text = Convert.ToString(cell1);
                TextBox2.Text = Convert.ToString(cell2);
                TextBox3.Text = Convert.ToString(cell3);
         

            }
        }
    }
}
