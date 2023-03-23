using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace FormationAspMvcApp.Controllers
{
    public class ResponseHeaderAttributecs: ActionFilterAttribute
    {


        private readonly string _name;
        private readonly string _value;
        private readonly Stopwatch _stopwatch;



        public ResponseHeaderAttributecs(string name, string value)
        {
            _name = name;
            _value = value;
            _stopwatch = new Stopwatch();
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Start();
            base.OnActionExecuted(context);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch.Stop();
            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {





            context.HttpContext.Response.Headers.Add(_name, _value);




            var responseTime = _stopwatch.ElapsedMilliseconds;



            context.HttpContext.Response.Headers.Add("Response-Time", responseTime.ToString());



            base.OnResultExecuting(context);
        }


        //private readonly string _name;
        //private readonly string _value;

        //public DateTime startDate { get; set; }

        //public DateTime endDate { get; set; }


        //public ResponseHeaderAttributecs(string name, string value)=>(_name, _value) = (name, value);

        //public ResponseHeaderAttributecs() { }

        //public override void OnActionExecuting(ActionExecutingContext context)
        //{

        //    startDate = DateTime.Now;

        //    //base.OnActionExecuting(context);
        //}

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    //base.OnActionExecuted(context);
        //}

        //public override void OnResultExecuted(ResultExecutedContext context)
        //{

        //    endDate = DateTime.Now;


        //    context.HttpContext.Response.Headers.Add(_name, _value);


        //    base.OnResultExecuted(context);
        //}



    }
}
