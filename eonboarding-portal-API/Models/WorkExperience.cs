﻿using System;
using System.Collections.Generic;

namespace eonboarding_portal_API.Models;

public partial class WorkExperience
{
    public int Id { get; set; }

    public int? NoOfYears { get; set; }

    public string? CurrentCompany { get; set; }

    public string? Technology { get; set; }

    public string? Skills { get; set; }

    public int? CandidateId { get; set; }

    public string? PastCompany { get; set; }

    public string? CurrentLocation { get; set; }

    public string? CurrentDesignation { get; set; }

    public string? CurrentCtc { get; set; }

    public string? ExpectedCtc { get; set; }

    public virtual Candidate? Candidate { get; set; }
}
