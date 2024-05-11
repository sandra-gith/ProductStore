using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "products", }); //ToDo: Tener en cuenta, la url de la api estaba apuntando al controlar admin, Admin no es un ApiController, el contralador definido para crear obtener productos es ProductsController. Por lo tanto se debe utilizar products aquí
                                                                                              //Lo recomendable en todo caso es que la Url base apunte solo hasta /api, y dependiendo lo que se necesite en el cliente se le agrega products o orders, o cualquier otro controlador que se deba aplicar.
                                                                                              //Te dejo esos cambios para que los hagas vos como parte de tu aprendizaje. Tambien notar que el controlador Products en este momento solo permite leer, no tiene funciones para crear o actualizar products.
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }
    }
}