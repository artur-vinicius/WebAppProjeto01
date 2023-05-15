using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppProjeto01.Models;

namespace WebAppProjeto01.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Home> Homec { get; set; }

        public System.Data.Entity.DbSet<WebAppProjeto01.Models.Home> Homes { get; set; }
    }
}