using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IpokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        bool PokemonExist (int pokeId);
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool Save();    
    }
}
