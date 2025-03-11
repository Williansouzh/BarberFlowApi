namespace Domain.Models
{
    public class Barber : Entity
    {
        public string? Name { get; private set; }
        public string? Email { get; set; }
        public string? Password_hash { get; private set; }

        public string? Role { get;  private set; }

        public int? Working_hours { get;  private set; }

        public void Update(string name, string email, string passwordHash, string role, int workingHours)
        {
            Validate(name, email, passwordHash, role, workingHours);

            Name = name;
            Email = email;
            Password_hash = passwordHash;
            Role = role;
            Working_hours = workingHours;
        }

        private void Validate(string name, string email, string passwordHash, string role, int workingHours)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Nome não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) throw new ArgumentException("E-mail inválido.");
            if (string.IsNullOrWhiteSpace(passwordHash)) throw new ArgumentException("Senha não pode ser vazia.");
            if (string.IsNullOrWhiteSpace(role)) throw new ArgumentException("Papel do usuário não pode ser vazio.");
            if (workingHours < 0) throw new ArgumentException("Horas de trabalho não podem ser negativas.");
        }
    }
}