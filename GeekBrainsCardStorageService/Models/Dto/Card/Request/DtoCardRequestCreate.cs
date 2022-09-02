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
        [StringLength(55)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(5)]
        public string CVV2 { get; set; }

        [Required]
        public DateTime ExpDate { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        public int ClientId { get; set; }
    }
}
