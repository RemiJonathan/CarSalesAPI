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
    public class SaleController : ApiController
    {
        CarSalesDBEntities db = new CarSalesDBEntities();

        // GET api/<controller>
        [Route("api2/Sale")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<Sale> entities = db.Sales.ToList();

                if (entities == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "No Sales Found.");
                }

                List<ApiSale> apiSales = new List<ApiSale>();

                foreach (var record in entities)
                {
                    ApiSale apiSale = new ApiSale();
                    PropertyCopier<Sale, ApiSale>.Copy(record, apiSale);
                    apiSales.Add(apiSale);
                }
                return Request.CreateResponse(HttpStatusCode.OK, apiSales);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }


        }

        // GET api/<controller>/5
        [Route("api2/Sale/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var entity = db.Sales.Find(id);

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Sale with Id " + id.ToString() + " not found.");
                }

                var myApiSale = new ApiSale();

                PropertyCopier<Sale, ApiSale>.Copy(entity, myApiSale);

                return Request.CreateResponse(HttpStatusCode.OK, myApiSale);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                         "Error in the code");
            }
        }

        // POST api/<controller>
        [Route("api2/Sale")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]ApiSale newSale)
        {
            if (ModelState.IsValid)
            {
                Sale c = new Sale();
                PropertyCopier<ApiSale, Sale>.Copy(newSale, c);
                db.Sales.Add(c);
                try
                {
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Cannot add new Sale, Try again." + e.StackTrace + "---" + e.InnerException);
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Sale added.");
        }

        // PUT api/<controller>/5
        [Route("api2/Sale/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiSale newSale)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = db.Sales.FirstOrDefault(x => x.SaleId == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Sale with Id " + id.ToString() + " not found to update.");
                    }

                    PropertyCopier<ApiSale, Sale>.Copy(newSale, entity);
                    db.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Sale with Id " + id.ToString() + " found and updated.");
                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                            "Error in the code");
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        /**************
         * 
         * 
         * DELETE DOES NOT NEED TO BE IMPLEMENTED IN SALE, SINCE THERE IS NO ACTIVE FIELD.
         * 
         * ************/
    }
}