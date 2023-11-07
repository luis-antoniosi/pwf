using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PWFilmes.Domain;
using PWFilmes.API.Context;

namespace PWFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        PWFilmesContext _context;

        public CategoriaController(PWFilmesContext context)
        {
            _context = context;
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            //List<Categoria> categorias =
            //    _context.CategoriaSet.ToList();
            //return Ok(categorias);

            return Ok(_context.CategoriaSet.AsEnumerable());
        }
    }
}
