using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetCore_DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNetCore_DatabaseFirst.Controllers
{
    public class OperaController : Controller
    {
        public IActionResult Index()
        {
            OperaModel o = new OperaModel()
            {
                OperaID = 1,
                Title = "你好我樂樂",
                Year = 1600,
                Composer = "佩里"
            };
            return View(o);
        }
    }
}