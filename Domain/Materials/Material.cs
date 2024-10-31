
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Materials;

public class Material : AuditableBaseEntity
{
    public Material()
    {
        
    }
    public Material(string formalName,string alternativeName,decimal pricePerUnit,string unit,string code)
    {
        FormalName = formalName;
        AlternativeName = alternativeName;
        PricePerUnit = pricePerUnit;
        Unit = unit;
        Code = code;

    }
    public string FormalName { get; set; }
    public string AlternativeName { get; set; }
    public decimal PricePerUnit { get; set; } // pris per enhet (t.ex., per kg, m², etc.)
    public string Unit { get; set; } // t.ex., "kg", "m2", etc.
    public string Code { get; set; } // Kanske en intern kod för material
    public void Update (string formalName, string alternativeName, decimal pricePerUnit, string unit, string code)
    {
        FormalName = formalName;
        AlternativeName = alternativeName;
        PricePerUnit = pricePerUnit;
        Unit = unit;
        Code = code;

    }
}