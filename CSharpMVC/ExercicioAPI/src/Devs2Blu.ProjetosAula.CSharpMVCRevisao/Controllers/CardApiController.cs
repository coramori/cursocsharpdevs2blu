using Devs2Blu.ProjetosAula.CSharpMVCRevisao.Models;
using Devs2Blu.ProjetosAula.CSharpMVCRevisao.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.CSharpMVCRevisao.Controllers
{
    [Route("drinks")]
    public class CardApiController : Controller
    {
        private readonly ILogger<CardApiController> _logger;
        private readonly ServiceAPI service;

        public CardApiController(ILogger<CardApiController> logger)
        {
            _logger = logger;
            service = new ServiceAPI();
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("loadlist")]
        public async Task<PartialViewResult> LoadListDrinks()
        {
            _logger.LogInformation("Carregando a lista de Drinks");
            var result = await service.GetListDrinks();
            return PartialView(result);
        }

        [Route("search/{drinkName}")]
        public async Task<PartialViewResult> SearchDrinks(string drinkName)
        {
            var drink = await service.GetDrinkByName(drinkName);            
            return PartialView(drink);
        }

    }
}