namespace Replica_WinWin.Models
{
    public class Cinema
    {
        public string CinemaId { get; set; }
        public int SeatCapacity { get; set; }
        public MallLocation TheMallLocation { get; set; }

        public Cinema(MallLocation theMallLocation)
        {
            this.TheMallLocation = theMallLocation;
        }
    }

}


