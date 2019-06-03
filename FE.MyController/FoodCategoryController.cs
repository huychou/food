using FE.Contract;
using FE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FE.MyController
{
    [RoutePrefix("api/Course")]
    public class FoodCategoryController:ApiController
    {
        IFoodCategory courseService = new FoodCategoryService();
        [Route("GetCourse")]
        [HttpGet]
        public IHttpActionResult GetCourse() => Ok(courseService.GetCourses());
    }
}
