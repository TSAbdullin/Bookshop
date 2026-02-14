namespace Bookshop.Classes
{
    internal class Book
    {
        private static long _idCounter = 1;
        public long Id { get; }
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public long GenreId { get; set; }
        public bool HasDiscount { get; set; }

        public Book(long Id, string Title,  long AuthorId, long GenreId, bool HasDiscount)
        {
            this.Id = Id;
            _idCounter = Id + 1;
            this.Title = Title;
            this.AuthorId = AuthorId;
            this.GenreId = GenreId;
            this.HasDiscount = HasDiscount;
        }

        public Book()
        {
            Id = _idCounter++;
        }

        public override string ToString()
        {
            return $"{Title} - {AuthorId}";
        }
    }
}