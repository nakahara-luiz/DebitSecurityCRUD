using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DebitSecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebitSecurityController: BaseController
    {
        public readonly IDocumentRepository _service;

        public DebitSecurityController(IDocumentRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() {
            return Execute(() => _service.Get());
        }

        [HttpGet("{IdDocument}")]
        public IActionResult Get(int IdDocument) {
            return Execute(() => _service.GetById(IdDocument));
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Document model) {

            return null;//Execute(() => _service.Add<>(model));
        }
    }
}