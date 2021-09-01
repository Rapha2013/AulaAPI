
using System;
using AulaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [ApiController]
    [Route("api/produto")] 
    public class ProdutoController : ControllerBase
    {
        //POST api/produto/create
        [HttpPost]
        [Route("create")]
        public Produto Create(Produto produto)
        {
            Console.WriteLine(produto);
            produto.Nome += " alterado";
            return produto;
        }
    }
}