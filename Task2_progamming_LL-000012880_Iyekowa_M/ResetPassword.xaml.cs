using MySql.Data.MySqlClient;
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

namespace Task2_progamming_LL_000012880_Iyekowa_M
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// </summary>
    public partial class ResetPassword : Window
    {
        string connStr = "server=ND-COMPSCI;" +
                 "user=TL_S2201379;" +
                 "database=tl_s2201379_ocp;" + // Schema name here
                 "port=3306;" +
                 "password=Notre100606";
        MySqlConnection conn; 

        public ResetPassword()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {


            // Validate email
            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Please enter your email.");
                return false;
            }
            else if (!IsValidemail(Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Validate password
            else if (string.IsNullOrEmpty(Pass.Password))
            {
                MessageBox.Show("Please enter your new password.");
                return false;
            }
            else if (Password.Password.Length < 6)
            {
                MessageBox.Show("password must be at least 6 characters long.");
                return false;
            }


            // Validate password
            else if (string.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Please enter your new password.");
                return false;
            } 
            else if (string.IsNullOrEmpty(Pass.Password))
            {
                MessageBox.Show("Please enter your new password.");
                return false;
            }
            else if (Password.Password.Length < 6)
            {
                MessageBox.Show("password must be at least 6 characters long.");
                return false;
            }

          

            return true;
        }

        private bool IsValidemail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput())
            {
                return; // Input validation failed, do not proceed with registration
            }

            // If validation passes, proceed with registration

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                string updateQuery = "UPDATE account SET password = SHA2(@password, 256) WHERE email = @email";
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@password", Password.Password);
                cmd.Parameters.AddWithValue("@email", Email.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password reset is successful. Please sign in.");
                    Login login = new Login();
                    login.Show();
                    this.Close(); // Close password reset window after successful reset
                }
                else
                {

                    MessageBox.Show("Password reset failed. Please check your details and try again.");
                }
            }
            catch (Exception ex)
                {
                    // Log the detailed exception for further investigation
                    MessageBox.Show(ex.ToString());
                }


        }
      
    

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            this.Close();
            account.Show();
        }

        private void Map_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            this.Close();
            map.Show();
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            Booking booking = new Booking();
            this.Close();
            booking.Show();
        }

        private void Vist_Click(object sender, RoutedEventArgs e)
        {
            Visiting visiting = new Visiting();
            this.Close();
            visiting.Show();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            AboutUs aboutus = new AboutUs();
            this.Close();
            aboutus.Show();
        }

        private void Articles_Click(object sender, RoutedEventArgs e)
        {
            Infomation info = new Infomation();
            this.Close();
            info.Show();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void Deal_Click(object sender, RoutedEventArgs e)
        {
            Discount discount = new Discount();
            this.Close();
            discount.Show();
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            this.Close();
            contactUs.Show();
        }

        private void Policy_Click(object sender, RoutedEventArgs e)
        {
            Policy policy = new Policy();
            this.Close();
            policy.Show();
        }

        private void Ts_and_Cs_Click(object sender, RoutedEventArgs e)
        {
            Terms terms = new Terms();
            this.Close();
            terms.Show();
        }

        private void access_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            this.Close();
            account.Show();

        }

    }
}
