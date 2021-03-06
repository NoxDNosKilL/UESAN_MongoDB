using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UESAN_MongoDB.API.Service;

namespace UESAN_MongoDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public async Task<IActionResult> GetCustomers()
        {
            var result = await _customerService.GetCustomers();
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetCustomerById")]
        public async Task<IActionResult> GetCustomerById(string id)
        {
            var result = await _customerService.GetCustomerById(id);
            if (result == null)
                return NotFound();

            return Ok(new { Customer = result });

        }

    }

}
