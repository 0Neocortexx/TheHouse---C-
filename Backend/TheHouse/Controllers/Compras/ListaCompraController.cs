using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Services.Interfaces;

namespace TheHouse.Controllers.Compras
{
    [Route("api/listacompra")]
    [ApiController]
    public class ListaCompraController : Controller
    {
        private readonly IListaCompraService _listaCompraService;
        private readonly IMapper _mapper;

        public ListaCompraController(IListaCompraService listaCompraService, IMapper mapper)
        {
            _listaCompraService = listaCompraService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("{userId}")]
        public async Task<ActionResult<List<GetListaCompraDto>>> GetAllListasDeCompraByUserId(Guid userId)
        {
            try
            {
                var listas = await _listaCompraService.GetListaComprasByUserId(userId);

                if(listas == null)
                    return StatusCode(200, "Sem Listas Cadastradas!");

                return Ok(listas);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor! - " + ex.Message);
            }
        }

        [Authorize]
        [HttpGet("{userId}/{id}")]
        public async Task<ActionResult<GetListaCompraDto>> GetListaDeCompra(int id)
        {
            try
            {
                var compra = await _listaCompraService.GetListaCompraById(id);

                if (compra == null)
                    return NotFound();

                return Ok(compra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [HttpPost("novo")]
        public async Task<ActionResult> CreateListaCompra([FromBody] CreateListaCompraDto data)
        {
            try
            {
                await _listaCompraService.AddListaCompra(data);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }

        [Authorize]
        [HttpDelete("{idLista}")]
        public async Task<ActionResult> DeleteLista(int idLista)
        {
            try
            {
                await _listaCompraService.RemoveListaCompra(idLista);

                return StatusCode(204, "Item Excluido com sucesso!");
            } 
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
