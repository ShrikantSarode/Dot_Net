using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDApi.Models;

public partial class Product
{
    
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }
}
