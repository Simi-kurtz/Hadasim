 
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
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {

        [HttpPost]
        [Route("add")]
        public bool addUser(UserModel u)
        {
            return u.AddUser();
        }

        [HttpPost]
        [Route("check")]
        public bool checkUser(UserModel u)
        {
            return u.CheckUser(u);
        }

        [HttpGet]
        [Route("get")]
        public List<UserModel> getUsers()
        {
            UserModel u = new UserModel();
            return u.GetUsers();
        }

        [HttpGet]
        [Route("getUser/{id}")]
        public UserModel GetUser(string id)
        {
            UserModel u = new UserModel();
            return u.GetUser(id);
        }
    }
}
