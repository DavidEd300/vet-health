using System;
using System.Collections.Generic;

namespace VetHealth.Domain.Entities;


public class Post : BaseEntity
{
    public Guid PetId { get; set; }
    public Guid AuthorUserId { get; set; } // dono do post (tutor)
    public string ContentText { get; set; } = string.Empty;
    public string? MediaUrl { get; set; }   // imagem/vídeo
    public string? Hashtags { get; set; }

    public List<Comment> Comments { get; set; } = new();
    public List<PostLike> Likes { get; set; } = new();
}
