using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIFrameworkArellano.Models;

namespace WebAPIFrameworkArellano.Services
{
    public class MensajeRepositorio
    {
        private const string llaveCache = "Almacenamiento";

        //Crear un constructor
        public MensajeRepositorio()
        {
            //Revisar el estado inicial
            var contextoHTTP = HttpContext.Current;

            //Esta vacio, entonces se definen nuevos contactos
            if (contextoHTTP != null)
            {
                if (contextoHTTP.Cache[llaveCache] == null)
                {
                    var misMensajes = new Mensaje[]{
                        new Mensaje{
                            ID = 1, mensaje = "HOLA MUNDO"
                        }
                    };
                    contextoHTTP.Cache[llaveCache] = misMensajes;
                }
            }
        }

        public Mensaje[] GetTODOMensajes()
        {
            //Se agrega para coincidir con el constructor de antes

            var contextoHTTP = HttpContext.Current;

            if (contextoHTTP != null)
            {
                return (Mensaje[])contextoHTTP.Cache[llaveCache];
            }
            /////
            return new Mensaje[]{
            new Mensaje
            {
                ID = 0,
                mensaje = "Placeholder"
            }
            };
        }
    }
}