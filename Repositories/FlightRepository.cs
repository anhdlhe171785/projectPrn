using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FlightRepository : IFlightRepository
    {

        public List<Flight> GetFlights()
        {
            FlightManagementDbContext myContext = new FlightManagementDbContext();
            return myContext.Flights.ToList();
        }
        public void InsertFlight(Flight flight)
        {
            FlightManagementDbContext myContext = new FlightManagementDbContext();
            myContext.Flights.Add(flight);
            myContext.SaveChanges();
        }

        public void UpdateFlight(Flight flight)
        {
            FlightManagementDbContext myContext = new FlightManagementDbContext();
            myContext.Flights.Update(flight);
            myContext.SaveChanges();
        }
        public void DeleteFlight(Flight flight)
        {
            FlightManagementDbContext myContext = new FlightManagementDbContext();
            myContext.Flights.Remove(flight);
            myContext.SaveChanges();
        }

        public Flight? GetFlightById(int id)
        {
            FlightManagementDbContext myContext = new FlightManagementDbContext();
            return myContext.Flights.Find(id);
        }

        public List<Flight> GetFlightByFlightID(int flightId)
        {
            FlightManagementDbContext myContext = new FlightManagementDbContext();
            return myContext.Flights.Where(f => f.Id == flightId).ToList();
        }
    }
}
