namespace Domain.Models.Sales
{
    public class Sales : Entity.Entity
    {
        
        public string? Date_Inc { get; set; }
        public string? Price_Sale { get; set; }
        public string? Cant { get; set; }
        public string? Estado { get; set; }
        public string? Date_Sale { get; set; }
        public string? Date_Deliver { get; set; }
        public Guid? ProductoId { get; set; }
    }
}


