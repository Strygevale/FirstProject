using System.Web.Mvc;
using Calculator.TwoArguments;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multiply", Text ="multiply"
                },
                new SelectListItem()
                {
                    Value = "substraction", Text ="substraction"
                },
                new SelectListItem()
                {
                    Value = "minus", Text ="minus"
                },
                new SelectListItem()
                {
                    Value = "divide", Text ="divide"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            Calculator.TwoArguments.ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multiply", Text ="multiply"
                },
                new SelectListItem()
                {
                    Value = "addition", Text ="addition"
                },
                new SelectListItem()
                {
                    Value = "substraction", Text ="substraction"
                },
                new SelectListItem()
                {
                    Value = "divide", Text ="divide"
                }
            };
            return View();
        }
    }
}