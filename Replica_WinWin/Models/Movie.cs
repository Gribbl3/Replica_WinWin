using Replica_WinWin.Enumerations;

namespace Replica_WinWin.Models
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public MovieStatus Status { get; set; }
        public int MovieDuration { get; set; }

        public string GetMovieDetails()
        {
            return $"Movie Id: {MovieId} \n" +
                $"Movie Name: {MovieName} \n" +
                $"Movie Description: {MovieDescription} \n" +
                $"Movie Duration: {MovieDuration} \n";
        }
    }

}


