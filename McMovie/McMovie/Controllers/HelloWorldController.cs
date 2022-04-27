using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace McMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /Hello World/

        /* 
        public string Index()
        {
            return "This is my default action...";
        }
        */
        public IActionResult Index() //Metodo de accion
        {
            return View(); //Llama al metodo View del controlador 
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //Estos datos se van a pasar a la vista
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        //GET: /HelloWorld/Welcome/
        /*
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        */
    }
}

        /* 
         Cada metodo PUBLIC en un controlador uede ser invocado como un punto de conexion HTTP
        En el ejemplo anterior, ambos metodos devuelven una cadena (observe los comentarios de cada metodo)

        Un punto de conexion HTTP:
        1.Es una direccion URL que se puede establecer como destino en la aplicacion web. 
        Ej: https://localhost:5001/HelloWorld
        2.COmbina:
            -EL protocolo: (HTTPs)
            -La ubicacion de red del servidor web, incluido el puerto TCP (localhost:5001)
            -El URL de destino (HelloWorld)
         
         */
