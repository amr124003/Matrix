using DAL.CONTEXT;
using DAL.ENTITIES;
using BLL.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.REPOSITORY
{
    public class CartRepo : ICART
    {
        ApplicationDBcontext context;
        public static int count = 0;
        public CartRepo(ApplicationDBcontext _context)
        {
            context = _context;

        }

        public void AddToCart(
            int ProId, string ProName, string ProImage, decimal Proprice, string Prosection, string id)
        {
            CartItem cartItem = new();
            cartItem.ProId = ProId;
            cartItem.Name = ProName;
            cartItem.Image = ProImage;
            cartItem.Price = Proprice;
            cartItem.Section = Prosection;
            cartItem.UserId = id;
            cartItem.Quantity++;

            CartItem newcart = context.cartItems.FirstOrDefault(x => x.ProId == cartItem.ProId);

            if (newcart != null)
            {
                context.cartItems.FirstOrDefault(x => x.ProId == cartItem.ProId).Quantity++;
                context.SaveChanges();
            }
            else if (newcart == null)
            {
                context.cartItems.Add(cartItem);
                context.SaveChanges();
            }


        }



        public void DeleteItem(int Id)
        {
            var cartItem = context.cartItems.FirstOrDefault(x => x.Id == Id);
            context.cartItems.Remove(cartItem);
            context.SaveChanges();
        }
        public List<CartItem> GstAll(string id)
        {
            var res = context.cartItems.Where(x => x.UserId == id).ToList();
            count = res.Count;
            return res;
        }

        public void increaseitem(int id)
        {
            var item = context.cartItems.FirstOrDefault(x => x.Id == id);
            item.Quantity++;
            context.SaveChanges();
        }

        public void munisitem(int id)
        {
            var item = context.cartItems.FirstOrDefault(x => x.Id == id);
            if (item?.Quantity > 1)
            {
                item.Quantity--;
            }
            context.SaveChanges();
        }
        public void DeleteAllItems(decimal Total, int Qunatity, string id)
        {
            Order order = new();
            order.UserId = id;
            order.TotalPrice = Total;
            order.Qunatity = Qunatity;
            context.SaveChanges();

            var Deleted = context.cartItems.Where(x => x.UserId == id);
            context.cartItems.RemoveRange(Deleted);
            context.SaveChanges();
        }

        public int CartCount(string UserId)
        {
            return context.cartItems.Count(x => x.UserId == UserId);
        }

        public int SUM()
        {
           return context.cartItems.Sum(x => x.Quantity);
        }
    }
}
