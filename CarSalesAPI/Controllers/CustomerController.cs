using DAL;
using DatabaseEntitiesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utils;

namespace CarSalesAPI.Controllers
{
    public class CustomerController : ApiController
    {
        CarSalesDBEntities db = new CarSalesDBEntities();

        // GET api/<controller>
        [Route("api2/Customer")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            List<Customer> entities = db.Customers.ToList();

            if (entities == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "No Customers Found.");
            }

            List<ApiCustomer> apiCustomers = new List<ApiCustomer>();

            foreach (var record in entities)
            {
                ApiCustomer apiCustomer = new ApiCustomer();
                PropertyCopier<Customer, ApiCustomer>.Copy(record, apiCustomer);
                apiCustomers.Add(apiCustomer);
            }

            return Request.CreateResponse(HttpStatusCode.OK, apiCustomers);
        }

        // GET api/<controller>/5
        [Route("api2/Customer/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var entity = db.Customers.Find(id);

            if (entity == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "Customer with Id " + id.ToString() + " not found.");
            }

            var myApiCustomer = new ApiCustomer();

            PropertyCopier<Customer, ApiCustomer>.Copy(entity, myApiCustomer);

            return Request.CreateResponse(HttpStatusCode.OK, myApiCustomer);
        }

        // POST api/<controller>
        [Route("api2/Customer")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT api/<controller>/5
        [Route("api2/Customer/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiCustomer newCustomer)
        {
            var entity = db.Customers.FirstOrDefault(x => x.CustomerId == id);

            if (entity == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "Customer with Id " + id.ToString() + " not found to update.");
            }

            PropertyCopier<ApiCustomer, Customer>.Copy(newCustomer, entity);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, 
                "Customer with Id " + id.ToString() + " found and updated.");
        }

        // DELETE api/<controller>/5
        [Route("api2/Customer/{id?}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}