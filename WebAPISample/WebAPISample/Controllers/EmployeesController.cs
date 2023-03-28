using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPISample.Filters;
using WebAPISampleDAL;

namespace WebAPISample.Controllers
{
    [EnableCors("*", "*","*")]
    [BasicAuth]
    public class EmployeesController : ApiController
    {
        //[HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                using (SQLPracticeEntities context = new SQLPracticeEntities())
                {
                    var employees =  context.Employees.ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, employees);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //[HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                using (SQLPracticeEntities context = new SQLPracticeEntities())
                {
                    var employee =  context.Employees.FirstOrDefault(emp => emp.ID == id);
                    if (employee == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"Employee with id = {id} is not found");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, employee);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]Employee emp)
        {
            try
            {
                using (SQLPracticeEntities context = new SQLPracticeEntities())
                {
                    context.Employees.Add(emp);
                    context.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, emp);
                    message.Headers.Location = new Uri(Request.RequestUri +"/"+ emp.ID.ToString());

                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody] Employee emp)
        {
            try
            {
                using (SQLPracticeEntities context = new SQLPracticeEntities())
                {
                    var employee = context.Employees.FirstOrDefault(e => e.ID == id);
                    if (employee == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id = " + id.ToString() + " is not found");
                    }
                    else
                    {
                        employee.FirstName = emp.FirstName;
                        employee.LastName = emp.LastName;
                        employee.Salary = emp.Salary;
                        employee.Gender = emp.Gender;
                        context.SaveChanges();

                        var message = Request.CreateResponse(HttpStatusCode.OK, employee);
                        return message;
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (SQLPracticeEntities context = new SQLPracticeEntities())
                {
                    var employee = context.Employees.FirstOrDefault(e => e.ID == id);
                    if (employee == null)
                    {
                     return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id = " + id.ToString() + " is not found");
                    }
                    else
                    {
                        context.Employees.Remove(employee);
                        context.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
    }
}
