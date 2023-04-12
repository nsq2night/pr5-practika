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

    public partial class BranchesWindow : Window
    {
        BranchesTableAdapter branches = new BranchesTableAdapter();

        public BranchesWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = branches.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = TextBox3.Text;
            int count = text.Length;
            if ( count != 11)
            {
                MessageBox.Show("");
            }
            else
            {
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input1 = TextBox1.Text;
                    string input2 = TextBox2.Text;
                    string input3 = TextBox3.Text;
                    string input4 = TextBox4.Text;

                    if (System.Text.RegularExpressions.Regex.IsMatch(input1, "^[a-zA-Z ]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z0-9 ]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input3, "^[0-9 ]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9@., ]+$"))
                    {
                        branches.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
                        DataGrid.ItemsSource = branches.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object id = (DataGrid.SelectedItem as DataRowView).Row[0];
                branches.DeleteQuery(Convert.ToInt32(id));
                DataGrid.ItemsSource = branches.GetData();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            string text = TextBox3.Text;
            int count = text.Length;
            if (count != 11)
            {
                MessageBox.Show("");
            }
            else
            {
                if (DataGrid.SelectedItem != null)
                {
                    if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        string input1 = TextBox1.Text;
                        string input2 = TextBox2.Text;
                        string input3 = TextBox3.Text;
                        string input4 = TextBox4.Text;

                        if (System.Text.RegularExpressions.Regex.IsMatch(input1, "^[a-zA-Z ]+$") &&
                                System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z0-9 ]+$") &&
                                System.Text.RegularExpressions.Regex.IsMatch(input3, "^[0-9 ]+$") &&
                                System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z0-9@., ]+$"))
                        {
                            object Original_id_Branches = (DataGrid.SelectedItem as DataRowView).Row[0];
                            branches.UpdateQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, Convert.ToInt32(Original_id_Branches));
                            DataGrid.ItemsSource = branches.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Не все поля заполнены");
                        }
                    }
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SecondRoleWindow sad = new SecondRoleWindow();
            this.Close();
            sad.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object cell1 = (DataGrid.SelectedItem as DataRowView).Row[1];
                object cell2 = (DataGrid.SelectedItem as DataRowView).Row[2];
                object cell3 = (DataGrid.SelectedItem as DataRowView).Row[3];
                object cell4 = (DataGrid.SelectedItem as DataRowView).Row[4];


                TextBox1.Text = Convert.ToString(cell1);
                TextBox2.Text = Convert.ToString(cell2);
                TextBox3.Text = Convert.ToString(cell3);
                TextBox4.Text = Convert.ToString(cell4);


            }
        }
    }
}
