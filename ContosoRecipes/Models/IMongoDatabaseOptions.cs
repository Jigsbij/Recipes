namespace ContosoRecipes.Models
{
    public interface IMongoDatabaseOptions
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string RecipesCollectionName { get; set; }
    }
}