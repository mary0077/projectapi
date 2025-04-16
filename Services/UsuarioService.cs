using System.Text.Json;
using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public class UsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }   

        public async Task<List<Usuario>> BuscarUsuariosAsync()
        {
            var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
                return usuarios ?? new List<Usuario>();
            }

            return new List<Usuario>();
        }
    }
}
