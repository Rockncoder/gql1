using System;
using gql1.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace gql1
{
    public static class StartupHelper
    {
        public static void LoadVehicleData(IServiceProvider service)
        {
            using var serviceScope = service.CreateScope();
            var services = serviceScope.ServiceProvider;
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Loading vehicle data.");
            try
            {
                AppState.Load();
                logger.LogInformation($"Loaded {AppState.VehicleCount} vehicles");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while loading vehicle data.");
            }
        }
    }
}
