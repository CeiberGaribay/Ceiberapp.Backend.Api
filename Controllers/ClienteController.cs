using Ceiberapp.Backend.Api.Db;
using Ceiberapp.Backend.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ceiberapp.Backend.Api.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : Controller
    {
        private readonly DbContextCeiberApp _dbContextCeiberApp;
        
        public ClienteController(DbContextCeiberApp dbContextCeiberApp) => _dbContextCeiberApp = dbContextCeiberApp;

        [HttpPost()]
        public IActionResult Add(Cliente cliente)
        {
            _dbContextCeiberApp.Clientes.Add(cliente);
            _dbContextCeiberApp.SaveChanges();
            return Ok("Created");
        }

        [HttpPut()]
        public IActionResult Update(Cliente cliente)
        {
            var existing = _dbContextCeiberApp.Clientes.FirstOrDefault();
            if (existing == null)
            {
                return NotFound();
            }
            existing.gIdUsuario = cliente.gIdUsuario;
            existing.gIdEmpresa = cliente.gIdEmpresa;
            existing.gIdUsuario = cliente.gIdUsuario;
            existing.sPrimerNombre = cliente.sPrimerNombre;
            existing.sSegundoNombre = cliente.sSegundoNombre;
            existing.sApellidoPaterno = cliente.sApellidoPaterno;
            existing.sApellidoMaterno = cliente.sApellidoMaterno;
            existing.sTipoDocumento = cliente.sTipoDocumento;
            existing.sNumeroDocumento = cliente.sNumeroDocumento;
            existing.sCorreo = cliente.sCorreo;
            existing.sDireccion = cliente.sDireccion;
            existing.sDistrito = cliente.sDistrito;
            existing.sProvincia = cliente.sProvincia;
            existing.sDepartamento = cliente.sDepartamento;
            existing.sCelular1 = cliente.sCelular1;
            existing.sCelular2 = cliente.sCelular2;
            existing.sTelefono = cliente.sTelefono;
            existing.FLAG_CASADO = cliente.FLAG_CASADO;
            existing.gIdClienteConyuge = cliente.gIdClienteConyuge;
            existing.sApellidosNombres = cliente.sApellidosNombres;

            _dbContextCeiberApp.Update(existing);
            _dbContextCeiberApp.SaveChanges();                      
            return Ok("Updated");
        }

        [HttpDelete()]
        public IActionResult Delete(Guid id)
        {

            var existing = _dbContextCeiberApp.Clientes.FirstOrDefault(x => x.gIdCliente == id);
            if (existing == null)
            {
                return NotFound();
            }

            _dbContextCeiberApp.Clientes.Remove(existing);
            _dbContextCeiberApp.SaveChanges();
            return Ok("Updated");
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(Guid id)
        {
            var existing = _dbContextCeiberApp.Clientes.FirstOrDefault(x => x.gIdCliente == id);
            if (existing == null)
            {
                return NotFound();
            }

            return Ok(existing);
        }

        [HttpGet()]
        public ActionResult<IEnumerable<Cliente>> List()
        {
            List<Cliente> cliente = new List<Cliente>();
            try
            {
                  cliente = _dbContextCeiberApp.Clientes.ToList();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
            return Ok(cliente);
        }
    }
}
