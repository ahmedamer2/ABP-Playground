using System;
using Asp.Versioning;
using Asp.Versioning.ApplicationModels;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.ApiVersioning;
using Volo.Abp.AspNetCore.Mvc.Conventions;
using Volo.Abp.AspNetCore.Mvc.Versioning;

namespace PlayGround;

public static class Extensions
{
    public static IApiVersioningBuilder AddAbpApiVersioning(
        this IServiceCollection services,
        Action<ApiVersioningOptions>? apiVersioningOptionsSetupAction = null,
        Action<MvcApiVersioningOptions>? mvcApiVersioningOptionsSetupAction = null)
    {
        services.AddTransient<IRequestedApiVersion, HttpContextRequestedApiVersion>();
        services.AddTransient<IApiControllerSpecification, AbpConventionalApiControllerSpecification>();
    
        apiVersioningOptionsSetupAction ??= _ => { };
        mvcApiVersioningOptionsSetupAction ??= _ => { };
        return services.AddApiVersioning(apiVersioningOptionsSetupAction).AddMvc(mvcApiVersioningOptionsSetupAction);
    }
}