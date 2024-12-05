using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AuthorUpdateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Yazarın Adı")]
        [Required(ErrorMessage = "'Ad' alanı zorunludur.")]
        public string Name { get; set; }

        [Display(Name = "Yazarın Soyadı")]
        [Required(ErrorMessage = "'{0}' alanı zorunludur.")]
        public string LastName { get; set; }

        [Display(Name = "Yazarın Doğum Tarihi")]
        [Required(ErrorMessage = "Yazarın Doğum Tarihi alanı zorunludur.")]
        public DateTime? DateOfBirth { get; set; }

    }
}