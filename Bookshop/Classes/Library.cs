using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace Bookshop.Classes
{
    public class Library
    {
        public static BindingList<Book> books {  get; set; } = new BindingList<Book>();
        public static Dictionary<long, Genre> genresById { get; set; } = new Dictionary<long, Genre>();
        public static Dictionary<long, Author> authorsById { get; set; } = new Dictionary<long, Author>();

        /// <summary>
        /// Метод, который позволяет создать книгу
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="genre"></param>
        /// <param name="hasDiscount"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AddBook(string title, long authorId, long genreId, bool hasDiscount)
        {
            if (!genresById.ContainsKey(genreId))
            {
                throw new ArgumentException("Такого жанра не существует!");
            }

            if (!authorsById.ContainsKey(authorId))
            {
                throw new ArgumentException("Такого автора не существует!");
            }

            books.Add(new Book(title, authorId, genreId, hasDiscount));
        }

        /// <summary>
        /// Метод, который позволяет удалять книгу 
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public static bool DeleteBook(long idBook)
        {
            var book = books.FirstOrDefault(b => b.Id == idBook);
            if (book == null) { return false; }

            books.Remove(book);
            return true;
        }

        /// <summary>
        /// Метод, который подгружает все книги из файла
        /// </summary>
        /// <param name="pathToBooks"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadBooks(string pathToBooks) // Сложность O(N)
        {
            if (!File.Exists(pathToBooks))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesBooks = File.ReadAllLines(pathToBooks);

            /*
             Поскольку в названии книг обычно не ставятся точки
            было принято решение сделать разделение через Split по точке, 
            тем самым разделить ID книги и информацию о книге
             */

            for (int i = 0; i < linesBooks.Length; i++) 
            {
                string[] parts = linesBooks[i].Split('.'); 
                string[] partsData = parts[1].Split(',');
                string title = partsData[0].Trim();

                #region Проверка на возможность запарсить данные из файла
                if (!long.TryParse(partsData[1].Trim(), out long authorId)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID автора, при загрузке книг"); 
                }

                if (!long.TryParse(partsData[2].Trim(), out long genreId)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID жанра, при загрузке книг"); 
                }

                if (!bool.TryParse(partsData[3].Trim(), out bool hasDiscount)) 
                { 
                    throw new ArgumentException("Не удалось запарсить наличие скидки, при загрузке книг"); 
                }

                if (!long.TryParse(parts[0].Trim(), out long id)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID книги"); 
                }
                #endregion

                books.Add(new Book(id, title, authorId, genreId, hasDiscount));
            }
        }

        /// <summary>
        /// Метод, который подгружает жанры из файла
        /// </summary>
        /// <param name="pathToGenres"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadGenres(string pathToGenres) // Сложность O(N)
        {
            if (!File.Exists(pathToGenres))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesGenres = File.ReadAllLines(pathToGenres);


            for (int i = 0; i < linesGenres.Length; i++)
            {
                string[] parts = linesGenres[i].Split('.');
                string title = parts[1].Trim();
                
                if (!long.TryParse(parts[0], out long genreId))
                {
                    throw new ArgumentException("Не удалось запарсить ID жанра, при загрузке жанров");
                }
                
                genresById.Add(genreId, new Genre(genreId, title));
            }
        }

        /// <summary>
        /// Метод, который подгружает авторов из файла
        /// </summary>
        /// <param name="pathToAuthors"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadAuthors(string pathToAuthors) // Сложность O(N)
        {
            if (!File.Exists(pathToAuthors))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesAuthors = File.ReadAllLines(pathToAuthors);

            for (int i = 0; i < linesAuthors.Length; i++)
            {
                string[] parts = linesAuthors[i].Split('.');
                string name = parts[1].Trim();

                if (!long.TryParse(parts[0], out long authorId))
                {
                    throw new ArgumentException("Не удалось запарсить ID жанра, при загрузке жанров");
                }

                authorsById.Add(authorId, new Author(authorId, name));
            }
        }

        public static List<Genre> GetGenres()
        {
            return genresById.Values.ToList();
        }

        public static List<Author> GetAuthors()
        {
            return authorsById.Values.ToList();
        }

        /// <summary>
        /// Метод, который позволяет получить название жанра по идентификатору жанра
        /// </summary>
        /// <param name="genreId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetGenreName(long genreId) // O(1)
        {
            if (genresById.TryGetValue(genreId, out var genres))
            {
                return genres.Name;
            }
            else { throw new ArgumentException("Не найден жанр!"); }
        }

        /// <summary>
        /// Метод, который позволяет получить название автора по идентификатору автора
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetAuthorName(long authorId) // O(1)
        {
            if (authorsById.TryGetValue(authorId, out var author))
            {
                return author.Name;
            }
            else { throw new ArgumentException("Не найден автор!"); }
        }

        public static List<Book> SearchBooks(long? id, bool? hasDiscount, string author = null, string title = null, string genre = null)
        {
            bool hasTextFilters =
                !string.IsNullOrWhiteSpace(author) ||
                !string.IsNullOrWhiteSpace(title) ||
                !string.IsNullOrWhiteSpace(genre) ||
                hasDiscount.HasValue;

            if (id.HasValue && !hasTextFilters)
            {
                var book = BinarySearchById(books.ToList(), id.Value);

                if (book != null)
                {
                    return new List<Book> { book };
                }
                else
                {
                    return new List<Book>();
                }
            }

            IEnumerable<Book> result = books;

            if (id.HasValue)
            {
                result = result.Where(x => x.Id == id.Value);
            }

            if (!string.IsNullOrWhiteSpace(author))
            {
                author = author.Trim();
                result = result.Where(x => x.AuthorName.Contains(author));
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                title = title.Trim();
                result = result.Where(x => x.Title.Contains(title));
            }

            if (!string.IsNullOrWhiteSpace(genre))
            {
                genre = genre.Trim();
                result = result.Where(x => x.GenreName.Contains(genre));
            }

            if (hasDiscount.HasValue)
            {
                result = result.Where(x => x.HasDiscount == hasDiscount.Value);
            }

            return result.ToList();
        }

        private static Book BinarySearchById(List<Book> books, long id)
        {
            int left = 0;
            int right = books.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (books[mid].Id == id)
                {
                    return books[mid];
                }

                if (books[mid].Id < id)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }
    }
}