using System.Linq;
using static Task_Day_4__Liberary_Mannagment_System_.Program;
using System.Collections.Generic;

namespace Task_Day_4__Liberary_Mannagment_System_
{
    internal class Program
    {
        public class Book
        {
            string Title;
            string Author;
            string ISBN;
            bool Availability = true;

            public Book(string title, string author, string iSBN, bool availability = true )
            {
                Title = title;
                Author = author;
                ISBN = iSBN;
                Availability = availability;
            }
            public Book()
            {

            }
            public void Set_Title (string title)
            {
                title = Title;
            }
            public void Set_Author (string author)
            {
                author = Author;
            }
            public void Set_ISBN (string iSBN)
            {
                iSBN = ISBN;
            }
            public void Set_Availanility (bool availability)
            {
                Availability = availability;
            }
            public string Get_Title ()
            {
                return Title;
            }
            public string Get_Author ()
            {
                return Author;
            }
            public string Get_ISBN ()
            {
                return ISBN;
            }
            public bool Get_Availability ()
            {

                return Availability; 

            }

        }
        public class Liberary
        {
            List<Book> Liberary_Books = new List<Book> ();

            public Liberary(List<Book> liberary_Books)
            {
                Liberary_Books = liberary_Books;
            }
            public Liberary()
            {

            }

            public void Add_Book (Book book)
            {
                
                Liberary_Books.Add(book);
                Console.WriteLine($"The book {book.Get_Title()} Added to the liberary !!!");
            }

            public void Search_Book (string SearchForBook)
            {
                bool Found = true;


                foreach (Book book_search in Liberary_Books)
                {
                    if (book_search.Get_Title().ToLower().Contains(SearchForBook.ToLower())|| book_search.Get_Author().ToLower().Contains(SearchForBook.ToLower()))
                    {
                        Console.WriteLine($"Book Found: {book_search.Get_Title()}, Author: {book_search.Get_Author()}, ISBN: {book_search.Get_ISBN()}, Available: {book_search.Get_Availability()}");
                        Found =false;
                        break;
                    }
                    
                }
                if (Found)
                {
                    Console.WriteLine("Book Not Found !!");
                }
            }
            public void Borrow_Book (string check_borrowing)
            {
                bool Availability = true;

                foreach (Book book_Borrowing in Liberary_Books)
                {
                    if (book_Borrowing.Get_Title().ToLower().Contains(check_borrowing.ToLower()) || book_Borrowing.Get_Author().ToLower().Contains(check_borrowing.ToLower()))
                    {
                        Console.WriteLine($"Borrowed: {book_Borrowing.Get_Title()}");
                        Availability = false;
                        break;
                    }

                }
                if (Availability)
                {
                    Console.WriteLine("Cannot borrow this book .");
                }
                
               
            }
            public void Return_Book (string check_Returning)
            {
                bool Availability = true;
                foreach (Book book_Returning in Liberary_Books)
                {
                    if (book_Returning.Get_Title().ToLower().Contains(check_Returning.ToLower()) || book_Returning.Get_Author().ToLower().Contains(check_Returning.ToLower()))
                    {
                        Console.WriteLine($"You have returned: {book_Returning.Get_Title()}");
                        Availability = false;
                        break;
                    }

                }
                if (Availability)
                {
                    Console.WriteLine("This book was not borrowing .");
                }
            }
            
        }
        static void Main(string[] args)
            {
            Liberary L1 = new Liberary();
            Console.WriteLine("***************** Adding Book ***********************");
            L1.Add_Book (new Book("1919","Mohamed Naguib","365968999"));
            L1.Add_Book(new Book("The Great Gatsby", "F. Scott Fitzgerald", "123456789"));
            L1.Add_Book(new Book("Journy to the center of the earth", "charless deken", "987654321"));

            Console.WriteLine("***************** Searching for Book ***********************");
            L1.Search_Book("Gatsby");
            L1.Search_Book("1984");
            L1.Search_Book("charless deken");

            Console.WriteLine("***************** Borrowing A Book ***********************");
            L1.Borrow_Book("Gatsby");
            L1.Borrow_Book("Journy to the center of the earth");
            L1.Borrow_Book("harry potter");

            Console.WriteLine("***************** Returning A Book ***********************");
            L1.Return_Book("Gatsby");
            L1.Return_Book("Journy to the center of the earth");
            L1.Return_Book("harry potter");
        }
    }
}
