using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DebitSecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebitSecurityController: BaseController
    {
        public readonly IBaseService<Document> _service;

        public DebitSecurityController(IBaseService<Document> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() {
            return Execute(() => _service.Get());
        }

        [HttpGet("{IdDocument}")]
        public IActionResult Get(int IdDocument) {
            return Execute(() => _service.Get(IdDocument));
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Document model) {
            return null;//Execute(() => _service.Add<>(model));
        }

        [HttpPut("{IdDocument}")]
        public IActionResult Put(int IdDocument, [FromBody] Document model) {
            return null;//Execute(() => _service.Add<>(model));
        }

        [HttpDelete("{IdDocument}")]
        public IActionResult Put(int IdDocument) {
            return null;//Execute(() => _service.Add<>(model));
        }
    }
}