using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Xml.Linq;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Cora Amorim", Login = "coramori" },
                new User { Id = 2, Name = "Marcos Santos", Login = "marcoss"},
                new User { Id = 3, Name = "Carlos Lima", Login = "carlosl"},
                new User { Id = 4, Name = "Augusto Bonatti", Login = "augustob"},
                new User { Id = 5, Name = "Yuri Schmidt", Login = "yuris"},
                new User { Id = 6, Name = "Yung Lee Tsu", Login = "yungt"},
                new User { Id = 7, Name = "Ramon Lisboa", Login = "ramonl" }
            };
            return View(users);
        }

        [Route("indicadores")]
        [Route("numbers")]
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            //var result = Service.GetLista();
            return PartialView();
        }
    }
}
