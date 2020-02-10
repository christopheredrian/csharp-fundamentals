namespace AdvancedRef.Lambda
{
    public class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}. Price: {Price}";
        }
    }
}
