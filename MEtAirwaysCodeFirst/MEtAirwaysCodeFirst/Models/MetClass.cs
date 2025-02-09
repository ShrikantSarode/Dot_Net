using System.ComponentModel.DataAnnotations;

namespace MEtAirwaysCodeFirst.Models
{
    public class MetClass
    {
        [Key]
        public int FlightsID { get; set; }
        public string FlightName { get; set; }
        public string FlightType { get; set; }
        public DateTime FlightDate
        { get; set; }


        public int Capacity { get; set; }   
        public int NoOfSeatsBooked
        { get; set; }
    }
}
