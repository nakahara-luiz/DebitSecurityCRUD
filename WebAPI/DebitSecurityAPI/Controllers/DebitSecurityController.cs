using System;
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
        private readonly IDebitService _service;
        private readonly IDebitSecurityCalculatorService _debitSecurityCalculator;

        public DebitSecurityController(IDebitService service)
        {
            _service = service;
            _debitSecurityCalculator = new DebitSecurityCalculatorService();
        }

        [HttpGet]
        public IActionResult Get() {
            return Execute(() => {
                var result = _service.GetComplete();
                
                return _debitSecurityCalculator.Calculate(result.Result);
            });
        }

        [HttpGet("{IdDebit}")]
        public IActionResult Get(Guid IdDebit) {
            return Execute(() => { 
                var result =_service.GetComplete(IdDebit);
                return result.Result;
            });
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Debit model) {
            return Execute(() => {
                _service.Add(model);
                return model;
            });
        }

        [HttpPut("{IdDebit}")]
        public IActionResult Put(int IdDebit, [FromBody] Debit model) {
            return Execute(() => {
                _service.Update(model);
                return true;
            });
        }

        [HttpDelete("{IdDebit}")]
        public IActionResult Delete(Guid IdDebit) {
            return Execute(() => {
                _service.Delete(IdDebit);
                return true;
            });
        }
    }
}