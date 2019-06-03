using FE.Contract;
using FE.Model;
using FE.Services;
using FE.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FE.WebApi.Controllers
{
    [RoutePrefix("api/FoodCategory")]
    public class FoodCategoryController : ApiController
    {
        HelperBiz helperBiz = new HelperBiz();
        IFoodCategory courseService = new FoodCategoryService();
       
        // show danh sách
        [Route("GetFC")]
        [HttpGet]
        public IHttpActionResult GetCourse()
        {
            var data = courseService.GetFoodCategory();
            var eventList = (from e in data
                             select new
                             {
                                 id = e.id_FC,
                                 name = e.name_FC,
                             }).ToList();
            return Ok(eventList);
        }

        // thêm FoodCategory
        [Route("AddFC")]
        [HttpPost]
        public IHttpActionResult Add(FoodCategory fc)
        {
            courseService.Add(fc);
            return Ok("Ok");
        }

        // sửa FoodCategory
        [Route("EditFC")]
        [HttpPost]
        public IHttpActionResult Update(int id, FoodCategory fc)
        {
            courseService.Update(id, fc);
            return Ok("Ok");
        }

        //xóa FoodCategory
        [Route("DeleteFC")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            courseService.Delete(id);
            return Ok("Ok");
        }

        // Tìm kiếm FoodCategory
        [Route("FindFC")]
        [HttpGet]
        public IHttpActionResult Find(int id)
        {
            var data = courseService.Find(id);
            return Ok(data);
        }
    }
}

