using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Author
    {   
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}