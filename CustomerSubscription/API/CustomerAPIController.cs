using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using CustomerSubscription.API;
using CustomerSubscription.Models;

namespace CustomerSubscription.API
{
    [RoutePrefix("api/CustomerSubscription")]
    public class CustomerAPIController : ApiController
    {

        [HttpPost, HttpGet, Route("detail/get")]
        public dynamic GetCustomerInfo(dynamic myParams)
        {
            using (CustomerInfoEntities1 db = new CustomerInfoEntities1())
            {
                var custDetails = db.CustomerInfoes.Where(i => i.CustomerName == "Guj Apollo").FirstOrDefault();
                return custDetails;
            }
            
        }
    }
}