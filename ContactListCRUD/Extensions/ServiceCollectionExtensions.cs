using ContactListCRUD.Data;
using ContactListCRUD.Repositories;
using ContactListCRUD.Services;

namespace ContactListCRUD.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddDbContext<ContactDbContext>();
             services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<ContactService>();

            return services;
        }
    }
}
