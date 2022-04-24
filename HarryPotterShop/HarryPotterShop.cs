namespace HarryPotterShop
{
    public static class HarryPotterShop
    {
        private const decimal BookPrice = 8m;
        private static readonly Dictionary<int, decimal> _discounts = new Dictionary<int, decimal>()
        {
            { 0, 0m },
            { 1, 0m },
            { 2, 0.05m },
            { 3, 0.1m },
            { 4, 0.2m },
            { 5, 0.25m },
        };

        public static decimal CalculateTotal(IEnumerable<Book> books)
        {
            if (books is null)
                throw new ArgumentNullException(nameof(books));
            if (books.Any(x => x is null))
                throw new ArgumentNullException(nameof(books));
            if (books.Any(x => x.BookPart == default(BookPart)))
                throw new ArgumentException("Unknown book");

            var bookQueue = new Queue<Book>(books);

            var total = 0m;
            while (bookQueue.Any())
            {
                int uniqueBooks = 0;
                for (int i = 0; i < bookQueue.Count(); i++)
                {
                    if (!bookQueue.TryDequeue(out Book book))
                        break;

                    if ((uniqueBooks & (int)book.BookPart) != 0)
                    {
                        bookQueue.Enqueue(book);
                        continue;
                    }

                    uniqueBooks += (int)book.BookPart;
                    --i;
                }

                var discount = 0;
                while (uniqueBooks > 0)
                {
                    discount += uniqueBooks & 1;
                    uniqueBooks >>= 1;
                }

                total += (discount * BookPrice) - (discount * BookPrice * _discounts[discount]);
            }

            return total;
        }
    }
}