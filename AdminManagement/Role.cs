using System.Collections.Generic;

namespace CliqMate.Shared.AdminManagement
{
    public class Role
    {
        public int Id { get; set; }

        // Name of the role (e.g., "Admin", "Moderator", "User")
        public string Name { get; set; }

        // Description of the role (optional, useful for documentation)
        public string Description { get; set; }

        // Collection of permissions assigned to this role
        public ICollection<Permission> Permissions { get; set; }

        // Constructor
        public Role(int id, string name, string description = null)
        {
            Id = id;
            Name = name;
            Description = description;
            Permissions = new List<Permission>();
        }

        // Method to add a permission to the role
        public void AddPermission(Permission permission)
        {
            if (!Permissions.Contains(permission))
            {
                Permissions.Add(permission);
            }
        }

        // Method to remove a permission from the role
        public void RemovePermission(Permission permission)
        {
            if (Permissions.Contains(permission))
            {
                Permissions.Remove(permission);
            }
        }

        // Check if the role has a specific permission
        public bool HasPermission(Permission permission)
        {
            return Permissions.Contains(permission);
        }
    }
}
