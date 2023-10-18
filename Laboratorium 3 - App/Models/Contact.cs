using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za długie imię! Maksymalnie 50 znaków.")]
        public string Name { get; set; }

        [EmailAddress (ErrorMessage = "Musisz podać poprawny email (brak znaku @)!")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Numer telefonu powinien zawierać cyfry!")]
        public string Phone { get; set; }

        public DateTime? Birth { get; set; }


    }
}
