using DAL.ENTITIES;


namespace BLL.INTERFACES
{
    public interface ICART
    {
        public void AddToCart(
           int ProId, string ProName, string ProImage, decimal Proprice, string Prosection, string id);
        public void DeleteItem(int Id);
        public List<CartItem> GstAll(string? id);

        public int SUM();

        public void increaseitem(int id);

        public void munisitem(int id);
        public void DeleteAllItems(decimal Total, int Qunatity, string id);
        public int CartCount(string? UserId);

    }
}
