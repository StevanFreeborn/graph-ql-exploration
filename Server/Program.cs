var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.UseHttpsRedirection();

app.Run();

public class Query
{
    public Book GetBook() => new("The Hitchhiker's Guide to the Galaxy", new("Douglas Adams"));
}


public record Book(string Title, Author Author);

public record Author(string Name);
