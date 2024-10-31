using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Materials;

public class MaterialDto
{
    public MaterialDto()
    {
        
    }
    public MaterialDto(Material material)
    {
        Id = (int)material.Id;
        FormalName = material.FormalName;
        AlternativeName = material.FormalName;
        PricePerUnit = material.PricePerUnit;
        Unit  = material.Unit;
        Code = material.Code;
    }

    public int Id { get; set; }
    public string FormalName { get; set; }
    public string AlternativeName { get; set; }
    public decimal PricePerUnit { get; set; } // pris per enhet (t.ex., per kg, m², etc.)
    public string Unit { get; set; } // t.ex., "kg", "m2", etc.
    public string Code { get; set; } // Kanske en intern kod för material
    public DateTime CreatedDateTime { get; set; }
}
