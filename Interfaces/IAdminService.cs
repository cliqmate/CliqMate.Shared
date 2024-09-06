using CliqMate.Shared.Users;
using CliqMate.Shared.Common;
using System.Collections.Generic;
using CliqMate.Shared.AdminManagement;

namespace CliqMate.Shared.Interfaces
{
    public interface IAdminService
    {
        // User management
        Result<User> VerifyUser(int userId);
        Result<User> SuspendUser(int userId);
        Result<User> DeleteUser(int userId);

        // Role management
        Result<Role> AssignRole(int userId, int roleId);
        Result<Role> RemoveRole(int userId, int roleId);
        IEnumerable<Role> GetAllRoles();

        // Report management
        Result<Report> ResolveReport(int reportId, int adminId);
        Result<Report> RejectReport(int reportId, int adminId);
        IEnumerable<Report> GetAllReports();

        // Admin-specific methods
        IEnumerable<Admin> GetAllAdmins();
        Result<Admin> CreateAdmin(Admin admin);
        Result<Admin> DeleteAdmin(int adminId);
    }
}
