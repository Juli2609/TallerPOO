namespace Supermercado
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }


        public override string ToString()
        {
            List<String> products1 = new List<String>();

            foreach (Product product in Products)
            {
                products1.Add(product.Description);  
            }
                return $" {Id}   {Description}" +
                $"\n\tProducts...: {$"{String.Join(",",products1)}",17}" +
                $"\n\tDiscount...: {$"{Discount:P2}",17}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",17}";
        }

        public override decimal ValueToPay()
        {
            decimal AccumulatorProducts = 0;
            decimal DiscountProduct;
            
            foreach (Product product in Products )
            {
                AccumulatorProducts += product.ValueToPay();
            }
            DiscountProduct = AccumulatorProducts * (decimal)Discount;

            return AccumulatorProducts - DiscountProduct;
        }
    }
}
