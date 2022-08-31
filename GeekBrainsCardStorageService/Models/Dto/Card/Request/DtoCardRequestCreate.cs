using System;

namespace GeekBrainsCardStorageService.Models.Dto.Card.Request
{
    public class DtoCardRequestCreate
    {
        public string Name { get; set; }

        public string CardNumber { get; set; }

        public string CVV2 { get; set; }

        public DateTime ExpDate { get; set; }

        public int ClientId { get; set; }
    }
}
