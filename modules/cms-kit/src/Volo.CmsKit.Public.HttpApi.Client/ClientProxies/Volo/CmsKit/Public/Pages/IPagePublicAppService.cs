// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.CmsKit.Contents;
using Volo.CmsKit.Public.Pages;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Public.Pages;

public interface IPagePublicAppService : IApplicationService
{
    Task<PageDto> FindBySlugAsync(string slug);

    Task<bool> DoesSlugExistAsync(string slug);

    Task<PageDto> FindDefaultHomePageAsync();
}