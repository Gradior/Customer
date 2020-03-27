using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gradior.Customer.Api.Controllers
{
  [Route("customers")]
  [ApiController]
  public class CustomerController : ControllerBase
  {
    private readonly ILogger<CustomerController> _logger;
    public CustomerController(ILogger<CustomerController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult GetCustomers() 
    {
      return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetCustomer([FromRoute] string id)
    {
      return Ok();
    }
  }
}