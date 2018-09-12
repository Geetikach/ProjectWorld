using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Work.DataBaseAccess;

namespace Core.Work.Controllers
{
    public class HelloWorldController : ApiController
    {

        public string GetName()
        {
            return "WEB API - Hello world";

            /*
             * 
             * Here we can extend code to get the name or any details by connecting to Database.
             */
        }


        private string RecieveNameFromDB()
        {

            DataAccessBase dbLayer = new DataAccessBase();

            return dbLayer.GetMyName();            
        }
    }
}
