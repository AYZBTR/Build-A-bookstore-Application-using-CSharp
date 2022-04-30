# Build-A-bookstore-Application-using-CSharp

Originally, you have type List<T> generic collection instance. Collection objects are of type Book.
    
    List<Book> books = new List<Book>()
    {
    
    
    new Book("The Miserable Ones", 23.85),
    new Book("East of Eden", 31.10),
    new Book("Anna Karenina", 31.45),
    new Book("Bury My Heart at Wounded Knee", 25.80),
    new Book("Nana", 27.35),
    new Book("Crime and Punishment", 26.55),
    new Book("The Mother", 34.75),
    new Book("Found", 10.90),
    new Book("The Story of My Life", 18.60),
    new Book("The Complete Chronicles of Narnia", 44.65),
    new Book("Till We Have Faces", 14.95),
    new Book("The Lord of the Rings", 32.95),
    new Book("Pride and Prejudice", 24.15),
    new Book("A Farewell to Arms", 28.70),
    new Book("Harry Potter and the Order of the Phoenix", 33.25),
    new Book("The Catcher in the Rye", 17.65),
    new Book("Paradise Lost", 32.50),
    new Book("To Kill a Mockingbird", 20.95),
    new Book("In Search of Lost Time", 23.15),
    new Book("And Then There Were None", 13.35),
    new Book("The Name of the Rose", 25.55),
    new Book("Death of a Salesman", 29.90),
    new Book("Don Quixote", 18.85),
    new Book("Hamlet", 27.35),
    new Book("The Purpose Driven Life", 33.75),
    new Book("War and Peace", 30.55),
    new Book("The five love languages", 13.70),
    new Book("The Brothers Karamazov", 33.35),
    new Book("Wuthering Heights", 27.75),
    new Book("Little Women", 19.85),
    new Book("The Trial", 37.05),
    new Book("The Grapes of Wrath", 29.95),
    new Book("Great Expectations", 22.25),
    new Book("Dead Souls", 17.45),
    new Book("For Whom the Bells Tolls", 31.25),
    new Book("Vanity Fair", 22.95),
    new Book("The Old Man and the Sea", 29.65),
    new Book("The Tin Drum", 16.65),
    new Book("Les Miserables", 24.40),
    new Book("Wall Street Coyotes, part 1", 23.80),
    new Book("Wall Street Coyotes, part 2", 24.70),
    new Book("Wall Street Coyotes, part 3", 25.60),
    new Book("Fire and Fury", 30.00),
    new Book("The Woman in the Window", 21.20),
    new Book("A Higher Loyalty: Truth, Lies, and Leadership", 19.45),	
};

class Book
    
{
    
    public Book(string name, double price)
    {
        Name = name;
    
        Price = price;
    }
    
    public string Name { get; set; }
    
    public double Price { get; set; }
}
    
    
    
    
    
 1. Build a bookstore application. It is possible to choose from one to several books. 
Implement two instance methods:
    
public List<Book> BuyABook(List<Book> thoseBooks)
    
public double CalcTotalPrice(List<Book> thoseBooks)

    
The previous method allows the user of your program to select from one to many books to purchase.
With the latter method, your program will be able to calculate the total amount of purchases.
The book is selected by entering part of the book title as a keyword. It is therefore possible that more than one book will be found for the selected keyword (see example on the next page) or nothing will be found.
Feel free to choose whether you want to place instance methods in the Book class or whether you want to inherit a separate class, for example class Bookstore. 

