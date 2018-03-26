using Ping.Bus;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ping.Controllers
{
    public class MensajesController : ApiController
    { 
        public async Task<IHttpActionResult> Emitir(string mensaje)
        {
            var emitirMensaje = new EmitirMensaje();
            var response = await emitirMensaje.CallAsync(mensaje);
            emitirMensaje.Close();
            return Ok(response);
        }
    }
}
