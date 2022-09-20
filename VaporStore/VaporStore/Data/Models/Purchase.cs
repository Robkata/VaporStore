using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Data.Models.Enum;

namespace VaporStore.Data.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public PurchaseType PurchaseType { get; set; }
        public string ProductKey { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int CardId { get; set; }
        public int GameId { get; set; }
    }
}
