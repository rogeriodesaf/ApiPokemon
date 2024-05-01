namespace PokemonApi.Models { 
public class MestrePokemonModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Coleção de Pokémon do Mestre Pokémon
    public List<PokemonModel> Pokemons { get; set; }
}
}