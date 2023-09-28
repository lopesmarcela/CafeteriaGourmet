namespace CafeteriaGourmet.Models
{
    public class OrderModel
    {
        public string? Id { get; set; }
        public string? ClientId { get; set; }
        public DateTime? Date { get; set; }
        public List<string>? Products { get; set; }
        public string? Status { get; set; }
    }
}
