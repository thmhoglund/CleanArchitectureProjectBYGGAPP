using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Machines;

public class MachineDto
{
#pragma warning disable
    public MachineDto()
    {

    }
#pragma warning disable
    public MachineDto(Machine machine)
    {
        Id = machine.Id;
        Name = machine.Name;
        Description = machine.Description;
                
    }


    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal RentalCostPerHour {  get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

}
