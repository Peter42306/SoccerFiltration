using Microsoft.AspNetCore.Mvc.Rendering;

namespace SoccerFiltration.Models
{
    public class IndexViewModelTeams
    {
        public IEnumerable<Teams> Teams { get; set; } = new List<Teams>();
        public string? Name {  get; set; }
        public string? Coach { get; set; }
    }
}
