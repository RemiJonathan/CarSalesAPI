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
        [Route("api2/Salesperson")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<Salesperson> entities = db.Salespersons.Where(x => x.SalespersonIsActive == true).ToList();

                if (entities == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "No Salespersons Found.");
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
                        "Salesperson with Id " + id.ToString() + " not found.");
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
            if (ModelState.IsValid)
            {
                Salesperson c = new Salesperson();
                PropertyCopier<ApiSalesperson, Salesperson>.Copy(newSalesperson, c);
                db.Salespersons.Add(c);
                try
                {
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Cannot add new Salesperson, Try again." + e.StackTrace + "---" + e.InnerException);
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Salesperson added.");
        }

        // PUT api/<controller>/5
        [Route("api2/Salesperson/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiSalesperson newSalesperson)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = db.Salespersons.FirstOrDefault(x => x.SalespersonId == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Salesperson with Id " + id.ToString() + " not found to update.");
                    }

                    PropertyCopier<ApiSalesperson, Salesperson>.Copy(newSalesperson, entity);
                    db.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Salesperson with Id " + id.ToString() + " found and updated.");
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

        // DELETE api/<controller>/5
        [Route("api2/Salesperson/{id?}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var entity = db.Salespersons.Find(id);

                if (entity == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, ("That Salesperson ID doesn't exist. Salesperson ID: {0} is incorrect.", id));

                entity.SalespersonIsActive = false;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Salesperson set as inactive.");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }
        }
    }
}