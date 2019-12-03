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
    public class VehicleController : ApiController
    {
        CarSalesDBEntities db = new CarSalesDBEntities();

        // GET api/<controller>
        [Route("api2/Vehicle")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                List<Vehicle> entities = db.Vehicles.ToList();

                if (entities == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "No Vehicles Found.");
                }

                List<ApiVehicle> apiVehicles = new List<ApiVehicle>();

                foreach (var record in entities)
                {
                    ApiVehicle apiVehicle = new ApiVehicle();
                    PropertyCopier<Vehicle, ApiVehicle>.Copy(record, apiVehicle);
                    apiVehicles.Add(apiVehicle);
                }
                return Request.CreateResponse(HttpStatusCode.OK, apiVehicles);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }


        }

        // GET api/<controller>/5
        [Route("api2/Vehicle/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var entity = db.Vehicles.Find(id);

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Vehicle with Id " + id.ToString() + " not found.");
                }

                var myApiVehicle = new ApiVehicle();

                PropertyCopier<Vehicle, ApiVehicle>.Copy(entity, myApiVehicle);

                return Request.CreateResponse(HttpStatusCode.OK, myApiVehicle);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                         "Error in the code");
            }
        }

        // POST api/<controller>
        [Route("api2/Vehicle")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]ApiVehicle newVehicle)
        {
            if (ModelState.IsValid)
            {
                Vehicle c = new Vehicle();
                PropertyCopier<ApiVehicle, Vehicle>.Copy(newVehicle, c);
                db.Vehicles.Add(c);
                try
                {
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Cannot add new Vehicle, Try again." + e.StackTrace + "---" + e.InnerException);
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Vehicle added.");
        }

        // PUT api/<controller>/5
        [Route("api2/Vehicle/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiVehicle newVehicle)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Vehicle with Id " + id.ToString() + " not found to update.");
                    }

                    PropertyCopier<ApiVehicle, Vehicle>.Copy(newVehicle, entity);
                    db.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Vehicle with Id " + id.ToString() + " found and updated.");
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
        [Route("api2/Vehicle/{id?}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var entity = db.Vehicles.Find(id);

                if (entity == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, ("That Vehicle ID doesn't exist. Vehicle ID: {0} is incorrect.", id));

                entity.VehicleIsActive = false;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Vehicle set as inactive.");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Error in the code");
            }
        }
    }
}