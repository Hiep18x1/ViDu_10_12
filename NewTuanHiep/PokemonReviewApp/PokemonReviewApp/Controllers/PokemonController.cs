//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IpokemonRepository _pokemonRepository;
        //private readonly DataContext context;

        public PokemonController(IpokemonRepository pokemonRepository)
        { 
            _pokemonRepository = pokemonRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemon()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemons);

        }

    }
}
