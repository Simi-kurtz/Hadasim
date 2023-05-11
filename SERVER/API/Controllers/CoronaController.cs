 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DAL;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Corona")]
    public class CoronaController : ApiController
    {

        [HttpGet]
        [Route("getNotVaccinated")]
        public int getNotVaccinated()
        {
            UserModel u = new UserModel();
            return u.GetNotVaccinated();
        }

        [HttpGet]
        [Route("getActivePatients")]
        public Dictionary<int, int> getActivePatients()
        {
            UserModel u = new UserModel();
            return u.GetActivePatients();
        }
    }
}
