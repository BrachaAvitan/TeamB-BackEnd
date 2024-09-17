using System;
using System.Collections.Generic;

namespace App.DA.Entities;

public partial class Book
{

    public Guid bookId { get; set; }

    public string? anthor { get; set; }

    public string? title { get; set; }
    public int publishYear { get; set; }
    public decimal Price { get; set; }


}
