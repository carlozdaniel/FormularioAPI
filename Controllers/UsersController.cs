using Microsoft.AspNetCore.Mvc;
using FormularioAPI.Data;
using FormularioAPI.Models;
using System.Threading.Tasks;
using System;

namespace FormularioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            Console.WriteLine("Datos recibidos:");
            Console.WriteLine($"Nombre: {user.Nombre}");
            Console.WriteLine($"Segundo Nombre: {user.SegundoNombre}");
            Console.WriteLine($"Apellido Paterno: {user.ApellidoPaterno}");
            Console.WriteLine($"Apellido Materno: {user.ApellidoMaterno}");
            Console.WriteLine($"Fecha de Nacimiento: {user.FechaNacimiento}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Telefono: {user.Telefono}");

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}
