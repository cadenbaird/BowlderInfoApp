using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BowlingLeagueAPI.Models;

// Represents a bowler in the bowling league.
public partial class Bowlers
{
    [Key]
    // Unique identifier for the bowler.
    public int BowlerId { get; set; }

    // Last name of the bowler.
    public string? BowlerLastName { get; set; }

    // First name of the bowler.
    public string? BowlerFirstName { get; set; }

    // Middle initial of the bowler.
    public string? BowlerMiddleInit { get; set; }

    // Address of the bowler.
    public string? BowlerAddress { get; set; }

    // City where the bowler resides.
    public string? BowlerCity { get; set; }

    // State where the bowler resides.
    public string? BowlerState { get; set; }

    // Zip code of the bowler's residence.
    public string? BowlerZip { get; set; }

    // Phone number of the bowler.
    public string? BowlerPhoneNumber { get; set; }

    // ID of the team the bowler is part of.
    public int? TeamId { get; set; }

    // Collection of scores associated with the bowler.
    public virtual ICollection<BowlerScores> BowlerScores { get; set; } = new List<BowlerScores>();

    // The team the bowler is part of.
    public virtual Team? Team { get; set; }
}
