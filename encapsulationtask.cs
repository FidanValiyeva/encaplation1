using static task.Program;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			{
				Library library = new Library();

				Book book1 = new Book(0, 1, 2, "yeraltindan qeydler", "Philosophy");
				Book book2 = new Book(10, 2, 3, "oluler", "Philosophy");
				Book book3 = new Book(12, 3, 4, "çürümenin kitabı", "Philosophy");
				Book book4 = new Book(13, 4, 5, "oxsar", "Fiction");

				book1.ShowInfo();
				book2.ShowInfo();
				book3.ShowInfo();
				book4.ShowInfo();

			}
		}

		public class Product
		{
			public double _price;
			public double _count;
			public double _no;
			public string _name;

			public Product(double price, double count, double no, string name)
			{
				_price = price;
				_count = count;
				_no = no;
				_name = name;
			}
		}
		public double Price
		{

			get
			{
				return Price;
			}

			set
			{
				if (value > 0)
				{

					Price = value;
				}

			}

		}
		public double Count
		{
			get
			{
				return Count;
			}
			set
			{
				if (value > 0)
				{
					Count = value;
				}
			}

		}
		public class Book : Product
		{
			private string _genre;
			public Book(double price, string count, double no, string name, string genre) : base(price, count, no, name)
			{
				_genre = genre;
			}
			public string genre;


			public void ShowInfo()
			{
				Console.WriteLine($"Price: {price},Count: {Count},No: {No},Name: {Name},Genre: {Genre}");
			}
		}
	}
	public class Library
	{
		private Book[] Books = new Book[0];
	

	public void AddBook(Book book)
		{
			Array.Resize(ref Books, Books.Length + 1);
			Books[Books.Length - 1] = book;
		}
	}
	public void GetFilteredBooks(string genre)
	{
		Book foundBooks = new Book[0];
		foreach (var book in Books)
		{
			if (book.Genre == genre)
			{
				Array.Resize(ref foundBooks, foundBooks.Length + 1);

				foundBooks[foundBooks.Length - 1] = book;
				{
					return foundBooks;
				}
			}
		}
		public static Book[] GetFilteredBooks1(int minPrice, int maxPrice)
		{
			foreach (var book in Books) 
			{
				if (maxPrice > Price && Price > minPrice)
				{ 
					return book;
				}

				return book;
			} 


		}
	
	}

}

	

