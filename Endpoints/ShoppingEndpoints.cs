

using mayden.shoppingapp.data;
using mayden.shoppingapp.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public static class ShoppingEndpoints
{
    public static void AddShoppingEndpoints(this WebApplication app)
    {
        app.MapGet("/products", async (AppDbContext db) =>
            await db.Products.ToListAsync()).WithName("GetProducts").WithOpenApi();

        app.MapPost("/products/add", async (Product product, AppDbContext db) =>
        {
            db.Products.Add(product);
            await db.SaveChangesAsync();
            return Results.Created($"/products/{product.Id}", product);
        }).WithName("AddProduct").WithOpenApi();

        app.MapPost("/products/update", async (Product product, AppDbContext db) =>
        {
            db.Products.Update(product);
            await db.SaveChangesAsync();
            return Results.Created($"/products/{product.Id}", product);
        }).WithName("UpdateProduct").WithOpenApi();
    }   
}