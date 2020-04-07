using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TesteController: Controller
    {
        [HttpGet("teste")]
        public IActionResult Teste()
        {
            return Ok("Nossa API Teste Funciona Perfeitamente");
        }
    }
}