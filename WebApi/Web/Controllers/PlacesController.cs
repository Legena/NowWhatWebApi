using DataLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Models;

namespace Web.Controllers
{
    public class PlacesController : ApiController
    {
        PlacesContext db = new PlacesContext();

        // GET api/values
        public IEnumerable<Place> Get()
        {
            using (db)
            {
                var now = DateTime.UtcNow;
                return db.Places.Where(p => p.EndTime > now).ToList();
            }
        }

        // GET api/values/5
        public Place Get(int id)
        {
            return db.Places.FirstOrDefault(p => p.Id == id);
        }

        // POST api/values
        public void Post([FromBody]PlaceAddModel placeToAdd)
        {
            var place = new Place();

            place.StartTime = placeToAdd.StartTime;
            place.EndTime = placeToAdd.EndTime;
            place.Title = placeToAdd.Title;
            place.LocationUrl = "http://maps.googleapis.com/maps/api/staticmap?size=320x320&sensor=false&markers=" + placeToAdd.Latitude + "," + placeToAdd.Longitude;
            db.Places.Add(place);
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}