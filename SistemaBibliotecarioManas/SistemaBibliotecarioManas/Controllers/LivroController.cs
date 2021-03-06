using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecarioManas.Application.Common;
using SistemaBibliotecarioManas.Application.Models.Livro;
using SistemaBibliotecarioManas.Application.Service.Livro;
using System;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : Controller
    {
        private readonly ILivroService _service;

        public LivroController(ILivroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Create([FromBody] LivroRequestModel request)
        {
            try
            {
                var id = await _service.Create(request);
                return CreatedAtRoute(request, id);
            }
            catch(ErrosException ex)
            {
                return BadRequest(ex.Errors);
            }
            catch(DbUpdateException ex)
            {
                return StatusCode(500, ex.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            try
            {
                return Ok(await _service.GetById(id));
            }
            catch (ErrosException ex)
            {
                return BadRequest(ex.Errors);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [Route("{id}")]
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] LivroRequestModel model)
        {
            try
            {
                await _service.Update(id, model);
                return Ok("Livro atualizado com sucesso.");
            }
            catch (ErrosException ex)
            {
                return BadRequest(ex.Errors);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                await _service.Delete(id);
                return Ok("Deletado com sucesso.");
            }
            catch (ErrosException ex)
            {
                return BadRequest(ex.Errors);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ErrosException ex)
            {
                return NotFound(ex.Errors);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
