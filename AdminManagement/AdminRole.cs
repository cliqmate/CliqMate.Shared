using System;
using System.Collections.Generic;

namespace CliqMate.Shared.AdminManagement
{
    public class AdminRole
    {
        public Guid Id { get; set; }

        // Name of the role (e.g., "Admin", "Moderator", "User")
        public string Name { get; set; }

        // Description of the role (optional, useful for documentation)
        public string? Description { get; set; }

        // Collection of permissions assigned to this role
        public ICollection<AdminPermission> Permissions { get; set; }

        // Constructor
        public AdminRole(string name, string? description = null, Guid? guid = null)
        {
            Id = guid ?? Guid.NewGuid(); // Assign a new Guid if none is provided
            Name = name;
            Description = description;
            Permissions = new List<AdminPermission>();
        }
    }
}
