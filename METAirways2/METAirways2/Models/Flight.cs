using System;
using System.Collections.Generic;

namespace METAirways2.Models;

public partial class Flight
{
    public int FlightId { get; set; }

    public string FlightName { get; set; } = null!;

    public string FlightType { get; set; } = null!;

    public DateTime FlightDate { get; set; }

    public int Capacity { get; set; }

    public int NoOfSeatsBooked { get; set; }
}
