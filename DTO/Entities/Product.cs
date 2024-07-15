using System;
using System.Collections.Generic;

namespace DTO.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
}
