namespace pasc24.domain.Entities;

public class Contact : DefaultEntity
{
    public string ? PhoneNumber { get; set; }
    public string ? EmailAddress { get; set; }
    public string ? WebSite { get; set; }
    public string ? WatsappNumber { get; set; }
    public string ? Facebook { get; set; }
    public string ? Linkedin { get; set; }

    public virtual Company ? Company {get; set;}
    public virtual PointOfSale ? PointOfSale {get; set;}
    public virtual Person ? Person {get; set;}
}