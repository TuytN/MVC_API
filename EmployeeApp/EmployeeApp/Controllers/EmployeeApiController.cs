using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net;

namespace EmployeeApp.Controllers
{
    public class EmployeeApiController : ApiController
    {
        static kms_launchEntities data = new kms_launchEntities();
        List<ASP_API> lst = (from e in data.ASP_API select e).ToList<ASP_API>();

        // GET: EmployeeApi
        public List<ASP_API> GetAllProducts()
        {
            return lst;
        }

        

    }
}