namespace Domain.Models
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string Role { get; private set; }

        // Construtor protege a criação do objeto
        public User(string name, string email, string passwordHash, string role)
        {
            Validate(name, email, passwordHash, role);

            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }

        public void Update(string name, string email, string passwordHash, string role)
        {
            Validate(name, email, passwordHash, role);

            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }

        private void Validate(string name, string email, string passwordHash, string role)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Nome não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) throw new ArgumentException("E-mail inválido.");
            if (string.IsNullOrWhiteSpace(passwordHash)) throw new ArgumentException("Senha não pode ser vazia.");
            if (string.IsNullOrWhiteSpace(role)) throw new ArgumentException("Papel do usuário não pode ser vazio.");
        }
    }
}
