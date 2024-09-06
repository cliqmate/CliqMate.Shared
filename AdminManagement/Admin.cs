using CliqMate.Shared.Users;

namespace CliqMate.Shared.AdminManagement
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public ICollection<Role> Roles { get; set; }

        public void VerifyUser(User user)
        {
            // Logic for verifying a user
        }

        public void SuspendUser(User user)
        {
            // Logic for suspending a user
        }

        public void ResolveReport(Report report)
        {
            // Logic for resolving a report
        }
    }
}
