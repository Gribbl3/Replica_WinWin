namespace Replica_WinWin.Models
{
    public class Person
    {
        public string FirstNane { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Birthdate { get; set; }
        public string HomeAddress { get; set; }

        //get full name
        public string GetFullName()
        {
            return $"{FirstNane} {MiddleName} {LastName}";
        }

        //login
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

    }
}


