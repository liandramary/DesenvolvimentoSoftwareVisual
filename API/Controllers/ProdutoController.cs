using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        //POST: /api/produto/create
        [Route("create")]
        [HttpPost]
        public Produto Create(Produto produto)
        {
            return produto;
        }
    }
}