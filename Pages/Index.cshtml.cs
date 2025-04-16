using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApiDemo.Models;
using WebApiDemo.Services;

namespace WebApiDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UsuarioService _usuarioService;

        public IndexModel(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public List<Usuario> Usuarios { get; set; } = new();

        public async Task OnGetAsync()
        {
            Usuarios = await _usuarioService.BuscarUsuariosAsync();
        }
    }
}
