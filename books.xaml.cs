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
using System.Xaml;

namespace library
{
    /// <summary>
    /// Interaction logic for books.xaml
    /// </summary>
    public partial class books : Window
    {
        public books()
        {
            InitializeComponent();
            lbl1.Content = set.b1;
            lbl2.Content = set.b2;
            lbl3.Content = set.b3;
            lbl4.Content = set.b4;
            lbl5.Content = set.b5;
            lbl6.Content = set.b6;
            lbl7.Content = set.b7;
            lbl8.Content = set.b8;
            lbl9.Content = set.b9;
           



        }
        Settings1 set = new Settings1();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            int avail = set.b1;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b1 = avail;
                set.Save();
                lbl1.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            int avail = set.b1;
            avail++;
            set.b1 = avail;
            set.Save();
            lbl1.Content = avail.ToString();
            MessageBox.Show("Book Returned","success",MessageBoxButton.OK,MessageBoxImage.Information);



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int avail = set.b2;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b2 = avail;
                set.Save();
                lbl2.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int avail = set.b2;
            avail++;
            set.b2 = avail;
            set.Save();
            lbl2.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int avail = set.b3;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b3 = avail;
                set.Save();
                lbl3.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int avail = set.b3;
            avail++;
            set.b3 = avail;
            set.Save();
            lbl3.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int avail = set.b4;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b4 = avail;
                set.Save();
                lbl4.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int avail = set.b4;
            avail++;
            set.b4 = avail;
            set.Save();
            lbl4.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int avail = set.b5;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b5 = avail;
                set.Save();
                lbl5.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int avail = set.b5;
            avail++;
            set.b5 = avail;
            set.Save();
            lbl5.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            int avail = set.b6;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b6 = avail;
                set.Save();
                lbl6.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int avail = set.b6;
            avail++;
            set.b6 = avail;
            set.Save();
            lbl6.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            int avail = set.b7;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b7 = avail;
                set.Save();
                lbl7.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            int avail = set.b7;
            avail++;
            set.b7 = avail;
            set.Save();
            lbl7.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            int avail = set.b8;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b8 = avail;
                set.Save();
                lbl8.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int avail = set.b8;
            avail++;
            set.b8 = avail;
            set.Save();
            lbl8.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            int avail = set.b9;
            if (avail == 0)
            {
                MessageBox.Show("Currently Unavailable.Try Some other book", "try later", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                avail--;
                set.b9 = avail;
                set.Save();
                lbl9.Content = avail.ToString();
                MessageBox.Show("Book Taken", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            int avail = set.b9;
            avail++;
            set.b9 = avail;
            set.Save();
            lbl9.Content = avail.ToString();
            MessageBox.Show("Book Returned", "success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("ARE YOU SURE?", "LOGOUT", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (res == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }

        }
    }
}

           
           
           
           
