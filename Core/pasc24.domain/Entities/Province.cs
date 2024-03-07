namespace pasc24.domain.Entities;

public class Province : DefaultEntity
{
    public required string ProvinceName { get; set; }
    public int CountryId { get; set; }
    public virtual required Country Country {get; set;}
}