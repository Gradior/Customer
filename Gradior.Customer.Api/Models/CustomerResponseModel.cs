using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gradior.Customer.Api.Models
{
  public class CustomerResponseModel
  {
    public Guid CustomerId { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
  }
}
