using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PWFilmes.Domain;

namespace PWFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet("listar")]
        public IActionResult Listar()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria
            {
                Codigo = 1,
                Descricao = "Terror",
                Cor = "Vermelho"
            });

            categorias.Add(new Categoria
            {
                Codigo = 2,
                Descricao = "Comédia",
                Cor = "Azul"
            });

            return Ok(categorias);
        }
    }
}
