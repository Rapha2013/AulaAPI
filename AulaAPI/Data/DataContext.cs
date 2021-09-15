using AulaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AulaAPI.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Listar de propriedades das classes que vao virar tabelas no banco
        public DbSet<Produto> TabelaProdutos { get; set; }
    }
}