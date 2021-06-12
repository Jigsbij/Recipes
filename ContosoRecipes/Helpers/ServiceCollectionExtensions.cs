using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ContosoRecipes.Models;
using Microsoft.Extensions.Options;

namespace ContosoRecipes.Helpers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDatabaseOptions>(configuration.GetSection("MongoDatabase"));
            services.AddSingleton<IMongoDatabaseOptions>(provider => provider.GetRequiredService<IOptions<MongoDatabaseOptions>>().Value);

            ConventionPack pack = new ConventionPack();
            pack.Add(new CamelCaseElementNameConvention());

            ConventionRegistry.Register("Custom Convertions", pack, t => true);
            BsonClassMap.RegisterClassMap<Recipe>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIdMember(cm.GetMemberMap(c => c.Title));
                });
            return services;
        }
    }
}
