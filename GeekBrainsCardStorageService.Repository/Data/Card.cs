namespace GeekBrainsCardStorageService.Repository.Data
{
    public class Card
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string CardNumber { get; set; }

        public string CVV2 { get; set; }

        public DateTime ExpDate { get; set; }

        public int ClientId { get; set; }
    }
}
