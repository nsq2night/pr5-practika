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
using System.Windows.Shapes;
using pract5.pr5DataSet1TableAdapters;

namespace pract5
{
    public partial class SecondRoleWindow : Window
    {
        public SecondRoleWindow()
        {
            InitializeComponent();
            CoursesTableAdapter courses = new CoursesTableAdapter();
            course_materialsTableAdapter course_Materials = new course_materialsTableAdapter();
            BranchesTableAdapter branches = new BranchesTableAdapter();
            Timetable_of_classesTableAdapter Timetable_of_classes = new Timetable_of_classesTableAdapter();
            groupsTableAdapter groups = new groupsTableAdapter();
            studentsTableAdapter students = new studentsTableAdapter();
        }

        private void Courses_Click(object sender, RoutedEventArgs e)
        {
            CoursesWindow b = new CoursesWindow();
            this.Close();
            b.Show();
        }

        private void course_materials_Click(object sender, RoutedEventArgs e)
        {
            course_materialsWindow c = new course_materialsWindow();
            this.Close();
            c.Show();
        }

        private void Branches_Click(object sender, RoutedEventArgs e)
        {
            BranchesWindow df = new BranchesWindow();
            this.Close();
            df.Show();
        }

        private void Timetable_of_classes_Click(object sender, RoutedEventArgs e)
        {
            Timetable_of_classesWindow fd = new Timetable_of_classesWindow();
            this.Close();
            fd.Show();
        }

        private void groups_Click(object sender, RoutedEventArgs e)
        {
            groupsWindow jk = new groupsWindow();
            this.Close();
            jk.Show();
        }

        private void students_Click(object sender, RoutedEventArgs e)
        {
            studentsWindow fox = new studentsWindow();
            this.Close();
            fox.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow rebit = new MainWindow();
            this.Close();
            rebit.Show();
        }
    }
}
