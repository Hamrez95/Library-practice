namespace Library_practice
{

    public class NonFictionBook : Book
    {
        #region Properties
        public string Topic { get; set; }
        public int Pages { get; set; }
        #endregion
        public NonFictionBook(string Title, string Author, string Genre)
        {
            
        }

        public override void DisplayBookInfo()
        {
            Console.WriteLine($"Non-Fiction Book - {Title} by {Author} (Genre: {Genre})");
        }
    }


}