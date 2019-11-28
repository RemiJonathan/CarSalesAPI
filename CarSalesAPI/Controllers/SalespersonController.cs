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
    public class SalespersonController : ApiController
    {
        CarSalesDBEntities db = new CarSalesDBEntities();

        // GET api/<controller>
        [Route("api2/Salespersons")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<Salesperson> entities = db.Salespersons.ToList();

                if (entities == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "No Sales People Found.");
                }

                List<ApiSalesperson> apiSalespersons = new List<ApiSalesperson>();

                foreach (var record in entities)
                {
                    ApiSalesperson apiSalesperson = new ApiSalesperson();
                    PropertyCopier<Salesperson, ApiSalesperson>.Copy(record, apiSalesperson);
                    apiSalespersons.Add(apiSalesperson);
                }
                return Request.CreateResponse(HttpStatusCode.OK, apiSalespersons);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }
        }

        // GET api/<controller>/5
        [Route("api2/Salesperson/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var entity = db.Salespersons.Find(id);

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Sales Person with Id " + id.ToString() + " not found.");
                }

                var myApiSalesperson = new ApiSalesperson();

                PropertyCopier<Salesperson, ApiSalesperson>.Copy(entity, myApiSalesperson);

                return Request.CreateResponse(HttpStatusCode.OK, myApiSalesperson);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                         "Error in the code");
            }
        }

        // POST api/<controller>
        [Route("api2/Salesperson")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]ApiSalesperson newSalesperson)
        {
            try
            {
                Salesperson s = new Salesperson();
                PropertyCopier<ApiSalesperson, Salesperson>.Copy(newSalesperson, s);
                db.Salespersons.Add(s);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "Cannot add new Sales Person, Try again.");
            }
        }

        // PUT api/<controller>/5
        [Route("api2/Salesperson/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiSalesperson newSalesperson)
        {
            try
            {
                var entity = db.Salespersons.FirstOrDefault(x => x.SalespersonId == id);

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Sales Person with Id " + id.ToString() + " not found to update.");
                }

                PropertyCopier<ApiSalesperson, Salesperson>.Copy(newSalesperson, entity);
                db.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK,
                    "Sales Person with Id " + id.ToString() + " found and updated.");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }
        }

        // DELETE api/<controller>/5
        [Route("api2/Salesperson/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                db.Salespersons.Find(id).SalespersonIsActive = false;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }
        }
    }
}