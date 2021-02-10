using Microsoft.Extensions.DependencyInjection;

namespace s1d0r.HitBtcComAPI.Services.Extensions
{
    public static class HitBtcComServicesExtensins
    {
        public static IServiceCollection AddHitBtcCom(this IServiceCollection services)
        {
            return services.AddSingleton<HitBtcComService>();
        }
    }
}