using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Machines;

public class Machine: AuditableBaseEntity
{
#pragma warning disable
    public Machine() { }
#pragma warning disable
    public Machine(string name,decimal rentalCostPerHour,string description)
    {
        Name = name;
        RentalCostPerHour = rentalCostPerHour;
        Description = description;
        
}

    public string Name { get; set; }
    public decimal RentalCostPerHour { get; set; } // pris per timme
    public string Description { get; set; }

    public void Update(string name,decimal rentalCostPerHour,string decsription)
    {
        Name = name;
        RentalCostPerHour = rentalCostPerHour;
        Description = decsription;
    }

}