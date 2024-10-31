using Domain.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MaterialRequirements;

public class MaterialRequirement
{
    public Material Material { get; set; }
    public decimal Quantity { get; set; } // Mängden som krävs för jobbet
}