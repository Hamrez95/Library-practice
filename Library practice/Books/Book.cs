namespace Library_practice
{
    //کتاب یک انتزاع کلی است . انواع مختلفی از کتاب داریم . پس بهتر از از نوع ابسترکت تعریف شود 
    // با اینکار انواع کتاب ها از این کلاس ارث بری میکنند و متد های این کلاس را با اورراید کردن پیاده سازی میکنند 
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime DueDate { get; set; }

        public abstract void DisplayBookInfo();
        
    }

}