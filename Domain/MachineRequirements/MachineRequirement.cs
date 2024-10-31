using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MachineRequirements;

public class MachineRequirement
{
    public Domain.Machines.Machine Machine { get; set; }
    public decimal Hours { get; set; } // Antal timmar som krävs för maskinen
}