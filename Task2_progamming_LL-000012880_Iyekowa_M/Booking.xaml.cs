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
using System.Xml.Schema;

namespace Task2_progamming_LL_000012880_Iyekowa_M
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        string connStr = "server=ND-COMPSCI;" +
                 "user=TL_S2201379;" +
                 "database=tl_s2201379_ocp;" + 
                 "port=3306;" +
                 "password=Notre100606";
        MySqlConnection conn;
        // Schema name here
        public Booking()
        {
            InitializeComponent();
            PopulateRoomStyles();
            
                
            
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
            MessageBox.Show("You are currently on this page");
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

        private void continue_Click(object sender, RoutedEventArgs e)
        { 
            
            try
            {
                if (!ValidateInput())
                {
                    return; // Input validation failed, do not proceed with booking
                }
                conn = new MySqlConnection(connStr);
                conn.Open();
                string insert = "INSERT INTO booking (StartDate, EndDate, Style, NumAdult, NumChildren, Capacity, Quantity) " +
                             "VALUES (@StartDate, @EndDate, , @Style, @NumAdult, @NumChildren,@Available)";
                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@Style", Style);
                cmd.Parameters.AddWithValue("@NumAdult", NumAdultTB);
                cmd.Parameters.AddWithValue("@NumChildren", NumChildrenTB);
                cmd.Parameters.AddWithValue("@Available", Room);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Booking successful!");
                // Clear input fields or navigate to another page
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                MessageBox.Show("Booking failed!");
            }
            conn.Close();
        }

        private bool ValidateInput()
        {
            // Basic validation for required fields
            if (StartDate.SelectedDate == null || EndDate.SelectedDate == null ||
                string.IsNullOrEmpty(Room.Text)  || string.IsNullOrEmpty(Style.Text) ||
                string.IsNullOrEmpty(NumAdultTB.Text) || string.IsNullOrEmpty(NumChildrenTB.Text))
                
            {
                MessageBox.Show("Please fill in the fields to confirm a booking.");
                return false;
            }
            // Add validation for numeric fields
            int numAdult, numChildren;
            if (!int.TryParse(NumAdultTB.Text, out numAdult) || !int.TryParse(NumChildrenTB.Text, out numChildren)) 
                
            {   MessageBox.Show("Please fill in the fields so we can asigin a room for you and other guests.");
                return false;
            }

            return true;
        }

        private void PopulateRoomStyles()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string query = "SELECT DISTINCT RoomStyle FROM rooms";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string roomStyle = reader.GetString("RoomStyle");
                        Style.Items.Add(roomStyle);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void Style_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                string selectedStyle = Style.SelectedItem?.ToString() ?? "";
                bool wheelchairAccessible = check.IsChecked ?? false; // Check if the checkbox is checked

                // Validate and parse NumAdultTB.Text
                if (!int.TryParse(NumAdultTB.Text, out int numAdult))
                {
                    MessageBox.Show("Please enter a valid number for Number of Adults.");
                    return;
                }

                // Validate and parse NumChildrenTB.Text
                if (!int.TryParse(NumChildrenTB.Text, out int numChildren))
                {
                    MessageBox.Show("Please enter a valid number for Number of Children.");
                    return;
                }

                string query = "SELECT RoomID, RoomName, IsWheelchairAccessible, Capacity FROM rooms WHERE RoomStyle = @Style AND IsWheelchairAccessible = @WheelchairAccessible AND Capacity >= @Capacity";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Style", selectedStyle);
                cmd.Parameters.AddWithValue("@WheelchairAccessible", wheelchairAccessible);
                cmd.Parameters.AddWithValue("@Capacity", numAdult + numChildren);

                Room.Items.Clear(); // Clear previous items

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string roomName = reader.GetString("RoomName");
                        int roomID = reader.GetInt32("RoomID");
                        bool isWheelchairAccessible = reader.GetBoolean("IsWheelchairAccessible");
                        int capacity = reader.GetInt32("Capacity");

                        string displayText = $"{roomName} (ID: {roomID}) - Wheelchair Accessible: {(isWheelchairAccessible ? "Yes" : "No")}, Capacity: {capacity}";
                        Room.Items.Add(displayText);
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void Room_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();
            string insert = "SELECT RoomName FROM rooms";
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Room.Items.Clear(); // Clear previous items

            // Check if there are rows returned
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string roomName = reader.GetString("RoomName");
                    Room.Items.Add(roomName);
                }
            }

            // Close the reader and the connection
            reader.Close();
            conn.Close();
        }

    }
    
}
