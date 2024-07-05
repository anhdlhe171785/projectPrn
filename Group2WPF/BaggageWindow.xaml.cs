using DataAccess;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Group2WPF
{
    /// <summary>
    /// Interaction logic for BaggageWindow.xaml
    /// </summary>
    public partial class BaggageWindow : Window
    {
        private FlightManagementDbContext _context;
        private Baggage _selectedBaggage;

        public BaggageWindow()
        {
            InitializeComponent();
            _context = new FlightManagementDbContext();
            LoadData();
            LoadBookingIds();
        }

        private void LoadData()
        {
            BaggageDataGrid.ItemsSource = _context.Baggages.ToList();
        }

        private void LoadBookingIds()
        {
            BookingIdComboBox.ItemsSource = _context.Bookings.ToList();
        }

        private void BaggageDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedBaggage = (Baggage)BaggageDataGrid.SelectedItem;

            if (_selectedBaggage != null)
            {
                IdTextBox.Text = _selectedBaggage.Id.ToString();
                BookingIdComboBox.SelectedValue = _selectedBaggage.BookingId;
                WeightInKgTextBox.Text = _selectedBaggage.WeightInKg.ToString();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(IdTextBox.Text, out int id))
            {
                // Check for duplicate ID
                if (_context.Baggages.Any(b => b.Id == id))
                {
                    MessageBox.Show("Duplicate ID. Please enter a unique ID.");
                    return;
                }

                var newBaggage = new Baggage
                {
                    Id = id,
                    BookingId = (int)BookingIdComboBox.SelectedValue,
                    WeightInKg = decimal.Parse(WeightInKgTextBox.Text)
                };

                _context.Baggages.Add(newBaggage);
                _context.SaveChanges();
                LoadData();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedBaggage != null)
            {
                int newId = int.Parse(IdTextBox.Text);

                // Check for duplicate ID
                if (_context.Baggages.Any(b => b.Id == newId && b.Id != _selectedBaggage.Id))
                {
                    MessageBox.Show("Duplicate ID. Please enter a unique ID.");
                    return;
                }

                _selectedBaggage.Id = newId;
                _selectedBaggage.BookingId = (int)BookingIdComboBox.SelectedValue;
                _selectedBaggage.WeightInKg = decimal.Parse(WeightInKgTextBox.Text);

                _context.SaveChanges();
                LoadData();
                ResetFields();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedBaggage != null)
            {
                _context.Baggages.Remove(_selectedBaggage);
                _context.SaveChanges();
                LoadData();
                ResetFields();
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            IdTextBox.Text = string.Empty;
            BookingIdComboBox.SelectedIndex = -1;
            WeightInKgTextBox.Text = string.Empty;
         
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WeightInKgTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
