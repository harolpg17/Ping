using Ping.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ping.Controllers
{
    public class MensajesController : ApiController
    { 
        public string Emitir()
        {
            var emitirMensaje = new EmitirMensaje();
            var response = emitirMensaje.Call("PING_MESSAGE");
            emitirMensaje.Close();
            return response;
        }
    }
}
