using System;

namespace VetHealth.Domain.Entities;

public class PostLike : BaseEntity
{
    public Guid PostId { get; set; }
    public Guid UserId { get; set; }
}
