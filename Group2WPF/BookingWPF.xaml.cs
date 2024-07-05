using DataAccess;
using Services;
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

namespace Group2WPF
{
    /// <summary>
    /// Interaction logic for BookingWPF.xaml
    /// </summary>
    public partial class BookingWPF : Window
    {
        private readonly IBookingService _bookingService;
        public BookingWPF()
        {
            InitializeComponent();
            _bookingService = new BookingService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getAllBooking();
        }
        private void getAllBooking()
        {
            dgData.ItemsSource = null;
            dgData.ItemsSource = _bookingService.getAll();
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (dataGrid.ItemsSource != null)
            {
                DataGridRow row = dataGrid.ItemContainerGenerator
                    .ContainerFromIndex(dataGrid.SelectedIndex) as DataGridRow;
                DataGridCell cell = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;

                string bookingId = ((TextBlock)cell.Content).Text;
                if (!bookingId.Equals(""))
                {
                    Booking booking = _bookingService.getBookingById(Int32.Parse(bookingId));
                    txtId.IsReadOnly = true;
                    txtId.Text = booking.Id.ToString();
                    txtBookingPlatformId.Text = booking.BookingPlatformId.ToString();
                    txtPassengerId.Text = booking.PassengerId.ToString();
                    txtFlightId.Text = booking.FlightId.ToString();
                    txtBookingTime.Text = booking.BookingTime.ToString();
                }
            } else
            {
                MessageBox.Show("Null");
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ResetInput()
        {
            txtId.Text = "";
            txtId.IsReadOnly = false;
            txtPassengerId.Text = "";
            txtFlightId.Text = "";
            txtBookingPlatformId.Text = "";
            txtBookingTime.Text = "";
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Length > 0)
                {
                    Booking booking = new Booking();
                    booking.Id = Int32.Parse(txtId.Text);
                    booking.PassengerId = Int32.Parse(txtPassengerId.Text);
                    booking.FlightId = Int32.Parse(txtFlightId.Text);
                    booking.BookingPlatformId = Int32.Parse(txtBookingPlatformId.Text);
                    booking.BookingTime = DateTime.Parse(txtBookingTime.Text);
                    _bookingService.updateBooking(booking);
                }
                else
                {
                    MessageBox.Show("Please select a Booking");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                getAllBooking();
                ResetInput();
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_bookingService.getBookingById(Int32.Parse(txtId.Text)) != null)
                {
                    MessageBox.Show("Code existed!", "ERROR");
                }
                else
                {
                    Booking booking = new Booking();
                    booking.Id = Int32.Parse(txtId.Text);
                    booking.PassengerId = Int32.Parse(txtPassengerId.Text);
                    booking.FlightId = Int32.Parse(txtFlightId.Text);
                    booking.BookingPlatformId = Int32.Parse(txtBookingPlatformId.Text);
                    booking.BookingTime = DateTime.Parse(txtBookingTime.Text);
                    _bookingService.addBooking(booking);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                getAllBooking();
                ResetInput();
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Length > 0)
                {
                    Booking booking = new Booking();
                    booking.Id = Int32.Parse(txtId.Text);
                    booking.PassengerId = Int32.Parse(txtPassengerId.Text);
                    booking.FlightId = Int32.Parse(txtFlightId.Text);
                    booking.BookingPlatformId = Int32.Parse(txtBookingPlatformId.Text);
                    booking.BookingTime = DateTime.Parse(txtBookingTime.Text);
                    _bookingService.removeBooking(booking);
                }
                else
                {
                    MessageBox.Show("Please select a Booking");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                getAllBooking();
                ResetInput();
            }
        }

        private void filter_PassengerID(object sender, TextChangedEventArgs e)
        {
            if(filterPID.Text.Length > 0)
            dgData.ItemsSource = _bookingService.filterByPassengerID(Int32.Parse(filterPID.Text));
            else getAllBooking();
        }
        private void filter_FlightID(object sender, TextChangedEventArgs e)
        {
            if(filterFID.Text.Length > 0)
            dgData.ItemsSource = _bookingService.filterByFlightID(Int32.Parse(filterFID.Text));
            else getAllBooking();
        }
        private void filter_BookingPlatformID(object sender, TextChangedEventArgs e)
        {
            if(filterBPID.Text.Length > 0)
            dgData.ItemsSource = _bookingService.filterByBookingPlatformID(Int32.Parse(filterBPID.Text));
            else getAllBooking();
        }
        private void filter_BookingTime(object sender, TextChangedEventArgs e)
        {
            if(filterBT.Text.Length > 0)
            dgData.ItemsSource = _bookingService.filterByBookingTime(filterBT.Text);
            else getAllBooking();
        }
    }
}
