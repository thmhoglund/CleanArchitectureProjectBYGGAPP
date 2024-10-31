using Domain.Common;
using Domain.MachineRequirements;
using Domain.MaterialRequirements;
using Domain.WorkerRequirements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Recipes;

public class Recipe : AuditableBaseEntity
{
    public string Name { get; set; } // Namn på jobbet, t.ex., "Asfaltera garageuppfart"

    // Lista med material och mängder som behövs
    public List<MaterialRequirement> Materials { get; set; } = new List<MaterialRequirement>();

    // Lista med maskiner och användningstid som krävs
    public List<MachineRequirement> Machines { get; set; } = new List<MachineRequirement>();

    // Lista med arbetare och arbetstid som behövs
    public List<WorkerRequirement> Workers { get; set; } = new List<WorkerRequirement>();

    public decimal GetTotalCost(decimal materialMarkupPercentage, decimal machineMarkupPercentage, decimal workerMarkupPercentage)
    {
        decimal totalCost = 0;

        // Räkna ut kostnaden för material
        foreach (var material in Materials)
        {
            totalCost += material.Quantity * material.Material.PricePerUnit * (1 + materialMarkupPercentage / 100);
        }

        // Räkna ut kostnaden för maskiner
        foreach (var machine in Machines)
        {
            totalCost += machine.Hours * machine.Machine.RentalCostPerHour * (1 + machineMarkupPercentage / 100);
        }

        // Räkna ut kostnaden för arbetare
        foreach (var worker in Workers)
        {
            totalCost += worker.Hours * worker.Worker.HourlyRate * (1 + workerMarkupPercentage / 100);
        }

        return totalCost;
    }
}