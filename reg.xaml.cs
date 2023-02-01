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
namespace library
{
    /// <summary>
    /// Interaction logic for reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        public reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string filepath = System.IO.Path.Combine(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct\" + txtname.Text + ".txt");

            bool isfileavailable = File.Exists(filepath);
            if ((txtname.Text == "") || (txtdob.Text == "") || (txtadd.Text == "") || (pswd.Password == "") || (txtmail.Text == "") || (txtnum.Text == ""))
            {
                MessageBox.Show("please fill all details", "alert", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
            else if (isfileavailable)
            {
                MessageBox.Show("User Name Already Exists");
            }
             else
            {
                File.WriteAllText(filepath, "NAME  :" + txtname.Text + "\n" + "DOB  :" + txtdob.Text + "\n" + "ADDRESS  :" + txtadd.Text + "\n" + "EMAIL ID :" + txtmail.Text + "\n" + "PASSWORD :" + pswd.Password + "\n" + "PHONE NUMBER :" + txtnum.Text);
                MessageBoxResult res=  MessageBox.Show("Registered Successfully", "success", MessageBoxButton.OK, MessageBoxImage.Information);
           
            if(res==MessageBoxResult.OK)
                {
                    login olog = new login();
                    olog.Show();
                    this.Close();
                }
            }

            //File.WriteAllText(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct\" + txtname.Text + ".txt",  "NAME  :" + txtname.Text + "\n" + "DOB  :" + txtdob.Text + "\n" + "ADDRESS  :" + txtadd.Text + "\n" + "EMAIL ID :" + txtmail.Text + "\n" + "PASSWORD :" + pswd.Password + "\n" + "PHONE NUMBER :" + txtnum.Text);
            //MessageBoxResult res = MessageBox.Show("Registered Successfully", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            //if (res == MessageBoxResult.OK)
            //{
            //    txtname.Clear();
            //    txtdob.Clear();
            //    txtmail.Clear();
            //    txtadd.Clear();
            //    txtnum.Clear();
            //    pswd.Clear();
            //}
        }
    }
}
