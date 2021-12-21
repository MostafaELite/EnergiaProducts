using EnergiaProducts.Api.Config.MappingProfiles;
using EnergiaProducts.Domain.RepositoryDefinitions;
using EnergiaProducts.Domain.Services.Abstract;
using EnergiaProducts.Persistence.Repositories.Implementation;
using EnergiaProducts.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EnergiaProducts.Api.Config
{
    public class ServiceRegisteration
    {
        //Can be split into multiple methods, RegisterRepos, RegisterDomainServices, Register CORS Policy, etc
        internal static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddCors(options => options.AddPolicy("AllowAll",
                builder => builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()));
                        
            builder.Services.AddSwaggerGen(options =>
            {
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            builder.Services.AddAutoMapper(config => config.AddProfile<ProductsMappingProfile>());

            var connectionString = builder.Configuration.GetValue<string>("ConnectionString");
            builder.Services.AddDbContext<Persistence.EnergiaProductsContext>();


            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IOrderService, OrderService>();

            builder.Services.AddScoped<IProductRepositroy, ProductRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();            
        }
    }
}
