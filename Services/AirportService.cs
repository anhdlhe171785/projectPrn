using DataAccess;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _airportss;

        public AirportService()
        {
            _airportss = new AirportRepository();
        }
        public void DeleteAirport(Airport airport)
        {
            _airportss.DeleteAirport(airport);
        }

        public Airport? GetAirportById(int id)
        {
            return _airportss.GetAirportbyId(id);
        }

        public List<Airport> GetAirports()
        {
            return _airportss.GetAirlines();
        }

        public void InsertAirport(Airport airport)
        {
            _airportss.InsertAirprot(airport);
        }

        public void UpdateAirport(Airport airport)
        {
            _airportss.UpdateAirport(airport);
        }
        public List<Airport> FillterName(string name)
        {
            return _airportss.Filltername(name);
        }
    }
}
