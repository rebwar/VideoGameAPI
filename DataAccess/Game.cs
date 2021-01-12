using System.ComponentModel.DataAnnotations;

namespace VideoGameAPI.DataAccess
{
    public class Game
    {
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int PersonalRating { get; set; }

    }
}
