namespace Replica_WinWin.Models
{
    public class MallLocation
    {
        public string MallLocationId { get; set; }
        public string MallLocationAddress { get; set; }

        public override string ToString()
        {
            return $"Mall Location: {this.MallLocationAddress}";
        }
    }

}


