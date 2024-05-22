using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace PlayGround.Entities;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
        
    public Guid AuthorId { get; set; }
}