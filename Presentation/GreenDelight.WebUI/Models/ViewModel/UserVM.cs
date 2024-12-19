namespace GreenDelight.WebUI.Models.ViewModel
{
    public class UserVM
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
