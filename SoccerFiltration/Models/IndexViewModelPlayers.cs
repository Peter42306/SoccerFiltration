using Microsoft.AspNetCore.Mvc.Rendering;

namespace SoccerFiltration.Models
{
    public class IndexViewModelPlayers
    {
        public IEnumerable<Players> Players { get; set; } = new List<Players>();
        public SelectList Teams { get; set; } = new SelectList(new List<Teams>(), "Id", "Name");
        public string? Position { get; set; }
    }
}
