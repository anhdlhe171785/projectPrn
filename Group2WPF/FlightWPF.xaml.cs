﻿using DataAccess;
using Repositories;
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
    /// Interaction logic for FlightWPF.xaml
    /// </summary>
    public partial class FlightWPF : Window
    {
        private readonly IFlightService iFlightService;
        public FlightWPF()
        {
            InitializeComponent();
            iFlightService = new FlightService();
            LoadFlights();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadFlights();
        }

        private void LoadFlights()
        {
            dgData.ItemsSource = null;
            var flights = iFlightService.GetFlights();
            dgData.ItemsSource = flights;
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (dataGrid.ItemsSource != null)
            {
                DataGridRow row = dataGrid.ItemContainerGenerator
                    .ContainerFromIndex(dataGrid.SelectedIndex) as DataGridRow;
                DataGridCell cell = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;

                string filghtId = ((TextBlock)cell.Content).Text;
                if (!filghtId.Equals(""))
                {
                    Flight flight = iFlightService.GetFlightById(Int32.Parse(filghtId));
                    txtFlightID.Text = flight.Id.ToString();
                    txtAirlineID.Text = flight.AirlineId.ToString();
                    txtDepartingAirport.Text = flight.DepartingAirport.ToString();
                    txtArrivingAirport.Text = flight.ArrivingAirport.ToString();
                    txtDepartingGate.Text = flight.DepartingGate.ToString();
                    txtArrivingGate.Text = flight.ArrivingGate.ToString();
                    dpDepartureTime.Text = flight.DepartureTime.ToString();
                    dpArrivalTime.Text = flight.ArrivalTime.ToString();

                }
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Flight flight = new Flight();
                flight.Id = Int32.Parse(txtFlightID.Text);
                flight.AirlineId = Int32.Parse(txtAirlineID.Text);
                flight.DepartingAirport = Int32.Parse(txtDepartingAirport.Text);
                flight.ArrivingAirport = Int32.Parse(txtArrivingAirport.Text);
                flight.DepartingGate = txtDepartingGate.Text;
                flight.ArrivingGate = txtArrivingGate.Text;
                flight.DepartureTime = dpDepartureTime.SelectedDate.HasValue ? dpDepartureTime.SelectedDate.Value : DateTime.Now;
                flight.ArrivalTime = dpArrivalTime.SelectedDate.HasValue ? dpArrivalTime.SelectedDate.Value : DateTime.Now;
                iFlightService.InsertFlight(flight);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadFlights();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtFlightID.Text.Length > 0)
                {
                    Flight flight = new Flight();
                    flight.Id = Int32.Parse(txtFlightID.Text);
                    flight.AirlineId = Int32.Parse(txtAirlineID.Text);
                    flight.DepartingAirport = Int32.Parse(txtDepartingAirport.Text);
                    flight.ArrivingAirport = Int32.Parse(txtArrivingAirport.Text);
                    flight.DepartingGate = txtDepartingGate.Text;
                    flight.ArrivingGate = txtArrivingGate.Text;
                    flight.DepartureTime = dpDepartureTime.SelectedDate.HasValue ? dpDepartureTime.SelectedDate.Value : DateTime.Now;
                    flight.ArrivalTime = dpArrivalTime.SelectedDate.HasValue ? dpArrivalTime.SelectedDate.Value : DateTime.Now;
                    iFlightService.UpdateFlight(flight);
                }
                else
                {
                    MessageBox.Show("Please select a Flight");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadFlights();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtFlightID.Text.Length > 0)
                {
                    Flight flight = new Flight();
                    flight.Id = Int32.Parse(txtFlightID.Text);
                    flight.AirlineId = Int32.Parse(txtAirlineID.Text);
                    flight.DepartingAirport = Int32.Parse(txtDepartingAirport.Text);
                    flight.ArrivingAirport = Int32.Parse(txtArrivingAirport.Text);
                    flight.DepartingGate = txtDepartingGate.Text;
                    flight.ArrivingGate = txtArrivingGate.Text;
                    flight.DepartureTime = dpDepartureTime.SelectedDate.HasValue ? dpDepartureTime.SelectedDate.Value : DateTime.Now;
                    flight.ArrivalTime = dpArrivalTime.SelectedDate.HasValue ? dpArrivalTime.SelectedDate.Value : DateTime.Now;
                    iFlightService.DeleteFlight(flight);
                }
                else
                {
                    MessageBox.Show("Please select a Flight");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadFlights();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtSearchByFlightID_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int flightID = Int32.Parse(txtFlightIDFliter.Text);
                dgData.ItemsSource = null;
                var foundFlights = iFlightService.GetFlightByFlightID(flightID);
                dgData.ItemsSource = foundFlights;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: can not load products");
            }
        }
    }
}
