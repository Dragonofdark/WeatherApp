using Newtonsoft.Json;

namespace WeatherApp
{
    public class Clima
    {
        [JsonProperty("nome")]
        public string Title { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("clima")]
        public Clima[] Climas { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibilidade")]
        public long Visibilidade { get; set; }

        [JsonProperty("vento")]
        public Vento Vento { get; set; }

        [JsonProperty("nuvens")]
        public Nuvens Nuvens { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("cod")]
        public long Cod { get; set; }
    }


    public class Nuvens
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }

    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("pressão")]

        public long Pressao { get; set; }

        [JsonProperty("humidade")]
        public long Humididade { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
    }

    public class Sys
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("message")]
        public double Message { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("amanhecer")]
        public long Amanhecer { get; set; }

        [JsonProperty("Anoitecer")]
        public long Anoitecer { get; set; }
    }

    public class Climas
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("main")]
        public string Visibilidade { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Vento
    {
        [JsonProperty("velocidade")]
        public double Velocidade { get; set; }

        [JsonProperty("deg")]
        public long Deg { get; set; }
    }
}
