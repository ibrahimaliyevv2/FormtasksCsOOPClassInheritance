using System;
namespace StoreTask
{
    internal class Product
    {
        public Product(double price)
        {
            this.Price = price;
        }
        public Product(double price, double discountPercent) : this(price)
        {
            this.DiscountedPrice = price * (100 - discountPercent) / 100;
        }

        public string Name;
        public double Price;
        public double DiscountedPrice;
        public string GetInfo()
        {
            return $"Name: {this.Name} - Price: {this.Price} - DiscountedPrice: {this.DiscountedPrice}";
        }
    }
}
