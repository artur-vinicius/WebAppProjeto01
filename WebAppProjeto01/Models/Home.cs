using System.Collections.Generic;
using Modelo.Tabelas;
using Modelo.Cadastros;

namespace WebAppProjeto01.Models
{
    public class Home
    {
        public IEnumerable<Fabricante> Fabricantes { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}