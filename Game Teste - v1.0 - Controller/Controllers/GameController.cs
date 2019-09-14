using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Game_Teste___v1._0___Controller.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Game()
        {
            return View();
        }
    }
}
