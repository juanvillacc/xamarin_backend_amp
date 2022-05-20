using Microsoft.AspNetCore.Mvc;

namespace AmpApi.API.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult ObtenerToken(string usuario , string clave)
        {
            return View();
        }
    }
}
