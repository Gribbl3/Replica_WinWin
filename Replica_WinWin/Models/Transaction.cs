namespace Replica_WinWin.Models
{
    public class Transaction
    {
        public Customer TheCustomer { get; set; } = new();

        public Booking TheBooking { get; set; } = new();
        public string TransactionId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DatePaid { get; set; }

        public string GetTransactionDetails()
        {
            return $"Transaction Id: {TransactionId} \n" +
                $"Customer Name: {TheCustomer.GetFullName()} \n" +
                $"Date Paid: {DatePaid} \n" +
                $"Is Paid: {IsPaid} \n";
        }

        public Transaction(Customer theCustomer, Booking theBooking)
        {
            this.TheCustomer = theCustomer;
            this.TheBooking = theBooking;
        }
    }
}


