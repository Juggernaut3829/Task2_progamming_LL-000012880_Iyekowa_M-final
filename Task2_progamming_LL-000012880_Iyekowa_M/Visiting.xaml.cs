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
    /// Interaction logic for Visiting.xaml
    /// </summary>
    public partial class Visiting : Window
    {
        string connStr = "server=ND-COMPSCI;" +
               "user=TL_S2201379;" +
               "database=tl_s2201379_ocp;" +
               "port=3306;" +
               "password=Notre100606";
        MySqlConnection conn;
        // Schema name here
        public Visiting()
        {
            InitializeComponent();
        } 
        private void continue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                    string insert = "INSERT INTO visit(NumGuest, TicketType, Date) VALUES (@numGuest, @ticket, @Date)";
                    MySqlCommand cmd = new MySqlCommand(insert, conn);

                    // Convert NumTB.Text to integer assuming it represents the number of guests
                    if (int.TryParse(NumTB.Text, out int numGuest))
                    {
                        cmd.Parameters.AddWithValue("@numGuest", numGuest);
                    }
                    else
                    {
                        // Handle invalid input for the number of guests
                        MessageBox.Show("Invalid input for the number of guests.");
                        return;
                    }

                    // Assuming Type.SelectedItem.ToString() represents the selected ticket type
                    cmd.Parameters.AddWithValue("@ticket", Type.SelectedItem?.ToString());

                    // Assuming Date.Text represents the selected date
                    cmd.Parameters.AddWithValue("@Date", Date.Text);

                    cmd.ExecuteNonQuery();
                

                // Optional: Provide feedback to the user that the booking was successful
                MessageBox.Show("Booking successful!");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Type.Items.Add("Single");
            Type.Items.Add("Group"); 
            Type.Items.Add("Educational trip");
            Type.Items.Add("Guided tour");

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
            MessageBox.Show("You are currently on this page");
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
