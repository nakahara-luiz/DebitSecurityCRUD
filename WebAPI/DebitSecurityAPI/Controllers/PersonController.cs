using System;
using DebitSecurity.Crosscutting.Builders;
using DebitSecurity.DTO;
using DebitSecurity.Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DebitSecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: BaseController
    {
        private IPersonService _service;
        private PersonBuilder _personBuilder;
        public PersonController(IPersonService service)
        {
            _service = service;
            _personBuilder = new PersonBuilder();
        }

        [HttpGet]
        public IActionResult Get() {
            return Execute(() => {
                return _service.GetComplete().Result;
            });
        }

        [HttpGet("{PersonId}")]
        public IActionResult Get(Guid PersonId) {
            return Execute(() => { 
                var result =_service.GetComplete(PersonId);
                return result.Result;
            });
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] PersonDTO model) {
            return Execute(() => {
                _service.Add(_personBuilder.Build(model));
                return model;
            });
        }

        [HttpPut("{PersonId}")]
        public IActionResult Put(Guid PersonId, [FromBody] PersonDTO model) {
            return Execute(() => {
                _service.Update(_personBuilder.Build(model));
                return true;
            });
        }

        [HttpDelete("{PersonId}")]
        public IActionResult Delete(Guid PersonId) {
            return Execute(() => {
                _service.Delete(PersonId);
                return true;
            });
        }
    }
}