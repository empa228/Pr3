using System;
using System.Collections.Generic;

namespace Pr3;

public partial class ProductType
{
    public int Id { get; set; }

    public string TypeOfProduct { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
