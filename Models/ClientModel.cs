namespace CafeteriaGourmet.Models
{
    public class ClientModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsSubscriber { get; set; }
    }
}
