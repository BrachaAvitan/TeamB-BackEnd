using App.DA.Entities;

namespace App.API.Models
{
    public class CreateBookRequest
    {
        public string? anthor { get; set; }

        public string? title { get; set; }
        public int publishYear { get; set; }
        public decimal Price { get; set; }

    }
}
