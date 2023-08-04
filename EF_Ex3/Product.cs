using System;
using System.Collections.Generic;

namespace EF_Ex3;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Cost { get; set; }

    public string Description { get; set; } = null!;

    public int Quantity { get; set; }
}
