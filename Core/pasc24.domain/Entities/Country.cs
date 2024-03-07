namespace pasc24.domain.Entities;

public class Country : DefaultEntity
{
    public Country()
    {
        Provinces = [];
    }
    public string ? CountryName { get; set; }
    public string ? Continent { get; set; }

    public ICollection <Province> Provinces {get; set;}
}