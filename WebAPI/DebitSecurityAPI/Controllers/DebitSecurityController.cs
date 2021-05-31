using System.Collections.Generic;
using System.Threading.Tasks;
using DebitSecurity.Domain.Entities;
using DebitSecurity.Interface;
using DebitSecurity.Interface.Interfaces;
using DebitSecurity.Service.services;
using Microsoft.AspNetCore.Mvc;

namespace DebitSecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebitSecurityController: BaseController
    {
        private readonly IBaseService<Document> _service;
        private readonly IDebitSecurityCalculatorService _debitSecurityCalculator;

        public DebitSecurityController(IBaseService<Document> service)
        {
            _service = service;
            _debitSecurityCalculator = new DebitSecurityCalculatorService();
        }

        [HttpGet]
        public IActionResult Get() {
            return Execute(() => {
                var result = _service.Get();
                
                return _debitSecurityCalculator.Calculate(result.Result);
            });
        }

        [HttpGet("{IdDocument}")]
        public IActionResult Get(int IdDocument) {
            return Execute(() => { 
                var result =_service.Get(IdDocument);
                return result.Result;
            });
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Document model) {
            return Execute(() => {
                _service.Add(model);
                return model;
            });
        }

        [HttpPut("{IdDocument}")]
        public IActionResult Put(int IdDocument, [FromBody] Document model) {
            return Execute(() => {
                _service.Update(model);
                return true;
            });
        }

        [HttpDelete("{IdDocument}")]
        public IActionResult Delete(int IdDocument) {
            return Execute(() => {
                _service.Delete(IdDocument);
                return true;
            });
        }
    }
}