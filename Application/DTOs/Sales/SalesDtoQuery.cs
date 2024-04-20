using System;

namespace Application.DTOs.Sales
{
    public class SalesDtoQuery
    {
        public Guid Id { get; set; }
        public Guid? ProductoId { get; set; }
        public string? Date_Inc { get; set; }
        public string? Price_Sale { get; set; }
        public string? Cant { get; set; }
        public string? Estado { get; set; }
        public string? Date_Sale { get; set; }
        public string? Date_Deliver { get; set; }
    }




}

