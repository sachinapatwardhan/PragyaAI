using Microsoft.Extensions.DependencyInjection;

namespace PragyaAI.Application.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        // MediatR
        // FluentValidation
        // Pipeline Behaviors

        return services;
    }
}
