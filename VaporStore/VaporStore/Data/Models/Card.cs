using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Data.Models.Enum;

namespace VaporStore.Data.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        [Required]
        public string Cvc { get; set; }
        public CardType CardType { get; set; }
        public int UserId { get; set; }
    }
}
