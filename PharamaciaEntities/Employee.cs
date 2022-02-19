using Users;

namespace PharamaciaEntities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartedDate { get; set; }
        public bool IsActivated { get; set; }
        public JobRanks JobRank { get; set; }
        public int Seniority { get; set; }
        public int PaymentPerHour { get; set; }
        public User User { get; set; }
    }

    public enum JobRanks
    {
        Director,
        ShiftManager,
        General
    }
}
