using Microsoft.AspNetCore.Mvc;
using Mudblazor.Shared;
using MudBlazor;
using System.Collections.Generic;

namespace Mudblazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriversController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            // Get this from a service, or some config
            return new[]
            {
                new Driver { Position = 1, Id = "HAM", Name = "Lewis Hamilton", Points = 347, Team = "Mercedes" },
                new Driver { Position = 2, Id = "BOT", Name = "Valtteri Bottas", Points = 223, Team = "Mercedes" },
                new Driver { Position = 3, Id = "VER", Name = "Max Verstappen", Points = 214, Team = "Red Bull" },
                new Driver { Position = 4, Id = "PER", Name = "Sergio Perez", Points = 125, Team = "Racing Point" },
                new Driver { Position = 5, Id = "RIC", Name = "Daniel Ricciardo", Points = 119, Team = "Renault" },
                new Driver { Position = 6, Id = "SAI", Name = "Carlos Sainz Jr.", Points = 105, Team = "McLaren" },
                new Driver { Position = 7, Id = "ALB", Name = "Alex Albon", Points = 105, Team = "Red Bull" },
                new Driver { Position = 8, Id = "LEC", Name = "Charles Leclerc", Points = 98, Team = "Ferrari" },
                new Driver { Position = 9, Id = "NOR", Name = "Lando Norris", Points = 97, Team = "McLaren" },
                new Driver { Position = 10, Id = "GAS", Name = "Pierre Gasly", Points = 75, Team = "AlphaTauri" },
                new Driver { Position = 11, Id = "STR", Name = "Lance Stroll", Points = 75, Team = "Racing Point" },
                new Driver { Position = 12, Id = "OCO", Name = "Estaban Ocon", Points = 62, Team = "Renault" },
                new Driver { Position = 13, Id = "VET", Name = "Sebastian Vattel", Points = 33, Team = "Ferrari" },
                new Driver { Position = 14, Id = "KVY", Name = "Daniil Kvyat", Points = 32, Team = "AlphaTauri" },
                new Driver { Position = 15, Id = "HUL", Name = "Nico Hulkenberg", Points = 10, Team = "Racing Point" },
                new Driver { Position = 16, Id = "RAI", Name = "Kimi Raikkonen", Points = 4, Team = "Alfa Romeo" },
                new Driver { Position = 17, Id = "GIO", Name = "Antonio Giovinazzi", Points = 4, Team = "Alfa Romeo" },
                new Driver { Position = 18, Id = "RUS", Name = "George Russell", Points = 3, Team = "Williams" },
                new Driver { Position = 19, Id = "GRO", Name = "Romain Grosjean", Points = 2, Team = "Haas" },
                new Driver { Position = 20, Id = "MAG", Name = "Kevin Magnussen", Points = 1, Team = "Haas" },
                new Driver { Position = 21, Id = "LAT", Name = "Nicolas Latifi", Points = 0, Team = "Williams" },
                new Driver { Position = 22, Id = "AIT", Name = "Jack Aitken", Points = 0, Team = "Williams" },
                new Driver { Position = 23, Id = "FIT", Name = "Pietro Fittipaldi", Points = 0, Team = "Haas" },
            };
        }
    }
}
