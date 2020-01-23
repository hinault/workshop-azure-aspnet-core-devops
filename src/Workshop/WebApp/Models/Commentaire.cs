using System;


namespace WebApp.Models
{
    public class Commentaire
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Email { get; set; }

        public string Texte { get; set; }

        public DateTime DateCommentaire { get; set; }
    }
}
