using GraphQlTest.Api.Model;

namespace GraphQlTest.Api.GraphQlApi;

public class Queries
{
    [UseProjection]  
    [UseFiltering]  
    [UseSorting]
    [GraphQLName("pokemon")]
    public IQueryable<Pokemon> GetPokemon =>  
        PokemonRepository.Pokemon;

    [UseFirstOrDefault]
    [UseProjection]
    public IQueryable<Pokemon?> GetPokemonByName(
        string name) =>
        PokemonRepository.Pokemon.Where(p => p.Name == name);
}