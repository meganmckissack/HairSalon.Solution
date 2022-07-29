
namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}