﻿using Microsoft.AspNetCore.Mvc;

namespace App.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("gestao-vendas")]
    public class GestaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("detalhe-pedido/{id:int}")]
        public IActionResult Detalhes(int id)
        {
            return View("Index");
        }
    }
}