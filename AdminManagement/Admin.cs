namespace CliqMate.Shared.AdminManagement
{
    public class Admin
    {
        // Changed Id from int to Guid and initialized it in the constructor
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public ICollection<AdminRole> Roles { get; set; }

        // Constructor
        public Admin(string username, string email, string passwordHash)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;  // Automatically set creation time
            Roles = new List<AdminRole>();      // Initialize the Roles collection
        }
    }
}
