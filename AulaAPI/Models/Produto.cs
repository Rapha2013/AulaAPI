using System;

namespace AulaAPI.Models
{
    public class Produto
    {

        public Produto() => CriadoEm = DateTime.Now;

        public int id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        
        public DateTime CriadoEm { get; set; }

        // TOSTRING 
        public override string ToString() => $"Nome: {Nome} | Preço {Preco:C2} | Criado em: {CriadoEm}";
        
    }

}