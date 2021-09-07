using System.ComponentModel.DataAnnotations;
using Template_SQLite_EfCore.Models.Entities;

namespace Template_SQLite_EfCore.Models.InputModels.Utenti
{
    public class UtenteEditInputModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il cognome è obbligatorio"),
        MinLength(1, ErrorMessage = "Il cognome dev'essere di almeno {1} caratteri"),
        MaxLength(50, ErrorMessage = "Il cognome dev'essere di al massimo {1} caratteri"),
        Display(Name = "Cognome")]
        public string Cognome { get; set; }
        
        [Required(ErrorMessage = "Il nome è obbligatorio"),
        MinLength(1, ErrorMessage = "Il nome dev'essere di almeno {1} caratteri"),
        MaxLength(50, ErrorMessage = "Il nome dev'essere di al massimo {1} caratteri"),
        Display(Name = "Nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "L'indirizzo email è obbligatorio"),
        EmailAddress(ErrorMessage = "Devi inserire un indirizzo email"),
        Display(Name = "Indirizzo Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Il numero di telefono è obbligatorio"),
        Phone(ErrorMessage = "Devi inserire un numero di telefono"),
        Display(Name = "Telefono")]
        public string Telefono { get; set; }

        public static UtenteEditInputModel FromEntity(Utente utente)
        {
            return new UtenteEditInputModel {
                Id = utente.Id,
                Cognome = utente.Cognome,
                Nome = utente.Nome,
                Email = utente.Email,
                Telefono = utente.Telefono
            };
        }
    }

}