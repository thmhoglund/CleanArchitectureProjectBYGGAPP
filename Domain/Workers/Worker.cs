using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Workers;

public class Worker : AuditableBaseEntity
{
    public string Name { get; set; }
    public decimal HourlyRate { get; set; } // lön per timme
}