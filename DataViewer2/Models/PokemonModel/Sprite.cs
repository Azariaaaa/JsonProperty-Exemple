using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataViewer2.Models.PokemonModel
{
    public class Sprite
    {
        [JsonProperty("front_default")]
        public string SpriteUrl { get; set; }
    }
}
