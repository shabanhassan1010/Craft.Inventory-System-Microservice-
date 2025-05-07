namespace Craft.Inventory.Api.End_Points.Categories
{
    public class CreateCategoriesResponse
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public CreateCategoriesResponse(string name , string description)
        {
            Name = name;
            Description = description;
        }
    }
}
