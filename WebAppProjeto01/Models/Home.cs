using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto01.Models
{
    public class Home
    {
        public IEnumerable<Fabricante> fabricantes { get; set; }
        public IEnumerable<Categoria> categorias { get; set; }
    }
}