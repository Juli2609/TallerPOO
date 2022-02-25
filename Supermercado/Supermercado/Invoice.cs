namespace Supermercado
{
    public class Invoice : IPay
    {
        public Invoice(){}

       private List<Product> products1 = new List<Product>();
        public decimal ValueToPay()
        {
            decimal AccumulatorProducts = 0;
            foreach (Product item in products1)
            {
                AccumulatorProducts += item.ValueToPay();
            }
            return AccumulatorProducts;      
        }
        public override string ToString()
        {
            foreach (Product item in products1)
            {
                Console.WriteLine(item.ToString());
            }

            return $"                    ================== " +
                   $"\nTOTAL:              {$"{ValueToPay():C2}",18}";      
        }
        public void AddProduct(Product product1)
        {
           products1.Add(product1);
        }
    }
    }

