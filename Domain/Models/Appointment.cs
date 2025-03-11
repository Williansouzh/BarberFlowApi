namespace Domain.Models;

    public class Appointment : Entity
    {
        public int customer_id { get; private set; }
        public int BarberId { get; private set; }
        public string? Date { get; private set; }
        public string? Time { get; private set; }
        public string? Status { get;  private set; }

        public void validate(string date, string time, string status)
        {
            if (string.IsNullOrWhiteSpace(date)) throw new ArgumentException("Data não pode ser vazia.");
            if (string.IsNullOrWhiteSpace(time)) throw new ArgumentException("Hora não pode ser vazia.");
            if (string.IsNullOrWhiteSpace(status)) throw new ArgumentException("Status não pode ser vazio.");
        }
        public void Update(int customer_id, int barberId, string date, string time, string status)
        {
            validate(date, time, status);

            this.customer_id = customer_id;
            BarberId = barberId;
            Date = date;
            Time = time;
            Status = status;
        }
    }
