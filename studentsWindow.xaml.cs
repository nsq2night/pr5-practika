using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class studentsWindow : Window
    {
        studentsTableAdapter student = new studentsTableAdapter();
        student_achievementTableAdapter studA = new student_achievementTableAdapter();
        public studentsWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = student.GetData();
            ComboBox1.ItemsSource = studA.GetData();
            ComboBox1.DisplayMemberPath = "Full_name_students";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (ComboBox1.SelectedValue == null || TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string input = TextBox1.Text;
                string input4 = TextBox2.Text;


                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9@.]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9]+$"))
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9]+$"))
                    {
                        MessageBox.Show("Ytn");
                    }
                    else
                    {
                        string Time = Convert.ToString(TextBox1.Text);
                        string[] parts = Time.Split('@');
                        string hours = (parts[0]);
                        string minute = (parts[1]);
                        string minut2e = @"^[\w-\.]+@([\w−]+\.)+[\w−]{2,4}$";
                        if (Regex.IsMatch(input, minut2e, RegexOptions.IgnoreCase))
                        {
                        student.InsertQuery(Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), TextBox1.Text, TextBox2.Text);
                        DataGrid.ItemsSource = student.GetData();

                        }
                        else
                        {
                            MessageBox.Show("sdojgsljgsgsfsgf");
                        }

                    }
                   
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
                student.DeleteQuery(Convert.ToInt32(id));
                DataGrid.ItemsSource = student.GetData();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                if (ComboBox1.SelectedValue == null || TextBox1.Text == "" || TextBox2.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input = TextBox1.Text;
                    string input4 = TextBox2.Text;


                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9@.]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9]+$"))
                    {

                        object Original_id_student = (DataGrid.SelectedItem as DataRowView).Row[0];
                        student.UpdateQuery(Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), TextBox1.Text, TextBox2.Text, Convert.ToInt32(Original_id_student));
                        DataGrid.ItemsSource = student.GetData();

                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SecondRoleWindow gfd = new SecondRoleWindow();
            this.Close();
            gfd.Show();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox1.SelectedItem as DataRowView).Row[1];
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {


                if (DataGrid.SelectedItem != null)
                {
                    object cell1 = (DataGrid.SelectedItem as DataRowView).Row[2];
                    object cell2 = (DataGrid.SelectedItem as DataRowView).Row[3];



                    TextBox1.Text = Convert.ToString(cell2);
                    TextBox2.Text = Convert.ToString(cell1);



                }
            }
            catch
            {
                MessageBox.Show("");
            }
        }
    }
}
