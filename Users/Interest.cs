using System.Collections.Generic;

namespace CliqMate.Shared.Users
{
    public class Interest
    {
        public int Id { get; set; }

        // The name of the interest (e.g., "Hiking", "Photography")
        public string Name { get; set; }

        // Users who have selected this interest
        public ICollection<User> Users { get; set; }

        // Constructor
        public Interest()
        {
            Users = new List<User>();
        }
    }
}
