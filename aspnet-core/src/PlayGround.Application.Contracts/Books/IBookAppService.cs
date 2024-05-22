using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PlayGround.Books;

public interface IBookAppService : ICrudAppService<BookDto, Guid, PagedResultRequestDto, CreateBookDto>
{
    
}