﻿using System;
using System.Collections.Generic;

namespace DataAccess;

public partial class Flight
{
    public int Id { get; set; }

    public int? AirlineId { get; set; }

    public int? DepartingAirport { get; set; }

    public int? ArrivingAirport { get; set; }

    public string? DepartingGate { get; set; }

    public string? ArrivingGate { get; set; }

    public DateTime? DepartureTime { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual Airport? ArrivingAirportNavigation { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Airport? DepartingAirportNavigation { get; set; }
}
