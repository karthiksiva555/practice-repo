using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        [Authorize]
        public HttpResponseMessage Get()
        {
            try
            {
                using (EmployeeDBEntities context = new EmployeeDBEntities())
                {
                    var employees = context.Employees.ToList();
                    if (employees == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "There are no employee records found");
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, employees);

                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
    }
}
