using System;
using PlayGround.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PlayGround.Books;

public class BookAppService (IRepository<Book, Guid> repository)
    : CrudAppService<Book, BookDto, Guid, PagedResultRequestDto, CreateBookDto>(repository), IBookAppService
{
}