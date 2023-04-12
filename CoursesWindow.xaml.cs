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
    public partial class CoursesWindow : Window
    {
        CoursesTableAdapter cours = new CoursesTableAdapter();
        BranchesTableAdapter branches = new BranchesTableAdapter();
        Timetable_of_classesTableAdapter timetable_of_classes = new Timetable_of_classesTableAdapter();
        public CoursesWindow()
        {
            InitializeComponent(); 
            DataGridC.ItemsSource = cours.GetData(); 
          //  ComboBox1.ItemsSource = null; ComboBox2.ItemsSource = null;
            ComboBox1.ItemsSource = branches.GetData();
            ComboBox1.DisplayMemberPath = "Name";
            ComboBox2.ItemsSource = timetable_of_classes.GetData();
            ComboBox2.DisplayMemberPath = "Day_of_the_week";
            //branches
            //timetable_of_classes

        }
        private void ButtonC_Click(object sender, RoutedEventArgs e)  
        {
            if (Course_name.Text == "" || ComboBox1.SelectedValue == null || ComboBox2.SelectedValue == null || Price.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string input = Course_name.Text;
                string input4 = Price.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9.,]+$"))
                {
                    cours.InsertQuery(Course_name.Text, Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((ComboBox2.SelectedItem as DataRowView).Row[0]), Convert.ToDouble(Price.Text));
                    DataGridC.ItemsSource = cours.GetData();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
        }
        private void DeleteC_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridC.SelectedItem != null)
            {
                object id = (DataGridC.SelectedItem as DataRowView).Row[0];
                cours.DeleteQuery(Convert.ToInt32(id));
                DataGridC.ItemsSource = cours.GetData();
            }
        }

        private void UpC_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridC.SelectedItem != null)
            {
                if (Course_name.Text == "" || ComboBox1.SelectedValue == null || ComboBox2.SelectedValue == null || Price.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input = Course_name.Text;
                    string input4 = Price.Text;

                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9.,]+$"))
                    {
                        object Original_id_Courses = (DataGridC.SelectedItem as DataRowView);
                        cours.UpdateQuery(Course_name.Text, Convert.ToInt32((ComboBox1.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((ComboBox2.SelectedItem as DataRowView).Row[0]), Convert.ToDouble(Price.Text), Convert.ToInt32(Original_id_Courses));
                        DataGridC.ItemsSource = cours.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                }
            }
        }

        private void ExitC_Click(object sender, RoutedEventArgs e)
        {
            SecondRoleWindow a = new SecondRoleWindow();
            this.Close();
            a.Show();
        }
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox1.SelectedItem as DataRowView).Row[1];

        }
        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ComboBox2.SelectedItem as DataRowView).Row[1];
        }

        private void ison_Click(object sender, RoutedEventArgs e)
        {
            List<Class1> forImport = Class3.Der<List<Class1>>();
            
            foreach (var item in forImport)
            {
                cours.InsertQuery(item.Course_name,Convert.ToInt32(item.id_branches),Convert.ToInt32(item.timetable), Convert.ToDouble(item.Price));
            }
            DataGridC.ItemsSource = null;
            DataGridC.ItemsSource = cours.GetData();
        }

        private void DataGridC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridC.SelectedItem != null)
            {
                object cell1 = (DataGridC.SelectedItem as DataRowView).Row[1];
                object cell2 = (DataGridC.SelectedItem as DataRowView).Row[4];


                Course_name.Text = Convert.ToString(cell1);
                Price.Text = Convert.ToString(cell2);


            }
        }
    }
}
// object cell = (ComboBox2.SelectedItem as DataRowView).Row[1];