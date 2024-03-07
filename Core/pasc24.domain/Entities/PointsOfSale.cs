namespace pasc24.domain.Entities;

public class PointOfSale : DefaultEntity
    {
        // Propriedades
        public required string Name { get; set; }
        public int? AddressId { get; set; }
        public int? CompanyId { get; set; }
        public int? ContactId {get; set;}

        // Mapeamento
        public virtual Contact ? Contact { get; set; }
        public virtual required Address Address { get; set; }
        public virtual Company ? Company { get; set; }
    }