using System;
using Microsoft.AspNetCore.Mvc;

namespace DebitSecurityAPI.Controllers
{
    public class BaseController: ControllerBase
    {
        protected IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}