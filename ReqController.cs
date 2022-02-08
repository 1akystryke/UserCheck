using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ConsoleApp1
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReqController : ApiController
    {
        
        [HttpGet]
        public bool UserCheck(string _username)
        {
            return usercheck.isadmin(_username);
        }
    }
}
