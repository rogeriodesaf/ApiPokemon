namespace PokemonApi.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        // Chave estrangeira para o Mestre Pokémon
        public int MestrePokemonId { get; set; }

        // Propriedade de navegação para o Mestre Pokémon
        public MestrePokemonModel MestrePokemon { get; set; }
    }
}
