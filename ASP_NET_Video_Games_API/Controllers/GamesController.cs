using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetGames()
        {
            var allGames = _context.VideoGames;

            return Ok(allGames);
        }

        //[HttpGet("{pubName}")]
        //public IActionResult GetGamesByPublisher(string pubName)

        //{
        //    int? MaxYear = _context.VideoGames.Select(vg => vg.Year).Max();
        //    int? MinYear = _context.VideoGames.Select(vg => vg.Year).Min();

        //    var videoGames = _context.VideoGames.Where(vg => vg.Publisher == pubName);

        //    return Ok(videoGames);
        //}
        [HttpGet("{Id}")]
        public IActionResult GetGamesById(int Id)
        {
            var videoGames = _context.VideoGames.Where(vg => vg.Id == Id);

            return Ok(videoGames);
        }
    }
}
            
    

