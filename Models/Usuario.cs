using System.Text.Json.Serialization;

namespace WebApiDemo.Models
{
    public class Usuario
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
