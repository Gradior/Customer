using Gradior.Customer.Api.Controllers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gradior.Customer.Api.Test
{
  public class CustomerControllerFixture
  {
    public CustomerControllerFixture()
    {

    }
    
    internal ILogger<CustomerController> Logger;

    internal CustomerController CreateController() 
    {       
      return new CustomerController(Logger);
    }    
  }
}
