using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;


namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("API/imag")]

    public class ImagController : ApiController
    {

        [HttpPost]
        [Route("Addimg")]

        public string Addimg()
        {
            string exc = "Exception";
            try
            {

                var files = HttpContext.Current.Request.Files;
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);
                

                if (files.Count > 0)
                {
                    var docfiles = new List<string>();
                    foreach (string item in files)
                    {
                        var postedFile = files[item];
                        var fullPath = Path.Combine(pathToSave, postedFile.FileName);
                        var dbPath = Path.Combine(folderName, postedFile.FileName);
                        var filePath = HttpContext.Current.Server.MapPath("~/" + folderName + "//" + postedFile.FileName + ".jpg");
                        postedFile.SaveAs(filePath);
                        docfiles.Add(filePath);
                        string path = filePath;
                    }
                    return "yes";
                    

                }
                return "no";

            }
            catch (Exception ex)
            {
                return "no";
            }


        }

        //[HttpGet]
        //[Route("data")]
        //public bool GetConnection()
        //{
        //    return true;
        //}
    }
}
