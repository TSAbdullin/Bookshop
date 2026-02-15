namespace Bookshop.Classes
{
    public class Book
    {
        private static long _idCounter = 1;
        public long Id { get; }
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public long GenreId { get; set; }
        public bool HasDiscount { get; set; }
        public string GenreName => Library.GetGenreName(GenreId);
        public string AuthorName => Library.GetAuthorName(AuthorId);

        public Book(long Id, string Title,  long AuthorId, long GenreId, bool HasDiscount)
        {
            this.Id = Id;
            _idCounter = Id + 1; // предположим, что в файле все гарантированно отсортированно по ID)
            this.Title = Title;
            this.AuthorId = AuthorId;
            this.GenreId = GenreId;
            this.HasDiscount = HasDiscount;
        }

        public Book(string Title, long AuthorId, long GenreId, bool HasDiscount)
        {
            this.Title = Title;
            this.AuthorId = AuthorId;
            this.GenreId = GenreId;
            this.HasDiscount = HasDiscount;
            Id = _idCounter++;
        }

        public override string ToString()
        {
            return $"{Title} - {AuthorId}";
        }
    }
}