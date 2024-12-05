using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class NewBook
    {
        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "Ad Alanı Zorunludur")]
        public string Title { get; set; }

        [Display(Name = "Yazar Adı")]
        [Required(ErrorMessage = "{0} Zorunludur")]        
        public int AuthorId { get; set; }

        [Display(Name = "Kitap Türü")]
        [Required(ErrorMessage = "{0} Zorunludur")] 
        public string Genre { get; set; }

        [Display(Name = "Yayın Yılı")]
        [Required(ErrorMessage = "{0} Zorunludur")] 
        [DataType(DataType.Date)]
        public DateTime? PublishDate { get; set; }

        [Display(Name = "ISBN Numarası")]
        [Required(ErrorMessage = "{0} Zorunludur")] 
        [RegularExpression(@"^\d{13}$", ErrorMessage = "ISBN 13 karakter olmalı.")]
        public string ISBN { get; set; }

        [Display(Name = "Kitap Kopya Sayısı")]
        [Required(ErrorMessage = "{0} Zorunludur")] 
        [Range(1, int.MaxValue, ErrorMessage = "Kopya sayısı pozitif bir sayı olmalı.")]
        public int? CopiesAvailable { get; set; }
    }
}
