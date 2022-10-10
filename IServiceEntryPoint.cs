using Microsoft.AspNetCore.Builder;

namespace Chassis.Abstractions;

public interface IServiceEntryPoint
{
    void ConfigureWebApplicationBuilder(WebApplicationBuilder builder, IServiceSettings settings);

    void ConfigureWebApplication(WebApplication app);
}