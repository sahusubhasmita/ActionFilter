
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;
using System.IO;

namespace NewEmployee.ActionFilter
{
    public class StudentFilter: ActionFilterAttribute
    {
        //
        // Summary:
        //     Called by the ASP.NET MVC framework after the action method executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);

        }

        //
        // Summary:
        //     Called by the ASP.NET MVC framework before the action method executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }
        //
        // Summary:
        //     Called by the ASP.NET MVC framework after the action result executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }
        //
        // Summary:
        //     Called by the ASP.NET MVC framework before the action result executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }

        private FileStream FileOpen(string v, FileMode append, FileAccess write)
        {
            throw new NotImplementedException();
        }
        private void Log(string method, RouteData routeData)
        {
            
            
            
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("{0} = {1} -> {2}", method, controllerName, actionName);
            Debug.WriteLine(message);
            //FileStream fileStream = FileOpen("C:\\Logs\\TestLogs.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter fileWriter = new StreamWriter(fileStream);
            //fileWriter.WriteLine(message);
            //fileWriter.Flush();
            //fileWriter.Close();
            FileStream fileStream = File.Open("C:\\Logs\\Log.txt", FileMode.Append, FileAccess.Write);
            // Encapsulate the filestream object in a StreamWriter instance.
            StreamWriter fileWriter = new StreamWriter(fileStream);
            // Write the current date time to the file
            fileWriter.WriteLine(message);
            fileWriter.Flush();
        }

    
    }
}