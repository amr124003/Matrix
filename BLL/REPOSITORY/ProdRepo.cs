using BLL.INTERFACES;
using DAL.CONTEXT;
using DAL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.REPOSITORY
{
    public class ProdRepo : IPRODUCT
    {
        ApplicationDBcontext context;
        public ProdRepo(ApplicationDBcontext _context)
        {
            context = _context;
        }
        public List<Product> AllProducts()
        {
            List<Product> Products = context.Products.ToList();
            return Products;
        }

        public Product GetProduct(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }


        public void EditProduct(Product product)
        {
            var oldproduct = context.Products.FirstOrDefault(x => x.Id == product.Id);
            oldproduct.Name = product.Name;
            oldproduct.Price = product.Price;
            oldproduct.Image = product.Image;
            context.SaveChanges();
        }
        public void DeleteProduct(Product prod)
        {
            Product deleted = context.Products.FirstOrDefault(x => x.Id == prod.Id);
            context.Products.Remove(deleted);
            context.SaveChanges();
        }


        public void AddProduct(Product product)
        {
            Product prod = new();
            prod.Name = product.Name;
            prod.Price = product.Price;
            prod.Section = product.Section;
            prod.Image = product.Image;
            context.Products.Add(prod);

            context.SaveChanges();

        }
        public int GetId(Product productvm)
        {
            var res = context.Products.FirstOrDefault(x => x.Name == productvm.Name && x.Section == productvm.Section);
            return res.Id;
        }
        public List<Product> GetLaptops()
        {
            var Laptops = context.Products.Where(x => x.Section == "Laptop").ToList();
            return Laptops;
        }
        public List<Product> GetHeadphones()
        {
            var Headphones = context.Products.Where(x => x.Section == "HeadPhone").ToList();
            return Headphones;
        }
        public List<Product> GetCameras()
        {
            var Cameras = context.Products.Where(x => x.Section == "Camera").ToList();
            return Cameras;
        }
        public List<Product> GetPhones()
        {
            var Phones = context.Products.Where(x => x.Section == "Phone").ToList();
            return Phones;
        }

        public Product GetProductByName(string Name)
        {
            var product = context.Products.FirstOrDefault(x => x.Name == Name);
            return product;
        }

        public List<Product> GetNew()
        {
            return context.Products.Where(x => x.Status == "New").ToList();
        }

        public List<Product> GetTop()
        {
            return context.Products.Where(x => x.Status == "TopSelling").ToList();
        }
    }
}
