// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.CmsKit.Public.Ratings;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Public.Ratings;

public interface IRatingPublicAppService : IApplicationService
{
    Task<RatingDto> CreateAsync(string entityType, string entityId, CreateUpdateRatingInput input);

    Task DeleteAsync(string entityType, string entityId);

    Task<List<RatingWithStarCountDto>> GetGroupedStarCountsAsync(string entityType, string entityId);
}