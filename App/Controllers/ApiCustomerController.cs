using BussinesAccess.Repositories;
using Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace App.Controllers
{
    [RoutePrefix("Api/Customers")]
    public class ApiCustomerController : BaseApiController<CustomerRepository, ApplicationContext, Customer>
    {

        [HttpGet]
        [ResponseType(typeof(List<Customer>))]
        [Route("Search")]
        public async Task<IHttpActionResult> GetCustomers(string keywords)
        {
            return ResultAction(await Repository.Search(keywords));
        }
        [HttpGet]
        [ResponseType(typeof( Customer))]
        [Route("{id}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            return ResultAction(await Repository.FindByIdAsync(id));
        }


        [Route("{customerId}/orders")]
        [HttpGet]
        [ResponseType(typeof(List<Order>))]
        public async Task<IHttpActionResult> GetOrders(int customerId)
        {
            return ResultAction(await Repository.GetOrders(customerId));
        }
    }
}
