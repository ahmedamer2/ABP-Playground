using System;
using Volo.Abp.Application.Dtos;

namespace PlayGround.Books;

public class CreateBookDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public float Price { get; set; }

    public Guid AuthorId { get; set; }
}