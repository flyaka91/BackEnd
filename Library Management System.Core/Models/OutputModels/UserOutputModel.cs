namespace Library_Management_System.Core.Models.OutputModels
{
    public class UserOutputModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
