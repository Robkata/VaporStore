using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VaporStore.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.GameTags = new HashSet<GameTag>();
        }
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]

        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }
        public int DeveloperId { get; set; }
        [Required]

        public int GenreId { get; set; }
        [Required]
        public ICollection<GameTag> GameTags { get; set; }
    }
}
