namespace Supermercado
{
    public class VariablePriceProduct : Product
    {
        public String Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
           return (Price * (decimal)Quantity) + ((Price * (decimal)Quantity)* (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tMeasurement: {$"{Measurement}"}" +
                $"\n\tQuantity...: {$"{Quantity:C2}", 17}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",17}";
        }
    }
}
