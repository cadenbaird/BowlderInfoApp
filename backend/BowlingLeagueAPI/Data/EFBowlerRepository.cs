using BowlingLeagueAPI.Models;

namespace BowlingLeagueAPI.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext context) {
            _context = context;    
        }
        
        public IEnumerable<Bowlers> Bowlers => _context.Bowlers.ToList();
    }
}