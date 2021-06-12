using ContosoRecipes.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoRecipes.Data
{
    public class MongoRecipeDataStore : IRecipeDataStore
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _database;
        private readonly MongoDatabaseOptions _mongodbSettings;
        public MongoRecipeDataStore(IMongoClient mongoClient, IOptions<MongoDatabaseOptions> mongodbOptions, IMongoDatabase database)
        {
            _mongoClient = mongoClient;
            _mongodbSettings = (MongoDatabaseOptions)mongodbOptions;
            _database = database;
        }
        public Task<IEnumerable<Recipe>> GetRandomRecipes<Recipe>(int count)
        {
            throw new NotImplementedException();
        }
        public Task<Recipe> GetRecipeById<Recipe>(string id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Recipe>> GetRecipesById<Recipe>(string[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetRecipesById<T>(string ids)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRecipe(string recipe_id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Recipe>> SearchRecipesByIngredients<Recipe>(string[] ingredients)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Recipe>> SearchRecipesByTags<Recipe>(string[] tags)
        {
            throw new NotImplementedException();
        }
        public Task UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
