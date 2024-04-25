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
    /// Interaction logic for Billing.xaml
    /// </summary>
    public partial class Billing : Window
    {
        string connStr = "server=ND-COMPSCI;" +
                  "user=TL_S2201379;" +
                  "database=tl_s2201379_ocp;" + // Schema name here
                  "port=3306;" +
                  "password=Notre100606";
        MySqlConnection conn;
        public Billing(int bookingID, int visitingID)
        {
            InitializeComponent();
            LoadBillingInformation(bookingID, visitingID);

        }

        private void LoadBillingInformation(int bookingID, int visitingID)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                // Fetch billing information from the database based on bookingID or visitingID
                string query = "SELECT * FROM billing WHERE BookingID = @BookingID OR VisitingID = @VisitingID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                cmd.Parameters.AddWithValue("@VisitingID", visitingID);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Display billing information in the UI controls
                if (reader.Read())
                {
                    int invoiceNumID = reader.GetInt32("InvoiceNumID");
                    int accountID = reader.IsDBNull(reader.GetOrdinal("AccountID")) ? -1 : reader.GetInt32("AccountID");
                    int roomID = reader.IsDBNull(reader.GetOrdinal("RoomID")) ? -1 : reader.GetInt32("RoomID");
                    decimal bill = reader.IsDBNull(reader.GetOrdinal("Bill")) ? 0 : reader.GetDecimal("Bill");
                    DateTime paymentDate = reader.IsDBNull(reader.GetOrdinal("PaymentDate")) ? DateTime.MinValue : reader.GetDateTime("PaymentDate");

                    // Update UI controls with billing information
                    InvoiceNumberTextBox.Text = invoiceNumID.ToString();
                    AccountIDTextBox.Text = accountID.ToString();
                    BookingIDTextBox.Text = bookingID != -1 ? bookingID.ToString() : "N/A";
                    VisitingIDTextBox.Text = visitingID != -1 ? visitingID.ToString() : "N/A";
                    RoomIDTextBox.Text = roomID != -1 ? roomID.ToString() : "N/A";
                    BillAmountTextBox.Text = bill.ToString();
                    PaymentDateTextBox.Text = paymentDate != DateTime.MinValue ? paymentDate.ToShortDateString() : "N/A";
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for useing Regit Zoo Adventures we hope to see you soon,but for now good bye!");
        }
    }
}
