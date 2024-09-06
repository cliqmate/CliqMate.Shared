namespace CliqMate.Shared.AdminManagement
{
    public class Permission
    {
        public int Id { get; set; }

        // Name of the permission (e.g., "CanVerifyUser", "CanDeleteUser", etc.)
        public string Name { get; set; }

        // Description of what this permission allows (optional but useful for documentation)
        public string? Description { get; set; }

        // Constructor
        public Permission(int id, string name, string? description = null)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        // Sample permissions could be stored as static properties or constants
        public static Permission CanVerifyUser => new Permission(1, "CanVerifyUser", "Permission to verify users");
        public static Permission CanDeleteUser => new Permission(2, "CanDeleteUser", "Permission to delete users");
        public static Permission CanSuspendUser => new Permission(3, "CanSuspendUser", "Permission to suspend users");
        public static Permission CanResolveReport => new Permission(4, "CanResolveReport", "Permission to resolve reports");
        public static Permission CanManageRoles => new Permission(5, "CanManageRoles", "Permission to manage roles");

        // A method to check equality
        public override bool Equals(object? obj)
        {
            if (obj is Permission otherPermission)
            {
                return this.Id == otherPermission.Id && this.Name == otherPermission.Name;
            }
            return false;
        }


        // A method to override the GetHashCode for the object
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode();
        }
    }
}
