using System.Text.RegularExpressions;

namespace PracticalProgram
{

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, int pages, string genre, string publisher, string isbn)
        {
            Title = ValidateNonEmpty(title, "Title");
            Author = ValidateNonEmpty(author, "Author");
            Pages = ValidatePositiveInteger(pages, "Pages");
            Genre = ValidateNonEmpty(genre, "Genre");
            Publisher = ValidateNonEmpty(publisher, "Publisher");
            ISBN = ValidateISBN(isbn);

        }

        private string ValidateNonEmpty(string value, string fieldName)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{fieldName} cannot be empty or null.");
            }
            return value;
        }
        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPages: {Pages}\nGenre: {Genre}\nPublisher: {Publisher}\nISBN: {ISBN}";
        }

        private int ValidatePositiveInteger(int value, string fieldName)
        {
            if(value <= 0)
            {
                throw new ArgumentException($"{fieldName} cannot be less than 0");
            }
            return (int)value;
        }

        private string ValidateISBN(string value)
        {
            string isbnPattern = @"^(97(8|9))?\d{9}(\d|X)$";
            if (!Regex.IsMatch(value, isbnPattern))
            {
                throw new ArgumentException("Invalid ISBN format.");
            }
            return value;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER BOOK DETAILS");

            Console.Write("Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            
        }
    }

    class Stundent
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Stundent(string name, int grade) 
        {
            Name = name;
            Grade = grade;
        
        }
        

    }
}
