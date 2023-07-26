using System.Threading.Channels;
using Library_practice.Customers;

namespace Library_practice.LibraryMethods
{

    public class Library : ILibrary
    {
        
        #region Books & Customers Add & Remove Impelimentations
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }
        #endregion
        
        #region Borrow & Return Impelimentations
        public void BorrowBook(Book book, Customer customer, DateTime dueDate)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                book.DueDate = dueDate;
            }
            else
            {
                Console.WriteLine("Sorry, the book is currently not available");
            }
        }
        public void ReturnBook(Book book, Customer customer)
        {
            if (!book.IsAvailable)
            {
                book.IsAvailable = true;
                book.DueDate = DateTime.Now;
            }
            else
            {
                Console.WriteLine("The book is already returned, but you always can donate books to us :)");
            }
        }
        #endregion

        public Library()
        {
            books = new List<Book>();
            Customers = new List<Customer>();
        }
        public List<Book> books;
        public List<Customer> Customers;

        //پیاده سازی جستجو برای کتاب های موجود 
        public List<Book> GetAvailableBooks()
        {
            return books;
            //throw new NotImplementedException();
        }
    }


}