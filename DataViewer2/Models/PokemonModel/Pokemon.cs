using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataViewer2.Models.PokemonModel
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("order")]
        public int PokedexNumber { get; set; }
        [JsonProperty("types")]
        public List<TypeSlot> Types { get; set; }
        [JsonProperty("sprites")]
        public Sprite Sprite { get; set; }
    }
}
