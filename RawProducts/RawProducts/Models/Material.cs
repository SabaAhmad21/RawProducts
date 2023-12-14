using System;
using System.Collections.Generic;

namespace RawProducts.Models;

public partial class Material
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string Quantity { get; set; } = null!;

    public DateTime Date { get; set; }
}
