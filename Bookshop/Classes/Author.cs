namespace Bookshop.Classes
{
    internal class Author
    {
        public long Id { get; }
        private static long IdCounter = 1;
        public string Name { get; set; }
    }
}