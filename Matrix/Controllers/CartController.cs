using BLL.INTERFACES;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Matrix.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        ICART cartInterface;

        public CartController(ICART _cartInterface)
        {
            cartInterface = _cartInterface;
        }

        public IActionResult GetAll(string? id)
        {
            id = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var cartitems = cartInterface.GstAll(id);
            ViewBag.SUM = cartInterface.SUM();
            return View(cartitems);
        }

        public IActionResult Remove(int id)
        {
            cartInterface.DeleteItem(id);
            return RedirectToAction("GetAll");
        }
        public IActionResult Increaseitem(int id)
        {
            cartInterface.increaseitem(id);
            return RedirectToAction("GetAll");
        }
        public IActionResult minusitem(int id)
        {
            cartInterface.munisitem(id);
            return RedirectToAction("GetAll");
        }
        public IActionResult CheckOut(decimal Total, int Quantity, string Id)
        {
            cartInterface.DeleteAllItems(Total, Quantity, Id);
            return RedirectToAction("GetAll", "Product");
        }
    }
}
