namespace CliqMate.Shared.AdminManagement
{
    public class AdminPermission
    {
        public int Id { get; set; }

        // Name of the permission (e.g., "CanVerifyUser", "CanDeleteUser", etc.)
        public string Name { get; set; }

        // Description of what this permission allows (optional but useful for documentation)
        public string? Description { get; set; }

        // Constructor
        public AdminPermission(int id, string name, string? description = null)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
