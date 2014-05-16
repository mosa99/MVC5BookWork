using System.Web.Mvc;
using System.Linq;
using System.Web;

using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;


namespace SportsStore.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        private IProductRepository repository;
        
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        
        public ViewResult Index()
        {
            return View(repository.Products);
        }//public ViewResult Index()

        public ViewResult Edit(int productId)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            return View(product);
        }//public ViewResult Edit(int productId)

        [HttpPost]
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(product.ImageData, 0, image.ContentLength);
                }
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {// there is something wrong with the data values
                return View(product);
            }
        }//public ActionResult Edit(Product product)

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }//public ViewResult Create()

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted",
                deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }//public ActionResult Delete(int productId)

    }//public class AdminController : Controller
}