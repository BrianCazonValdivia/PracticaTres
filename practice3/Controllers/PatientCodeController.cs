using Microsoft.AspNetCore.Mvc;

namespace practice3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientCodeController : ControllerBase
    {
        private readonly CodeManager _codeManager;
        public PatientCodeController(CodeManager codeManager)
        {
            _codeManager = codeManager;
        }

        [HttpPost]
        public string Post([FromBody] Code code)
        {
            return _codeManager.CrearCodigoPaciente(code);
        }
    }
}