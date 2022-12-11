using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repositories
{
    public class OwnerReository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerReository(DataContext context)
        {
           _context = context;
        } 
        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnerOfAPokemon(int pokemonId)
        {
            return _context.PokemonsOwners.Where(p => p.Pokemon.Id == pokemonId).Select(o => o.Owner).ToList();
        }

        public ICollection<Owner> GetOwners()
        {
            return _context.Owners.ToList();
        }

        public ICollection<Pokemon> GetPokemonByOwner(int OwnerId)
        {
            return _context.PokemonsOwners.Where(p => p.Owner.Id == OwnerId).Select(p => p.Pokemon).ToList();
        }

        public bool OwnerExists(int ownerId)
        {
            return _context.Owners.Any(o => o.Id == ownerId);       
        }
    }
}
