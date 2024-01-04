using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using SzyfrVigenère_a_ASP.NET.Models;

namespace SzyfrVigenère_a_ASP.NET.Controllers
{
    public class VigenereController : Controller
    {
        private readonly VigenereService _cipher = new VigenereService();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Szyfrowanie()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Szyfrowanie(Vigenere model)
        {
            var decryptedText = _cipher.Encrypt(model.Tekst, model.Klucz);
            model.ZaszyfrowanyTekst = decryptedText;
            return View(model);
        }

        [HttpGet]
        public IActionResult Odszyfrowanie()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Odszyfrowanie(Vigenere model)
        {
            var decryptedText = _cipher.Decrypt(model.Tekst,model.Klucz);
            model.ZaszyfrowanyTekst = decryptedText;
            return View(model);
        }
    }

}
