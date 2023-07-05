using Microsoft.AspNetCore.Mvc;
using Class_Polimorphism.Models;
using Class_Polimorphism.Models.Inmuebles;


namespace Class_Polimorphism.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InmueblesController : Controller
    {
        [HttpGet("GetInmueble")]
        public IActionResult GetInmueble()
        {
            Casa home = new Casa(2, true, 1);
            home.CantidadAmbientes = 2;

            MonoAmbiente depa = new MonoAmbiente(false, true, 1);
            home.SumarAmbientes();
            depa.SumarAmbientes();

            Departamento padre = depa;
            Departamento padreHome = home;

            padre.SumarAmbientes();
            padreHome.SumarAmbientes();

            List<Casa> listaCasas = new List<Casa>();
            listaCasas.Add(home);
            // listaCasas.Add(depa);

            List<Departamento> listaPadre = new List<Departamento>();
            listaPadre.Add(home);
            listaPadre.Add(depa);

            home = (Casa)padre;

            return Ok();
        }
    }
}
