namespace PCStore.Classes
{
    public static class Extensions
    {
        public static string PriceWithCurrency(this double price, string currency)
        {
            return $"{price} {currency}";
        }
    }
}
