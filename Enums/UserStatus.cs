namespace CliqMate.Shared.Enums
{
    public enum UserStatus
    {
        // The user is active and can use the system
        Active = 1,

        // The user is suspended, possibly due to violations, and can't use the system
        Suspended = 2,

        // The user has deleted their account but may still exist in the system for record purposes
        Deleted = 3,

        // The user is pending approval (for example, awaiting verification)
        PendingVerification = 4,

        // The user is banned permanently from the platform
        Banned = 5
    }
}
