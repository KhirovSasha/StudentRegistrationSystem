
namespace DataAccess.Entities
{
    public class User 
    {
        public User() 
        {
            RegistrationDate = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public string Nikname { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
