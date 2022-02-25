namespace Supermercado
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}"+
            $" \n\tValue......: {$"{ValueToPay():C2}", 17}"; 
        }
    }
}
