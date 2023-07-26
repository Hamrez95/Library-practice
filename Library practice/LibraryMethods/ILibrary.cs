using Library_practice.Customers;

namespace Library_practice.LibraryMethods
{

    public interface ILibrary
    {
        #region Books & Customers Add & Remove Methods
        void AddBook(Book book);
        void RemoveBook(Book book);
        void AddCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
        #endregion

        #region Borrow & Return Methods
        void BorrowBook(Book book, Customer customer, DateTime dueDate);
        void ReturnBook(Book book, Customer customer);
        #endregion

        //جستجو برای کتاب های موجود 
        List<Book> GetAvailableBooks();
        
    }


}