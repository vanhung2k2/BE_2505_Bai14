using System;
using System.Collections.Generic;

namespace DTO.Entities;

public partial class GroupAttribute
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();
}
