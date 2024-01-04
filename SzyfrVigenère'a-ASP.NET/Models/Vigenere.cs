using System.ComponentModel.DataAnnotations;

namespace SzyfrVigenère_a_ASP.NET.Models
{
    public class Vigenere
    {
        [Required]
        public string? Tekst { get; set; }
        public string? Klucz { get; set; }
        public string? ZaszyfrowanyTekst { get; set; }

    }
}
