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




// Sample permissions could be stored as static properties or constants
public static Permission CanVerifyUser => new Permission(1, "CanVerifyUser", "Permission to verify users");
public static Permission CanDeleteUser => new Permission(2, "CanDeleteUser", "Permission to delete users");
public static Permission CanSuspendUser => new Permission(3, "CanSuspendUser", "Permission to suspend users");
public static Permission CanResolveReport => new Permission(4, "CanResolveReport", "Permission to resolve reports");
public static Permission CanManageRoles => new Permission(5, "CanManageRoles", "Permission to manage roles");

// A method to check equality
public override bool Equals(object? obj)
{
    if (obj is AdminPermission otherPermission)
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