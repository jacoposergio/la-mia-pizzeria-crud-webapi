using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Devi inserire una Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Devi inserire un nome")]
        public string GuestName { get; set; }

        [Required(ErrorMessage = "Devi inserire un titolo")]
        public string MessageTitle { get; set; }

        [Required(ErrorMessage = "Devi inserire un messaggio")]
        [Column(TypeName = "text")]
        public string MessageText { get; set; }

    }
}
