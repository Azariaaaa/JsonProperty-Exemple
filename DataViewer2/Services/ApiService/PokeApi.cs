using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataViewer2.Models.PokemonModel;
using Newtonsoft.Json;

namespace DataViewer2.Services.ApiService
{
    public static class PokeApi
    {
        public static readonly string _baseUrl = "https://pokeapi.co/api/v2/pokemon/";
        public static readonly HttpClient _client = new HttpClient();
        
        public static async Task<Pokemon> GetPokemonByName(string pokemonName)
        {
            try
            {
                string fullUrl = _baseUrl + pokemonName;

                var response = await _client.GetAsync(fullUrl);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: Unable to fetch data. HTTP Status: {response.StatusCode}");
                    return null;
                }

                var json = await response.Content.ReadAsStringAsync();
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(json);

                if (pokemon == null)
                {
                    Console.WriteLine("Error: Unable to deserialize the response.");
                    return null;
                }

                return pokemon;
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"HttpRequestException: {httpEx.Message}");
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"JsonException: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            return null;
        }
    }
}
