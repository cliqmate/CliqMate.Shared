using CliqMate.Shared.Enums;
using System;
using System.Collections.Generic;

namespace CliqMate.Shared.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public bool IsVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public bool IsSuspended { get; set; } = false;
        public UserStatus Status { get; set; } = UserStatus.Active;

        public ICollection<Photo> Photos { get; set; }
        public ICollection<Interest> Interests { get; set; }

        // Method to update the user profile
        public void UpdateProfile(User updatedUser)
        {
            if (!string.IsNullOrEmpty(updatedUser.Username))
            {
                Username = updatedUser.Username;
            }

            if (!string.IsNullOrEmpty(updatedUser.Email))
            {
                Email = updatedUser.Email;
            }

            // Only update the DateOfBirth if it's a valid date
            if (updatedUser.DateOfBirth != DateTime.MinValue)
            {
                DateOfBirth = updatedUser.DateOfBirth;
            }

            if (!string.IsNullOrEmpty(updatedUser.Gender))
            {
                Gender = updatedUser.Gender;
            }

            // Update verification status if provided
            IsVerified = updatedUser.IsVerified;

            // Update suspension status if provided
            IsSuspended = updatedUser.IsSuspended;

            // Update user status if provided
            if (updatedUser.Status != Status)
            {
                Status = updatedUser.Status;
            }

            // Update Photos if provided
            if (updatedUser.Photos != null && updatedUser.Photos.Count > 0)
            {
                Photos = updatedUser.Photos;
            }

            // Update Interests if provided
            if (updatedUser.Interests != null && updatedUser.Interests.Count > 0)
            {
                Interests = updatedUser.Interests;
            }
        }
    }
}
