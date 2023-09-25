namespace Replica_WinWin.Models
{
    public class Booking
    {
        public Customer TheCustomer { get; set; } = new();
        public DateTime DateBooked { get; set; } = DateTime.Now;
        public string BookingId { get; set; }

        public string GetBookingDetails()
        {
            return $"Booking Id: {BookingId} \n" +
                $"Customer Name: {TheCustomer.GetFullName()} \n" +
                $"Date Booked: {DateBooked} \n";
        }

    }
}


