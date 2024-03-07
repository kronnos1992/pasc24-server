using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pasc24.domain.Entities;

public class AutoBrand : DefaultEntity
{
    public AutoBrand()
    {
        AutoModels = [];
    }
    public required string BrandName { get; set; }
    public ICollection<AutoModel> AutoModels { get; set; }
}