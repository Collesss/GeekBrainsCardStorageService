using System;
using System.ComponentModel.DataAnnotations;

namespace GeekBrainsCardStorageService.Models.Dto.Card.Request
{
    public class DtoCardRequestCreate
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"\d{16}")]
        public string CardNumber { get; set; }

        [Required]
        [RegularExpression(@"\d{3}")]
        public string CVV2 { get; set; }

        [Required]
        public DateTime ExpDate { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        public int ClientId { get; set; }
    }
}
