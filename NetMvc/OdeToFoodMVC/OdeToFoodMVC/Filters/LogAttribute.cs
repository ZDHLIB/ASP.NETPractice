using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace OdeToFoodMVC.Filters {
    public class LogAttribute : ActionFilterAttribute {
        //Execute before action
        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            base.OnActionExecuting(filterContext);
        }
        //Execute after action
        public override void OnActionExecuted(ActionExecutedContext filterContext) {
            base.OnActionExecuted(filterContext);
        }
        // Execute before return result
        public override void OnResultExecuting(ResultExecutingContext filterContext) {
            base.OnResultExecuting(filterContext);
        }
        // Execute after return result
        public override void OnResultExecuted(ResultExecutedContext filterContext) {
            base.OnResultExecuted(filterContext);
        }
    }
}