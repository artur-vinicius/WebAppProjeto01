﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto01.Context;

namespace WebAppProjeto01.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}