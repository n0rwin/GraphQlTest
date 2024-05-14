namespace GraphQlTest.Api.Model;

public class PokemonRepository
{
    private static List<Pokemon> PokemonInternal { get; set; } = GeneratePokemon(10);

    public static IQueryable<Pokemon> Pokemon => PokemonInternal.AsQueryable();

    public static void AddPokemon(Pokemon pokemon)
    {
        PokemonInternal.Add(pokemon);
    }

    private static List<Pokemon> GeneratePokemon(int count)
    {
        List<Pokemon> pokemons = new();
        Random random = new Random();
        
        string[] names = { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Snorlax", "Mewtwo", "Gyarados", "Dragonite" };
        
        for(int i = 0; i < count; i++)
        {
            Pokemon pokemon = new ()
            {
                Name = names[i],
                Type = (PokeType)random.Next(Enum.GetNames(typeof(PokeType)).Length),
                Level = random.Next(1, 100),
                Hp = random.Next(50, 200),
                Attack = random.Next(20, 100),
                Defense = random.Next(20, 100),
                SpecialAttack = random.Next(20, 100),
                SpecialDefense = random.Next(20, 100),
                Speed = random.Next(20, 100)
            };
            
            pokemons.Add(pokemon);
        }
        
        return pokemons;
    }
}