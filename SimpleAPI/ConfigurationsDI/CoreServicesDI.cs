using SimpleAPI.BusinessLogic;
using SimpleAPI.BusinessLogic.IServices;
using SimpleAPI.BusinessLogic.Services;
using System.Text.Json.Serialization;

namespace SimpleAPI.ConfigurationsDI
{
    public static class CoreServicesDI
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration Configuration)

        {
            services.AddMvcCore()//Ignores cycles of lazy loading
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;


                }).AddApiExplorer().AddApiExplorer();

            //Dependencies Injections
            services.AddTransient<IBaseService, BaseService>();

            services.AddTransient<IBookService, BookService>();
            services.AddTransient<ILibraryService, LibraryService>();
           
            return services;
        }
    }
}

