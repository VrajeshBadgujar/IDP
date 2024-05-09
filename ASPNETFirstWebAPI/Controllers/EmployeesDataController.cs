using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNETFirstWebAPI.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myEmoloyee =
              {
            "Vrajesh", "Yatin", "Dipesh"
        };

        [HttpGet]
        public string[] GetEmployes()
        {
            return myEmoloyee;
        }

        [HttpGet]
        public string GetEmployeeByIndex(int id) 
        { 
        
          return myEmoloyee[id]; 
        }
            

    }
}
