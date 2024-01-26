using System.Runtime.CompilerServices;

namespace ConsoleApps
{
    internal class Book
    {
        // fix the nullable ReadLine()
        private string title = null!;
        private string author = null!;
        private string genre = null!;
        private double numOfPages;

        private string readResult = null!;
        private bool validInput;

        public void BookStart()
        {
            Console.WriteLine("Hello, and welcome to the Book Class!");
            Console.WriteLine();

            BookTitle();
            BookAuthor();
            BookPageCount();
            BookGenre();

            HelperMethods.ConfirmationButton();
        }

        private void BookTitle()
        {
            Console.WriteLine("What is the name of your favourite fictional book?");
            title = Console.ReadLine();
        }

        private void BookAuthor()
        {
            Console.WriteLine($"Who is the author of {title}?");
            author = Console.ReadLine();
        }

        private void BookPageCount()
        {
            Console.WriteLine($"How many pages does {title} have?");
            numOfPages = Convert.ToDouble(Console.ReadLine());
            
            //Round the user input page number to the closest hundreds
            var pageMath = Math.Round(numOfPages / 100) * 100;

            switch (pageMath)
            {
                case < 100:
                    Console.WriteLine($"Only around {numOfPages}? Sounds like a fun, shorter book!");
                    break; 

                case < 300:
                    Console.WriteLine($"Oh, so it has around {pageMath}? Sounds great!");
                    break;

                case < 500:
                    Console.WriteLine($"Around {pageMath}, you say? Sounds perfect!");
                    break;

                case > 500:
                    Console.WriteLine($"It has around {pageMath}?? Sounds like a long book!");
                    break;
            }
        }

        private void BookGenre()
        {
            Console.WriteLine();
            Console.WriteLine($"How would you describe the genre of {title}?");
            Console.WriteLine("Enter a number to select the genre you think fits best!");
            Console.WriteLine("[1] Fantasy\n[2] Science Fiction\n[3] Mystery\n[4] Romance");
            do
            {
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                }
            } while (validInput == false);

            switch (Console.ReadLine())
            {
                case "1":
                {
                    return;
                }
            }

        }
    }
    //use switch for genres
}
