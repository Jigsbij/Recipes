namespace ContosoRecipes.Models
{
    public class MongoDatabaseOptions : IMongoDatabaseOptions
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string RecipesCollectionName { get; set; }
    }
}
