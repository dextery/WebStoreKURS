namespace DataAccess.Entities
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Parts part { get; set; }
        public uint price { get; set; }
        public string ShopCartId { get; set; }
    }
}
