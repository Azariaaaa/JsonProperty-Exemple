using DataViewer2.Models.PokemonModel;
using DataViewer2.Services.ApiService;

namespace DataViewer2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Pokemon pokemon = await PokeApi.GetPokemonByName("he");

            Console.WriteLine(pokemon.Name);
            Console.WriteLine(pokemon.PokedexNumber);
            foreach(var type in pokemon.Types)
            {
                await Console.Out.WriteLineAsync(type.Type.Name);
            }
            Console.WriteLine(pokemon.Sprite.SpriteUrl);
        }
    }
}