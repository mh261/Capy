using System.ComponentModel.DataAnnotations;

namespace Capy.Models.Dtos
{
    public class GenreDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string GenreName { get; set; }
    }
}
