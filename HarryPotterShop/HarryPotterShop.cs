namespace HarryPotterShop
{
    public static class HarryPotterShop
    {
        private const decimal BookPrice = 8m;
        private static readonly Dictionary<int, decimal> _discounts = new Dictionary<int, decimal>()
        {
            { 1, 0m },
            { 2, 0.05m },
            { 3, 0.1m },
            { 4, 0.2m },
            { 5, 0.25m },
        };

        public static decimal CalculateTotal(IEnumerable<Book> books) => throw new NotImplementedException();
    }
}