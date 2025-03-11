namespace Domain.Models;

    public class Appointments
    {
        public int Id { get; set; }
        public int customer_id { get; set; }
        public int BarberId { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? Status { get; set; }
    }
