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
    public partial class course_materialsWindow : Window
    {
        course_materialsTableAdapter curseM = new course_materialsTableAdapter();
        CoursesTableAdapter curse = new CoursesTableAdapter();
        public course_materialsWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = curseM.GetData();
            ComboBox1.ItemsSource = curse.GetData();
            ComboBox1.DisplayMemberPath = "Course_name";
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


                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9]+$"))
                {
                    curseM.InsertQuery(TextBox1.Text, TextBox2.Text, Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]));
                    DataGrid.ItemsSource = curseM.GetData();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null){

                object id = (DataGrid.SelectedItem as DataRowView).Row[0];
                curseM.DeleteQuery(Convert.ToInt32(id));

                DataGrid.ItemsSource = curseM.GetData();
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


                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9]+$"))
                    {
                        object Original_course_materials_id = (DataGrid.SelectedItem as DataRowView).Row[0];
                        curseM.UpdateQuery(TextBox1.Text, TextBox2.Text, Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(Original_course_materials_id));
                        DataGrid.ItemsSource = curseM.GetData();
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
           

                TextBox1.Text = Convert.ToString(cell1);
                TextBox2.Text = Convert.ToString(cell2);
             


            }
        }
    }
}
