namespace BusTicketingWebApplication.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public float Cost { get; set; }
        public int Capacity { get; set; }
        public int BookedSeats { get; set; }
        public int AvailableSeats { get; set; }



    }
}
