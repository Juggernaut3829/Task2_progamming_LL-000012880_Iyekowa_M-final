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
using MySql.Data.MySqlClient;
namespace Task2_progamming_LL_000012880_Iyekowa_M
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
       string connStr = "server=ND-COMPSCI;" +
                 "user=TL_S2201379;" +
                 "database=tl_s2201379_ocp;" + // Schema name here
                 "port=3306;" +
                 "password=Notre100606";
        MySqlConnection conn;
        public Register()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {

          

            // Validate first name
            if (string.IsNullOrEmpty(FirstName.Text))
            {
                MessageBox.Show("Please enter your first name.");
                return false;
            }

            // Validate last name
            if (string.IsNullOrEmpty(LastName.Text))
            {
                MessageBox.Show("Please enter your last name.");
                return false;
            }

            // Validate email
            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Please enter your email.");
                return false;
            }
            else if (!IsValidEmail(Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Validate password
            if (string.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Please enter your password.");
                return false;
            }
            else if (Password.Password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
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

        private void btnsend_Click(object sender, RoutedEventArgs e)
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

                // Insert user details into the database
                string check = $"INSERT INTO account (FirstName, LastName, Email, Password) VALUES (@firstName, @lastName, @email, SHA2(@password, 256))";
                MySqlCommand cmd = new MySqlCommand(check, conn);

                cmd.Parameters.AddWithValue("@firstName", FirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", LastName.Text);
                cmd.Parameters.AddWithValue("@email", Email.Text);
                cmd.Parameters.AddWithValue("@password", Password.Password);
                cmd.ExecuteNonQuery();
                 conn.Close();
                MessageBox.Show("Registration successful. Please sign in.");
                Login login = new Login();
                login.Show();
                this.Close();
                // Close registration window after successful registration

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Registration failed. Please check your details and try again.");
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
            MessageBox.Show("You are currently on this page");

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

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

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
        private void access_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            this.Close();
            account.Show();

        }
    }
}
