using System;
using System.Collections.Generic;

namespace DTO.Entities;

public partial class Attribute
{
    public int Id { get; set; }

    public string? AttrName { get; set; }

    public string? AttrValue { get; set; }

    public int? Groupid { get; set; }

    public decimal? Price { get; set; }

    public virtual GroupAttribute? Group { get; set; }

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
}
