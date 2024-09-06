using System.Collections.Generic;
using CliqMate.Shared.Users;
using CliqMate.Shared.Common;
using CliqMate.Shared.Interfaces;

namespace CliqMate.Shared.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;
        private readonly List<Photo> _photos;
        private readonly List<Interest> _interests;

        public UserService()
        {
            // Mock data initialization or fetch from a database
            _users = new List<User>();
            _photos = new List<Photo>();
            _interests = new List<Interest>();
        }

        // User management methods
        public Result<User> GetUserById(int userId)
        {
            var user = _users.Find(u => u.Id == userId);
            return user != null ? Result<User>.Success(user) : Result<User>.Failure("User not found");
        }

        public Result<User> UpdateUserProfile(User updatedUser)
        {
            var user = _users.Find(u => u.Id == updatedUser.Id);
            if (user == null)
            {
                return Result<User>.Failure("User not found");
            }
            user.Username = updatedUser.Username;
            user.Email = updatedUser.Email;
            user.DateOfBirth = updatedUser.DateOfBirth;
            user.Gender = updatedUser.Gender;
            return Result<User>.Success(user, "Profile updated successfully");
        }

        public Result<User> DeleteUser(int userId)
        {
            var user = _users.Find(u => u.Id == userId);
            if (user == null)
            {
                return Result<User>.Failure("User not found");
            }
            _users.Remove(user);
            return Result<User>.Success(user, "User deleted successfully");
        }

        // Photo management methods
        public Result<Photo> UploadPhoto(int userId, string photoUrl, bool isPrivate)
        {
            var user = _users.Find(u => u.Id == userId);
            if (user == null)
            {
                return Result<Photo>.Failure("User not found");
            }

            var newPhoto = new Photo
            {
                Id = _photos.Count + 1,
                Url = photoUrl,
                UploadedAt = System.DateTime.UtcNow,
                IsPrivate = isPrivate,
                UserId = userId,
                User = user
            };

            _photos.Add(newPhoto);
            return Result<Photo>.Success(newPhoto, "Photo uploaded successfully");
        }

        public Result<Photo> DeletePhoto(int photoId)
        {
            var photo = _photos.Find(p => p.Id == photoId);
            if (photo == null)
            {
                return Result<Photo>.Failure("Photo not found");
            }
            _photos.Remove(photo);
            return Result<Photo>.Success(photo, "Photo deleted successfully");
        }

        public IEnumerable<Photo> GetUserPhotos(int userId)
        {
            return _photos.FindAll(p => p.UserId == userId);
        }

        // Interest management methods
        public Result<Interest> AddInterest(int userId, Interest interest)
        {
            var user = _users.Find(u => u.Id == userId);
            if (user == null)
            {
                return Result<Interest>.Failure("User not found");
            }

            user.Interests.Add(interest);
            return Result<Interest>.Success(interest, "Interest added successfully");
        }

        public Result<Interest> RemoveInterest(int userId, Interest interest)
        {
            var user = _users.Find(u => u.Id == userId);
            if (user == null)
            {
                return Result<Interest>.Failure("User not found");
            }

            if (user.Interests.Contains(interest))
            {
                user.Interests.Remove(interest);
                return Result<Interest>.Success(interest, "Interest removed successfully");
            }

            return Result<Interest>.Failure("Interest not found");
        }

        public IEnumerable<Interest> GetUserInterests(int userId)
        {
            var user = _users.Find(u => u.Id == userId);
            return user?.Interests ?? new List<Interest>();
        }

        // Miscellaneous
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }
    }
}
