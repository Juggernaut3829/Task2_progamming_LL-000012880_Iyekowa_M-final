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
using MySql.Data.MySqlClient;

namespace Task2_progamming_LL_000012880_Iyekowa_M
{
    /// <summary>
    /// Interaction logic for ContactUs.xaml
    /// </summary>
    public partial class ContactUs : Window
    {
        string connStr = "server=ND-COMPSCI;" +
                 "user=TL_S2201379;" +
                 "database=tl_s2201379_ocp;" + // Schema name here
                 "port=3306;" +
                 "password=Notre100606";
        MySqlConnection conn;
        public ContactUs()
        {
            InitializeComponent();
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
            MessageBox.Show("You are currently on this page");
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
        private bool ValidateInput()
        { 
            // Validate password
            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Please enter your email.");
                return false;
            }
            else if (Email.Text.Contains("@"))
            {
                MessageBox.Show("email must contain a @.");
                return false;
            }

            if (string.IsNullOrEmpty(message.Text))
            {
                MessageBox.Show("Please enter your email.");
                return false;
            }
            else if (message.Text.Length < 10)
            {
                MessageBox.Show("The message must contain a minimum of 10 characters.");
                MessageBox.Show("Please write a message that fits that critira.");
                return false;
            }

            return true;

        }
        private void send_Click(object sender, RoutedEventArgs e)
        {
            

            // If validation passes, proceed with registration
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                // Insert user details into the database
                string check = $"INSERT INTO contact (Email,Message) VALUES (@email, @message)";
                MySqlCommand cmd = new MySqlCommand(check, conn);

                cmd.Parameters.AddWithValue("@email", Email.Text);
                cmd.Parameters.AddWithValue("@message", message.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Message has been sent");
                MessageBox.Show("Replies normally take 3-5 business days.we ask that you wait patiently until we can get back in contact with you");
                MessageBox.Show("We ask that you wait patiently until we can get back in contact with you");

                // Close registration window after successful registration
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("message failed to be sent. Please check your details and try again.");
            }

        }

    }
}

