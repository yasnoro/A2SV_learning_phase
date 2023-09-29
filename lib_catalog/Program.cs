// See https://aka.ms/new-console-template for more information
using System;

public class Library
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }
    public List<MediaItem> MediaItems { get; set; }

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void AddMediaItem(MediaItem item)
    {
        MediaItems.Add(item);
    }

    public void RemoveMediaItem(MediaItem item)
    {
        MediaItems.Remove(item);
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Publication Year: {book.PublicationYear}");
        }

        Console.WriteLine("Media Items:");
        foreach (var item in MediaItems)
        {
            Console.WriteLine($"Title: {item.Title}, Type: {item.MediaType}, Duration: {item.Duration} minutes");
        }
    }

     public List<Book> SearchBooks(string keyword)
    {
        return Books.Where(book => book.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                   book.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                   book.ISBN.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<MediaItem> SearchMediaItems(string keyword)
    {
        return MediaItems.Where(item => item.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                        item.MediaType.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
}

public class MediaItem
{
    public string Title { get; set; }
    public string MediaType { get; set; }
    public int Duration { get; set; }

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library("My Library", "123 yasin");

        Book book1 = new Book("Book 1", "Author 1", "ISBN1", 2020);
        Book book2 = new Book("Book 2", "Author 2", "ISBN2", 2019);

        MediaItem mediaItem1 = new MediaItem("Media Item 1", "DVD", 120);
        MediaItem mediaItem2 = new MediaItem("Media Item 2", "CD", 60);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddMediaItem(mediaItem1);
        library.AddMediaItem(mediaItem2);

        library.PrintCatalog();

        Console.WriteLine("Enter a keyword to search for books or media items: ");
        string keyword = Console.ReadLine();

        List<Book> foundBooks = library.SearchBooks(keyword);
        List<MediaItem> foundMediaItems = library.SearchMediaItems(keyword);

        if (foundBooks.Count > 0) 
        {
                Console.WriteLine("Search Results:");
                Console.WriteLine("Books:");
            foreach (var book in foundBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Publication Year: {book.PublicationYear}");
            }

            
        }

        else if (foundMediaItems.Count > 0)
        {
            Console.WriteLine("Search Results:");
            Console.WriteLine("Media Items:");
            foreach (var item in foundMediaItems)
            {
                Console.WriteLine($"Title: {item.Title}, Type: {item.MediaType}, Duration: {item.Duration} minutes");
            }
        }

        else
        {
            Console.WriteLine("the search item is not found");
        }

    }
}

