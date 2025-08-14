using System;
using System.Collections.Generic;

namespace VetHealth.Domain.Entities;

public class Pet : BaseEntity
{
    public Guid OwnerUserId { get; set; } // ApplicationUser.Id
    public string Name { get; set; } = default!;
    public string? Species { get; set; }  // ex: cão, gato
    public string? Breed { get; set; }
    public DateTime? BirthDate { get; set; }

    // navegação
    public List<Post> Posts { get; set; } = new();
}
