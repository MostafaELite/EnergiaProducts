using EnergiaProducts.Domain.RepositoryDefinitions;
using EnergiaProducts.Domain.Services.Abstract;
using EnergiaProducts.Persistence;
using EnergiaProducts.Persistence.Repositories.Implementation;
using EnergiaProducts.Services.Implementation;
using Microsoft.EntityFrameworkCore;

namespace EnergiaProducts.Api.Config
{
    public class PipelineConfig
    {
        internal static void Configure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                using var scope = app.Services.CreateScope();
                var context = scope.ServiceProvider.GetService<EnergiaProductsContext>();
                context.Database.EnsureCreated();
            }

            app.UseCors(policyName: "AllowAll");
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
        }


    }
}
