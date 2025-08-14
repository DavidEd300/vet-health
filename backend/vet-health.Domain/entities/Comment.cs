using System;

namespace VetHealth.Domain.Entities;

public class Comment : BaseEntity
{
    public Guid PostId { get; set; }
    public Guid AuthorUserId { get; set; }
    public string Text { get; set; } = default!;
}
