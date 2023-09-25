namespace Replica_WinWin.Models
{
    public class Customer : Person
    {
        public string CustomerId { get; set; }
        public string GetCustomerDetails()
        {
            return $"Customer Id: {CustomerId} \n" +
                $"Name: {GetFullName()} \n" +
                $"Username: {Username} \n" +
                $"Email Address: {EmailAddress} \n" +
                $"Birthdate: {Birthdate} \n" +
                $"Home Address: {HomeAddress} \n";
        }
    }
}


