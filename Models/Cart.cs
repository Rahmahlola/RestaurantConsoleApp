namespace RestaurantApp.Models
{
    public class Cart
    {
        public  string CustomerEmail;
        public string ProductName;
        public decimal Price;
        public int Quantity;

        public Cart(string customerEmail,string productName,decimal price,int quantity)
        {
            CustomerEmail= customerEmail;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

    }
}