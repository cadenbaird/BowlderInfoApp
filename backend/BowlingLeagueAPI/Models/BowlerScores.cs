using System;
using System.Collections.Generic;

namespace BowlingLeagueAPI.Models;

public partial class BowlerScores
{
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int BowlerId { get; set; }

    public short? RawScore { get; set; }

    public short? HandiCapScore { get; set; }

    public bool WonGame { get; set; }

    public virtual Bowlers Bowler { get; set; } = null!;
}
