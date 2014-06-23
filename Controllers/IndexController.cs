using MVCSandbox.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCSandbox.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index ()
        {
            // Create the list
            List<IndexModel> newList = new List<IndexModel>();

            // Create the first item within the list
            IndexModel newIndexModel = new IndexModel
            {
                ID = 1,
                Description = "First Item",
                Comments = "This is the first instance of the model"
            };


            // test

            // Create the second item within the list
            IndexModel newIndexModel2 = new IndexModel
            {
                ID = 2,
                Description = "Second Item",
                Comments = "This is the second instance of the model"
            };

            // Add the items to the list
            newList.Add(newIndexModel);
            newList.Add(newIndexModel2);

            // Send the model to the view
            return View(newList);
        }

        public ActionResult Edit ()
        {
            return View();
        }
    }
}