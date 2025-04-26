namespace ApiProjectKampi.WebApi.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int NameSurname { get; set; }
        public int Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public String ReservationTime { get; set; }
        public int CountOfPeople { get; set; }
        public string Message { get; set; }
        public bool ReservationStatus { get; set; }
    }
}
