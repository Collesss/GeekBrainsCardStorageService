using System.ComponentModel.DataAnnotations;

namespace GeekBrainsCardStorageService.Models.Dto.Client.Request
{
    public class DtoClientRequestCreate
    {
        [Required]
        [StringLength(55)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(55)]
        public string Surname { get; set; }

        [Required]
        [StringLength(55)]
        public string Patronymic { get; set; }
    }
}
