using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppli_Weishang_.Models;
using WebMvc_WeiShang_.Common;

namespace WebMvc_WeiShang_.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tian()
        {
            return View();
        }
        public IActionResult Select()
        {
            return View();
        }


    }
}