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

        [HttpGet("obter/{codigo}")]
        public IActionResult Obter(int codigo)
        {
            return Ok(_context.CategoriaSet.Find(codigo));
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            //List<Categoria> categorias =
            //    _context.CategoriaSet.ToList();
            //return Ok(categorias);

            return Ok(_context.CategoriaSet.AsEnumerable());
        }

        [HttpPost("adicionar")]
        public IActionResult Adicionar(Categoria categoria)
        {
            _context.CategoriaSet.Add(categoria);
            _context.SaveChanges();

            return Created("Created", $"Categoria {categoria.Codigo} Adicionada com Sucesso.");
        }

        [HttpPut("atualizar")]
        public IActionResult Atualizar(Categoria categoria)
        {
            if (_context.CategoriaSet.
                Any(p => p.Codigo == categoria.Codigo))
            {
                _context.CategoriaSet.Attach(categoria);
                _context.CategoriaSet.Update(categoria);
                _context.SaveChanges();

                return Ok($"Categoria {categoria.Codigo} Atualizada com Sucesso.");
            }

            return BadRequest($"Categoria {categoria.Codigo} não Localizada");
        }

        [HttpDelete("excluir/{codigo}")]
        public IActionResult Excluir(int codigo)
        {
            Categoria categoria = _context.CategoriaSet.Find(codigo);
            if (categoria == null)
                return BadRequest("Categoria não Localizada");

            _context.CategoriaSet.Remove(categoria);
            _context.SaveChanges();

            return Ok($"Categoria {categoria.Codigo} Removida com Sucesso.");
        }
    }
}
