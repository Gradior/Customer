using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gradior.Customer.Api.Models;
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
    public ActionResult<IEnumerable<CustomerResponseModel>> GetCustomers() 
    {

      var response = new List<CustomerResponseModel>
      {
        new CustomerResponseModel
        {
          CustomerId = Guid.NewGuid(),
          FirstName = "Gimil",
          SecondName = "Sin"
        } 
      };
          
      return response;
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<CustomerResponseModel> GetCustomer([FromRoute] string id)
    {
      _ = Guid.TryParse(id, out Guid result);

      var response = new CustomerResponseModel 
      {
        CustomerId = result,
        FirstName = "Gimil",
        SecondName = "Sin"
      };

      return response;
    }
  }
}