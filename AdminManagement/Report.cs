using CliqMate.Shared.Enums;
using CliqMate.Shared.Users;
using System;

namespace CliqMate.Shared.AdminManagement
{
    public class Report
    {
        public int Id { get; set; }

        // Reason for the report (e.g., inappropriate behavior, offensive content, etc.)
        public string Reason { get; set; }

        // Optional additional details about the report
        public string Details { get; set; }

        // Date and time the report was submitted
        public DateTime SubmittedAt { get; set; }

        // Enum to track the status of the report (Pending, Resolved, etc.)
        public ReportStatus Status { get; set; }

        // The user who submitted the report
        public int SubmittedById { get; set; }
        public User SubmittedBy { get; set; }

        // The user who is being reported
        public int ReportedUserId { get; set; }
        public User ReportedUser { get; set; }

        // The admin who handled the report (null if not yet resolved)
        public int? HandledById { get; set; }
        public Admin HandledBy { get; set; }

        // Date and time the report was resolved (if applicable)
        public DateTime? ResolvedAt { get; set; }

        // Constructor
        public Report(string reason, string details, int submittedById, int reportedUserId)
        {
            Reason = reason;
            Details = details;
            SubmittedAt = DateTime.UtcNow;
            Status = ReportStatus.Pending;
            SubmittedById = submittedById;
            ReportedUserId = reportedUserId;
        }

        // Method to resolve the report
        public void Resolve(Admin admin)
        {
            Status = ReportStatus.Resolved;
            HandledById = admin.Id;
            HandledBy = admin;
            ResolvedAt = DateTime.UtcNow;
        }

        // Method to reject the report
        public void Reject(Admin admin)
        {
            Status = ReportStatus.Rejected;
            HandledById = admin.Id;
            HandledBy = admin;
            ResolvedAt = DateTime.UtcNow;
        }
    }
}
