using Microsoft.AspNetCore.Mvc;
using PortalDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalDeVendas.Controllers
{
    public class Departamentos : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            return View(list);
        }
    }
}
