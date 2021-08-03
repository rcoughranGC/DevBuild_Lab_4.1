using System;

namespace DevBuild_Lab4_1
{
    class Program
    {

        class Parallelogram
        {
            public double Length;
            public double Width;

            public double GetArea()
            {
                return Length * Width;
            }
            public double GetPerimeter()
            {
                return (Length * 2) + (Width * 2);
            }
            public void Print()
            {
                Console.WriteLine($"Length: {Length}");
                Console.WriteLine($"Width: {Width}");
                Console.WriteLine($"Area: {GetArea()}");
                Console.WriteLine($"Perimeter: {GetPerimeter()}");
            }
            public void Resize(double newLength, double newWidth)
            {

                if (newLength != 0 && newWidth != 0)
                {
                    Length = newLength;
                    Width = newWidth;
                }
                
            }
        }

        class Book
        {
            public string Title;
            public string AuthorFirstName;
            public string AuthorLastName;
            public string ID;
            public string Publisher;
            public int CopiesSold;
            public void Sell(int numberSold)
            {
                CopiesSold = CopiesSold + numberSold;
            }
            public void Print()
            {
                Console.WriteLine($"\n{Title}");
                Console.WriteLine($"Written by {AuthorFirstName} {AuthorLastName}");
                Console.WriteLine($"Book ID: {ID}");
                Console.WriteLine($"Published by: {Publisher}");
                Console.WriteLine(String.Format($"Copies Sold: {CopiesSold:n0}"));
            }

        }
        static void Main(string[] args)
        {
            //======================= Parallelogram =======================

            Parallelogram p1 = new Parallelogram() { Length = 8, Width = 10 };
            
            //Print out manually
            Console.WriteLine("Manually printing Parallelogram p1 (8Length x 10Width) properties and methods:");
            Console.WriteLine($"Length: {p1.Length}");
            Console.WriteLine($"Width: {p1.Width}");
            Console.WriteLine($"Area: {p1.GetArea()}");
            Console.WriteLine($"Perimeter: {p1.GetPerimeter()}");
            //Print via method for comparison.
            Console.WriteLine("\nAnd output via the Print Method:");
            p1.Print();
            Console.WriteLine("\nResizing to 80 x 100 and calling Print()");
            p1.Resize(80, 100);
            p1.Print();
            

            //========================== Books ============================
            Console.WriteLine();
            Console.WriteLine();
            

            Book book1 = new Book()
            {
                Title = "Time Travel for Dummies",
                AuthorFirstName = "Emmett \"Doc\"",
                AuthorLastName = "Brown",
                ID = "OCT26.1985:0121",
                Publisher = "Great Scott Books",
                CopiesSold = 1000000000
            };
            book1.Print();
            Console.WriteLine("\nSell 250,000,000 more copies");
            book1.Sell(250000000);
            book1.Print();

            Book book2 = new Book()
            {
                Title = "Learn C# in one day and Learn it Well",
                AuthorFirstName = "Jamie",
                AuthorLastName = "Chan",
                ID = "9781518800276",
                Publisher = "CreateSpace Independent Publishing Platform",
                CopiesSold = 20000
            };
            book2.Sell(1);
            book2.Print();

            Book book3 = new Book();
            book3.Title = "The Hobbit";
            book3.AuthorFirstName = "J.R.R.";
            book3.AuthorLastName = "Tolkien";
            book3.ID = "0618968636";
            book3.Publisher = "George Allen & Unwin Ltd. of London";
            book3.CopiesSold = 50000000;

            book3.Print();
            Console.WriteLine("Sell 50 million more copies");
            book3.Sell(50000000);
            book3.Print();
        }
    }
}
