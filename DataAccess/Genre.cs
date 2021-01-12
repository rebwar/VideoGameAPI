using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameAPI.DataAccess
{
    public class Genre
    {
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
}
