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
using System.IO;
using System.Xml.Linq;

namespace library
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String file = System.IO.Path.Combine(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct\", txtname1.Text + ".txt");

            //String all = File.ReadAllText(file);

            bool isfileavailable = File.Exists(file);
            if (isfileavailable && pswd1.Password != "")
            {
                
                books obook = new books();
                obook.Show();
                this.Close();
            }
            else
            {
                MessageBoxResult res = MessageBox.Show("Invalid Username and Password", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                if (res == MessageBoxResult.OK)
                {
                    txtname1.Clear();
                    pswd1.Clear();
                }
            }
                //string name = txtname1.Text;

                //string password = pswd1.Password;

                //Settings1 settings = new Settings1();

                //bool isfileavailable = File.Exists(file);
                //if (isfileavailable)
                //{
                //    //MessageBox.Show("User Name Already Exists");
                //    if(pswd1.Password == password)

                //        {
                //            books up = new books();
                //            up.Show();
                //            this.Close();
                //        }
                //    else
                //    {
                //        MessageBoxResult res = MessageBox.Show("Invalid Username and Password", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //        if (res == MessageBoxResult.OK)
                //        {
                //            txtname1.Clear();
                //            pswd1.Clear();
                //        }
                //    }
                //}

                //if (txtname1.Text == name && pswd1.Password == password)
                //{
                //    books up = new books();
                //    up.Show();
                //    this.Close();
                //}
                //else
                //{
                //    MessageBoxResult res = MessageBox.Show("Invalid Username and Password", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //    if (res == MessageBoxResult.OK)
                //    {
                //        txtname1.Clear();
                //        pswd1.Clear();
                //    }
                //}
            }
        }
}
