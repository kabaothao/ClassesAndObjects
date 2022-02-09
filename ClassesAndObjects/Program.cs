// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace ClassesAndObjects // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //So if I wanted to create an present an actual book inside of my program, since I created that class and I define what a book is. I basically defined the book datatype, i can actually do that.
            //And I can create something called an object. And an object is an instance of a class. 
            //So when we created the class we created the template for what a book is.
            //When we create an object, we're creating an actual physical book inside of our program.
            //When I'm creating an object, the book would have an actual title, actual number of pages, and an actual author. 

            //example
            //specify the book data type.
            //this is how we can create what's called a book object. This is essentially an instance of a book. so this is like a physical book inside of our program. 
            Book book1 = new Book(); //create an object whch is an instance of the book class.
            book1.title = "Harry Potter"; //now i was able to define all of infomation about this book. 
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            //example
            Book book2 = new Book();
            book2.title = "Lord Of the Rings"; //now i was able to define all of infomation about this book. 
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            //example
            Book book3 = new Book();
            book3.title = "The Spirit Catches You and You Fall Down";
            book3.author = "Anne Fadiman";
            book3.pages = 550;

            Console.WriteLine(book3.title);
            Console.WriteLine(book3.author);
            Console.WriteLine(book3.pages);

        }
    }
}

/*
 Topic: What are Classes and Objects?
When we want to create a data type we would create a class. 
A class is basically just a speciication for a new data type. 
So I could create a class for a phone or I could create a class for like a water bottle, or I could create a class for a keyboard etc.
Then I can represent all those different things inside my programs. So classes are basically use to model real world entities inside of our program.
 */