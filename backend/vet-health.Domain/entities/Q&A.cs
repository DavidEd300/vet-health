using System;
using System.Collections.Generic;

namespace VetHealth.Domain.Entities;

public enum VerificationStatus
{
    Pending = 0,
    Approved = 1,
    Rejected = 2
}

public class VeterinarianProfile : BaseEntity
{
    public Guid UserId { get; set; } // ApplicationUser.Id
    public string CRMV { get; set; } = default!;
    public string? LicenseState { get; set; } // UF
    public VerificationStatus Status { get; set; } = VerificationStatus.Pending;
    public DateTime? VerifiedAt { get; set; }
}

public class Question : BaseEntity
{
    public Guid AskedByUserId { get; set; }
    public string Title { get; set; } = default!;
    public string Body { get; set; } = default!;
    public string? Category { get; set; } // saúde, comportamento, alimentação...
    public List<Answer> Answers { get; set; } = new();
}

public class Answer : BaseEntity
{
    public Guid QuestionId { get; set; }
    public Guid AnsweredByUserId { get; set; } // deve ser vet verificado
    public string Body { get; set; } = default!;
    public int Upvotes { get; set; }
}
