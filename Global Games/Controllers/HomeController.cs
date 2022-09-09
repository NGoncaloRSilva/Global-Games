using Global_Games.Data;
using Global_Games.Data.Entities;
using Global_Games.Helpers;
using Global_Games.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Global_Games.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsletterRepository _newsletterRepository;
        private readonly IBudgetRepository _budgetRepository;

        public HomeController(ILogger<HomeController> logger, 
            INewsletterRepository newsletterRepository,
            IBudgetRepository budgetRepository)
        {
            _logger = logger;
            _newsletterRepository = newsletterRepository;
            _budgetRepository = budgetRepository;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Newsletter Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewsletterSend(Newsletter newsletter)
        {
            if (newsletter != null)
            {
                
                await _newsletterRepository.CreateAsync(newsletter);
                return RedirectToAction(nameof(Home));
            }

            return View(newsletter);
        }

        // Budget Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BudgetSend(Budget budget)
        {
            if (budget != null)
            {
                

                
                await _budgetRepository.CreateAsync(budget);
                return RedirectToAction(nameof(Home));
            }
            return View(budget);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
