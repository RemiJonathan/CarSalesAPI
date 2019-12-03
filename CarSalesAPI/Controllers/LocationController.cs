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
    public class LocationController : ApiController
    {
        CarSalesDBEntities db = new CarSalesDBEntities();

        // GET api/<controller>
        [Route("api2/Location")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<Location> entities = db.Locations.ToList();

                if (entities == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "No Locations Found.");
                }

                List<ApiLocation> apiLocations = new List<ApiLocation>();

                foreach (var record in entities)
                {
                    ApiLocation apiLocation = new ApiLocation();
                    PropertyCopier<Location, ApiLocation>.Copy(record, apiLocation);
                    apiLocations.Add(apiLocation);
                }
                return Request.CreateResponse(HttpStatusCode.OK, apiLocations);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }


        }

        // GET api/<controller>/5
        [Route("api2/Location/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var entity = db.Locations.Find(id);

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Location with Id " + id.ToString() + " not found.");
                }

                var myApiLocation = new ApiLocation();

                PropertyCopier<Location, ApiLocation>.Copy(entity, myApiLocation);

                return Request.CreateResponse(HttpStatusCode.OK, myApiLocation);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                         "Error in the code");
            }
        }

        // POST api/<controller>
        [Route("api2/Location")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]ApiLocation newLocation)
        {
            if (ModelState.IsValid)
            {
                Location c = new Location();
                PropertyCopier<ApiLocation, Location>.Copy(newLocation, c);
                db.Locations.Add(c);
                try
                {
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Cannot add new Location, Try again." + e.StackTrace + "---" + e.InnerException);
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Location added.");
        }

        // PUT api/<controller>/5
        [Route("api2/Location/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiLocation newLocation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = db.Locations.FirstOrDefault(x => x.LocationId == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Location with Id " + id.ToString() + " not found to update.");
                    }

                    PropertyCopier<ApiLocation, Location>.Copy(newLocation, entity);
                    db.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Location with Id " + id.ToString() + " found and updated.");
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
        [Route("api2/Location/{id?}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var entity = db.Locations.Find(id);

                if (entity == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, ("That Location ID doesn't exist. Location ID: {0} is incorrect.", id));

                entity.LocationIsActive = false;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Location set as inactive.");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }
        }
    }
}