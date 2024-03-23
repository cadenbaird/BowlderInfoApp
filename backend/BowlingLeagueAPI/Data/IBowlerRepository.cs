using BowlingLeagueAPI.Models;

namespace BowlingLeagueAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
    }
}
