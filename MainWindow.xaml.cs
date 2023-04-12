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
using pract5.pr5DataSet1TableAdapters;

namespace pract5
{
    public partial class MainWindow : Window
    {
        UsersTableAdapter adapter = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var alllogins = adapter.GetData().Rows;

            for (int i = 0; i < alllogins.Count; i++)
            {
                if (alllogins[i][3].ToString() == LoginTbx.Text && alllogins[i][4].ToString() == PasswordTbx.Text)
                {
                    string Role = (string)alllogins[i][2];
                    {
                        switch (Role)
                        {
                            case ("Administrator"):  // a123 a321                         
                                FirstRoleWindow role = new FirstRoleWindow();
                                this.Close();
                                role.Show();
                                break; 
                            case ("Student"): // a456 a 456
                                SecondRoleWindow second = new SecondRoleWindow();
                                this.Close();
                                second.Show();
                                break;
                            case ("Seller"): // i123 i123
                                SellerRoleWindow seller = new SellerRoleWindow();
                                this.Close();
                                seller.Show();
                                break;
                        }
                    }
                }
            }
        }
    }
}
