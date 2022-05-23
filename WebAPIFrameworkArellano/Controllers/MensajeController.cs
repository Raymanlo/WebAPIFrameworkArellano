using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIFrameworkArellano.Models;
using WebAPIFrameworkArellano.Services;

namespace WebAPIFrameworkArellano.Controllers
{
    public class MensajeController : ApiController
    {
        // GET: Mensaje
        /*public ActionResult Index()
        {
            return View();
        }*/
        //Definir variable privada del repositorio de mensajes
        private MensajeRepositorio mensajeRepository;

        //Constructor
        public MensajeController()
        {
            this.mensajeRepository = new MensajeRepositorio();
        }

        public Mensaje[] Get()
        {
            return mensajeRepository.GetTODOMensajes();
        }
    }
}
