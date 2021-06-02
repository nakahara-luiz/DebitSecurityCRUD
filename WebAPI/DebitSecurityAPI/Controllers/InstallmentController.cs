using System;
using DebitSecurity.Crosscutting.Builders;
using DebitSecurity.Domain.Entities;
using DebitSecurity.DTO;
using DebitSecurity.Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DebitSecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstallmentController: BaseController
    {
        private IInstallmentService _service;
        private InstallmentBuilder _installmentBuilder;

        public InstallmentController(IInstallmentService service)
        {
            _service = service;
            _installmentBuilder = new InstallmentBuilder();
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
        public IActionResult Post([FromBody] InstallmentDTO model) {
            return Execute(() => {
                _service.Add(_installmentBuilder.Build(model));
                return model;
            });
        }

        [HttpPut("{PersonId}")]
        public IActionResult Put(int PersonId, [FromBody] InstallmentDTO model) {
            return Execute(() => {
                _service.Update(_installmentBuilder.Build(model));
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