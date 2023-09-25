namespace Replica_WinWin.Models
{
    public class Admin : Person
    {
        public string AdminId { get; set; }
        public string GetAdminDetails()
        {
            return $"Admin Id: {AdminId} \n" +
                $"Name: {GetFullName()} \n" +
                $"Username: {Username} \n" +
                $"Email Address: {EmailAddress} \n" +
                $"Birthdate: {Birthdate} \n" +
                $"Home Address: {HomeAddress} \n";
        }
    }
}


