﻿using System;
using System.Collections.Generic;

namespace CrudApi.Models;

public partial class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string? Category { get; set; }
}
