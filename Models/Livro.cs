using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace provaLivro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public double Preco { get; set; }
    
        //ToString
        public override string ToString() =>
            $"Nome: {Nome} || Autor: {Autor} || Editora: {Editora} || Preco: {Preco:C2}";
    }
}