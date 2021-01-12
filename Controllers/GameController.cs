using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameAPI.DataAccess;

namespace VideoGameAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController:ControllerBase
    {
        private readonly VideoGameDataContext context;

        public GameController(VideoGameDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Game> GetAllGames() => context.Games.OrderByDescending(c=>c.ID);

        [HttpPost]
        public async Task<Game> AddGame([FromBody] Game game)
        {
            context.Games.Add(game);
           await context.SaveChangesAsync();
            return game;
        }
    }
}
