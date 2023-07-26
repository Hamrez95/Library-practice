using System.Diagnostics;

namespace Library_practice
{

    public class FictionBook : Book
    {
        #region Properties
        public string MainCharacter { get; set; }
        public int Pages { get; set; }
        #endregion
        public FictionBook(string Title, string Author, string Genre)
        {
            
        }

        public override void DisplayBookInfo()
        {
            Console.WriteLine($"Fiction Book - {Title} by {Author} (Genre: {Genre})");
        }

    }


}