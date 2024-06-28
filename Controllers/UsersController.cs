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
        // Inyección de dependencias de AppDbContext

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            // Añade el usuario a la base de datos y guarda los cambios de manera asíncrona
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}
