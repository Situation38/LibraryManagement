using SimpleAPI.DAL.DAO.Daos;
using SimpleAPI.DAL.DAO.IDaos;

namespace SimpleAPI.ConfigurationsDI
{
    public static class CoreDaoDI
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {

            
            services.AddTransient<IBookDao, BookDao>();
            services.AddTransient<ILibraryDao, LibraryDao>();


           

            return services;
        }
    }
}
