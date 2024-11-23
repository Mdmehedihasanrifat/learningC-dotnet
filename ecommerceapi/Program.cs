var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sample Data
List<Category> categories = new List<Category>
{
    new Category { CategoryId = Guid.NewGuid(), CategoryName = "Electronics", Price = 1000, CreatedDate = DateTime.Now },
    new Category { CategoryId = Guid.NewGuid(), CategoryName = "Clothing", Price = 2000, CreatedDate = DateTime.Now },
    new Category { CategoryId = Guid.NewGuid(), CategoryName = "Furniture", Price = 3000, CreatedDate = DateTime.Now },
    new Category { CategoryId = Guid.NewGuid(), CategoryName = "Grocery", Price = 4000, CreatedDate = DateTime.Now },
    new Category { CategoryId = Guid.NewGuid(), CategoryName = "Stationary", Price = 5000, CreatedDate = DateTime.Now },
};

// Default endpoint
app.MapGet("/", () => "API working fine");

// Get all categories
app.MapGet("/api/categories", () => Results.Ok(categories));

// Get a single category by ID
app.MapGet("/api/categories/{id}", (Guid id) =>
{
    var category = categories.FirstOrDefault(c => c.CategoryId == id);
    return category != null ? Results.Ok(category) : Results.NotFound($"Category with ID {id} not found");
});

// Create a new category
app.MapPost("/api/categories", (Category newCategory) =>
{
    newCategory.CategoryId = Guid.NewGuid();
    newCategory.CreatedDate = DateTime.Now;
    categories.Add(newCategory);
    return Results.Created($"/api/categories/{newCategory.CategoryId}", newCategory);
});

// Update an existing category
app.MapPut("/api/categories/{id}", (Guid id, Category updatedCategory) =>
{
    var category = categories.FirstOrDefault(c => c.CategoryId == id);
    if (category == null)
    {
        return Results.NotFound($"Category with ID {id} not found");
    }

    category.CategoryName = updatedCategory.CategoryName;
    category.Price = updatedCategory.Price;
    category.CreatedDate = updatedCategory.CreatedDate;

    return Results.Ok(category);
});

// Delete a category
app.MapDelete("/api/categories/{id}", (Guid id) =>
{
    var category = categories.FirstOrDefault(c => c.CategoryId == id);
    if (category == null)
    {
        return Results.NotFound($"Category with ID {id} not found");
    }

    categories.Remove(category);
    return Results.Ok($"Category with ID {id} deleted successfully");
});

app.Run();

public record Category
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
}
