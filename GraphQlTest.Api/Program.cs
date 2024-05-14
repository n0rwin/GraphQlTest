using GraphQlTest.Api.GraphQlApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "default",
        policy =>
        {
            policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        });
});

builder.Services.AddGraphQLServer()
    .AddQueryType<Queries>()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .AddMutationType<Mutations>();

var app = builder.Build();

app.UseCors("default");

app.MapGraphQL(path: "/graphql");

app.Run();