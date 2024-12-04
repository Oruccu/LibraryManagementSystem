using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AuthorBiography
    {   
        public int AuthorId { get; set; }
        public string Biography { get; set; } = "";

    }
}
