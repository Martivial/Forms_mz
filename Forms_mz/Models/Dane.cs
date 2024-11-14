using System.ComponentModel.DataAnnotations;

namespace Forms_mz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać Imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać Email")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać Hasło")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, dużą i małą literę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Podaj poprawny numer telefonu")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Proszę podać wiek")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać miasto")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            Warszawa = 1,
            Kraków,
            Wrocław,
            Gdańsk,
            Poznań
        }
    }
}
