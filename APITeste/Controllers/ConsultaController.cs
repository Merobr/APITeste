using APITeste.BLL;
using APITeste.Model;
using APITeste.Repository;
using Azure;
using Microsoft.AspNetCore.Mvc;

namespace APITeste.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase //Controller
    {
        private readonly ConsultaBLL _bll;

        public ConsultaController(ConsultaBLL bll)
        {
            _bll = bll;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Funcionando!");
        }

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            var response = _bll.ListarProdutos();
            return Ok(response);
        }

        //[HttpPost]
        //public ConsultaResponseModel ListarProdutos(ConsultaRequestModel request)
        //{
        //    var BLL = new ConsultaBLL();

        //    BLL.ListarProdutos();

        //    return response;
        //}
    }
}
