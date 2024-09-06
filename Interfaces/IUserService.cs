using CliqMate.Shared.Users;
using CliqMate.Shared.Common;
using System.Collections.Generic;

namespace CliqMate.Shared.Interfaces
{
    public interface IUserService
    {
        // User management
        Result<User> GetUserById(int userId);
        Result<User> UpdateUserProfile(User updatedUser);
        Result<User> DeleteUser(int userId);

        // Photo management
        Result<Photo> UploadPhoto(int userId, string photoUrl, bool isPrivate);
        Result<Photo> DeletePhoto(int photoId);
        IEnumerable<Photo> GetUserPhotos(int userId);

        // Interest management
        Result<Interest> AddInterest(int userId, Interest interest);
        Result<Interest> RemoveInterest(int userId, Interest interest);
        IEnumerable<Interest> GetUserInterests(int userId);

        // Miscellaneous
        IEnumerable<User> GetAllUsers();
    }
}
