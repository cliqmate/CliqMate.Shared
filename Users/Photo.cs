using System;
using CliqMate.Shared.Users;

namespace CliqMate.Shared.Users
{
    public class Photo
    {
        public int Id { get; set; }

        // URL to the photo's location
        public string? Url { get; set; }

        // Date and time when the photo was uploaded
        public DateTime UploadedAt { get; set; }

        // Boolean flag to indicate if the photo is private
        public bool IsPrivate { get; set; }

        // Foreign key to the user who uploaded the photo
        public int UserId { get; set; }
        public required User User { get; set; }
    }
}
