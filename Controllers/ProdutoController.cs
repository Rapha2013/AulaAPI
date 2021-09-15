
using System;
using System.Collections.Generic;
using System.Linq;
using AulaAPI.Data;
using AulaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [ApiController]
    [Route("api/produto")] 
    public class ProdutoController : ControllerBase
    {
        // VARIAVEL GLOBAL
        private readonly DataContext _context;
        //Construtor
        public ProdutoController(DataContext context) => _context = context;

        //POST api/produto/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Produto produto)
        {
            _context.TabelaProdutos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);
        }

        //GET api/produto/create
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.TabelaProdutos.ToList());


        //GET api/produto/create
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute]int id) {

            Produto produto = _context.TabelaProdutos.Find(id);
            if (produto == null)
            {   
                return NotFound();
            }
            return Ok(produto);

        }

       
    }
}