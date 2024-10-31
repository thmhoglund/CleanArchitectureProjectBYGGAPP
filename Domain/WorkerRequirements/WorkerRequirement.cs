using Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.WorkerRequirements;

public class WorkerRequirement
{
    public Worker Worker { get; set; }
    public decimal Hours { get; set; } // Antal timmar som krävs för arbetaren
}