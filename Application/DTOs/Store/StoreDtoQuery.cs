using System;

namespace Application.DTOs.Store
{
    public class StoreDtoQuery
    {

        public Guid Id { get; set; }
        public string? Date_In { get; set; }
        public string? Product { get; set; }
        public string? Price_Sale { get; set; }
        public string? Price_Purchase { get; set; }
        public string? Cant { get; set; }
        public string? Num_Bill { get; set; }
        public string? Description { get; set; }
        public string? Image_Dir { get; set; }
        public string? Estado { get; set; }
        public string? Date_End { get; set; }
    }

}

