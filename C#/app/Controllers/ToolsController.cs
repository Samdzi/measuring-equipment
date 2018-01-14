using app.Services;
using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web;

namespace app.Controllers
{
    public class ToolsController : ApiController
    {
        private ToolRepository toolRepository;

        public ToolsController()
        {
            this.toolRepository = new ToolRepository();
        }
        public Tool[] Get()
        {
            return this.toolRepository.GetAllTools();
        }
        //public HttpResponseMessage Post(Tool tool)
        //{
        //    this.toolRepository.SaveTool(tool);

        //    var response = Request.CreateResponse<Tool>(System.Net.HttpStatusCode.Created, tool);

        //    return response;
        //}

    }
    //public class ToolController : Controller
    //{
    //    public ActionResult Index()
    //    {
    //        ViewBag.Title = "Tools";

    //        return View();
    //    }
    //}
    public class ToolController : Controller
    {
        private ToolRepository toolRepository2;
        public ToolController()
        {
            this.toolRepository2 = new ToolRepository();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Tools";

            return View();
        }
    }
}
