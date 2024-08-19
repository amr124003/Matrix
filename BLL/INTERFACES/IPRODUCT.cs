using DAL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.INTERFACES
{
    public  interface IPRODUCT
    {
        public Product GetProduct(int id);
        public Product GetProductByName(string Name);
        public void EditProduct(Product product);

        public void AddProduct(Product product);
        public void DeleteProduct(Product prod);
        public List<Product> AllProducts();
        public List<Product> GetLaptops();
        public List<Product> GetHeadphones();
        public List<Product> GetCameras();
        public List<Product> GetPhones();
        public List<Product> GetNew();
        public List<Product> GetTop();
        public int GetId(Product productvm);


    }
}
