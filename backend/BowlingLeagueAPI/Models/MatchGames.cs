﻿using System;
using System.Collections.Generic;

namespace BowlingLeagueAPI.Models;

public partial class MatchGames
{
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int? WinningTeamId { get; set; }

    public virtual TourneyMatch Match { get; set; } = null!;
}
