using Gradior.Customer.Api.Controllers;
using Gradior.Customer.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Gradior.Customer.Api.Test
{
  public class CustomerController_GetCustomer: IClassFixture<CustomerControllerFixture>
  {
    internal CustomerController controller;

    public CustomerController_GetCustomer(CustomerControllerFixture fixture)
    {
      _fixture = fixture;
      controller =  _fixture.CreateController();
    }

    private readonly CustomerControllerFixture _fixture;

    [Fact]
    public void GetCustomer_CustomerExists_ReturnsOkResultAndCustomerDetails()
    {
      var id = "3a8c8496-e8f1-43b7-aa00-65df88a93ba5";

      var result = controller.GetCustomer(id);

      var customer = result.Value;

      Assert.NotNull(result);
      Assert.Equal(id, customer.CustomerId.ToString());
    }
  }
}
