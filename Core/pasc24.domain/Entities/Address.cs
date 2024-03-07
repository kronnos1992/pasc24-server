namespace pasc24.domain.Entities;

public class Address : DefaultEntity
{
    public string ? StreetName { get; set; }
    public string ? NeighborName { get; set; }
    public string ? MunicipalityName { get; set; }
    public string ? HouseNumber { get; set; }

    public virtual Person ? Person { get; set; }
    public virtual Company ? Company { get; set; }
    public virtual PointOfSale ? PointOfSale { get; set; }
    public virtual Province ? Province { get; set; }
}

