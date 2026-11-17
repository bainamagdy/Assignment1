using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Assignment1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region q01, q02
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it
            Console.WriteLine("Hello, World!");
            object s1 = new Book { name = "bookName1", pages = 10 };
            Book s2 = new Book { name = "bookName2", pages = 20 };
            //Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1.GetType());
            #endregion


            #region q03
            //Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            //int pages = "464"; complie time error (syntax error)
            int pages = 464;
            #endregion

            #region q04
            //Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block

            try
            {
                var num1 = 10;
                var num2 = 0;
                Console.WriteLine(num1 / num2);


            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");


            }
            catch
            {
                Console.WriteLine("the other ex");

            }
            finally
            {
                Console.WriteLine("Done");

            }
            #endregion

            #region q05
            //Q05. Declare an int pages = 300; then store it in a double variable without using a cast.

            int pages2 = 300;
            double pages3 = pages;
            Console.WriteLine(pages3.GetType());

            #endregion

            #region q06
            //Q06. Declare a double price = 49.99; then convert it into an int using a cast.

            double price = 49.99;
            int price2 = (int)price;
            #endregion

            #region q07
            //Q07. Given string pagesText = "464";, convert it into an int using the Convert class.


            string pagesText = "464";
            int pagesNum = Convert.ToInt32(pagesText);
            #endregion

            #region q08
            //Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string yearText = "2023";
            int yearNum = int.Parse(yearText);
            string badText = "abc";
            bool result = int.TryParse(badText, out var x);
            if (!result)
                Console.WriteLine("Invalid number");
            #endregion

            #region q09
            //Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            //to prove it's now a string.

            int p = 464;
            string pText = p.ToString();
            Console.WriteLine(pText.GetType());
            #endregion

            #region q10
            //Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both
            int copies = 100;
            object copiesOb = copies; //boxing into object |implicit 
            int copiesUnBoxed = (int)copiesOb;  //Unboxing it  | explicit 

            Console.WriteLine(copies);
            Console.WriteLine(copiesOb);
            Console.WriteLine(copiesUnBoxed);

            #endregion

            #region q11
            //Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            int? year = null;
            var res = year.HasValue ? $"it is has value {year}" : "it hasn't value";
            Console.WriteLine(res);
            year = 2023;
            Console.WriteLine(year);


            #endregion


            #region q12
            //Q12. Declare a string? reviewer = null;. Print whether it is null.

            string? reviewer = null;
            var res2 = reviewer == null ? "it is null" : "it is not null"; //answer 1
            Console.WriteLine(res2);

            if (reviewer == null)
            {
                Console.WriteLine("it is null");
            }
            else
            {
                Console.WriteLine("it is not null");
            } //answer 2 
            #endregion

            #region q13
            //Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
            //print the result
            Book? book = null;
            string? title = book?.title;
            Console.WriteLine(title);
            #endregion

            #region q14
            //Q14. Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to
            //assign title the value "Untitled" only if it's still null.
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);

            #endregion

            #region q15
            //Q15. Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
            // confirmedName using the ! operator.
            string? name = "Ahmed";
            string name2 = name!;
            #endregion






        }

        public class Book
        {
            public string name;
            public int pages;
            public string title;
            public override string ToString()
            {
                return $"Name is : {name},pages are {pages}";
            }


        }

    }
}
