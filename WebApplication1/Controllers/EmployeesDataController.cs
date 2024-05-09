using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myEmployees = {"Adil", "Bilal", "Zain" };
        [HttpGet]
     public string[] GetEmployee()
        {
            return myEmployees;
        }

        [HttpGet]
        public string GetEmployeeByIndex(int id)
        {
            return myEmployees[id];
        }
    }
}
