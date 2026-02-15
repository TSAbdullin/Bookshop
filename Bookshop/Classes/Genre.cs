namespace Bookshop.Classes
{
    public class Genre
    {
        public long Id { get; }
        private static long _idCounter = 1;
        public string Name { get; set; }

        public Genre(long Id, string Name)
        {
            this.Id = Id;
            _idCounter = _idCounter + 1; // предположим, что в файле все гарантированно отсортированно по ID)
            this.Name = Name;
        }
    }
}