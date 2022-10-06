using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/cartaz")]
    public class CartazController : ControllerBase 
    {
        private readonly DataContext _context;
        public CartazController(DataContext context) => _context = context;

        // POST: /api/cartaz/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody]  Cartaz cartaz)
        {
            _context.Cartaz.Add(cartaz);
            _context.SaveChanges();
            return Created("", cartaz);
        }

        // GET: /api/cartaz/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Cartaz.ToList());

        // PATCH: /api/cartaz/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Cartaz cartaz)
        {
            try
            {
                _context.Cartaz.Update(cartaz);
                _context.SaveChanges();
                return Ok(cartaz);
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE: /api/cartaz/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Cartaz cartaz = _context.Cartaz.Find(id);
            if (cartaz != null)
            {
                _context.Cartaz.Remove(cartaz);
                _context.SaveChanges();
                return Ok(cartaz);
            }
            return NotFound("Não achei nada, vai Toma no cu zezin!!");
        }
    }
}