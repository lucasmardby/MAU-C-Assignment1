namespace ConsoleApps
{
    //Task 4: additional class for the higher grade
    internal class Book
    {
        //declaring my book fields to be user-filled
        private string title = null!;
        private string author = null!;
        private string genre = null!;
        private double numOfPages;
        private string bookLengthType = null!;

        //method executed in Program.cs
        public void BookStart()
        {
            Console.Clear();
            Console.WriteLine("Hello, and welcome to the Book Class!");
            Console.WriteLine();

            BookTitle();
            BookAuthor();
            BookPageCount();
            BookGenre();
            DisplayBookInfo();

            HelperMethods.ConfirmationButton();
        }

        //get user input for title, author, and page count
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

            //do-while loop to make sure user input is a valid number
            var validInput = false;
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    numOfPages = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number for the page count.");
                }
            } while (validInput == false);
            
            /* Task 5: Use the Math class
             Math.Round() to get the user-input page number to the closest hundreds,
             divide numOfPages by 100, Math.Round() to get rid of the decimal, and multiply by 100 to get the rounded result*/
            var pageMath = Math.Round(numOfPages / 100) * 100;

            switch (pageMath)
            {
                /*if the user input number is below 50, this use of Math.Round would turn 'pageMath' into 0
                 to catch this edge case, I have made sure that if the user enters a number below fifty,
                'numOfPages' will be printed, instead of the rounded number in 'pageMath' */
                case < 50:
                    Console.WriteLine($"Only around {numOfPages}? Sounds like a fun, shorter book!");
                    bookLengthType = "Short Story";
                    break; 

                case < 150:
                    Console.WriteLine($"Oh, so it has around {pageMath}? Great!");
                    bookLengthType = "Novella";
                    break;

                case <= 700:
                    Console.WriteLine($"Around {pageMath}, you say? Sounds perfect!");
                    bookLengthType = "Novel";
                    break;

                case > 700:
                    Console.WriteLine($"It has around {pageMath}?? Sounds like a long book!");
                    bookLengthType = "Epic";
                    break;
            }
        }

        private void BookGenre()
        {
            Console.WriteLine();
            Console.WriteLine($"How would you describe the genre of {title}?");
            Console.WriteLine("Enter a number to select the genre you think fits best!");
            Console.WriteLine("[1] Mystery\n[2] Romance\n[3] Adventure\n[4] Heist\n[5] Other (Enter your own).");

            string readResult;
            bool validInput = false;
            do
            {
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Try again. Enter a number to select a book genre.");
                }
            } while (validInput == false);

            switch (readResult)
            {
                case "1":
                    genre = "Mystery";
                    break;
                case "2":
                    genre = "Romance";
                    break;
                case "3":
                    genre = "Thriller";
                    break;
                case "4":
                    genre = "Horror";
                    break;
                case "5":
                    Console.WriteLine("Enter the genre of your book!");
                    genre = Console.ReadLine();
                    break;
            }

        }
        private void DisplayBookInfo()
        {
            /*display user input information:
              title, author, page count, selected or self-written genre, and type of book based on the entered page count*/

            Console.WriteLine();
            Console.WriteLine("------");
            Console.WriteLine("So, your favourite book is:");
            Console.WriteLine($"{title}, written by {author}");
            Console.WriteLine($"A {numOfPages} page long {genre.ToLower()} {bookLengthType.ToLower()}");
            Console.WriteLine("------");

            BookRecommendation();
        }
        private void BookRecommendation()
        {
            Console.WriteLine();
            Console.WriteLine("Based on your favourite book, may I recommend one of mine? (y/n)");

            //do-while loop to ask the user if the want a book recommendation, making sure they enter a valid yes or no
            string readResult;
            bool validInput;
            bool wantsRecommendation = false;
            do
            {
                readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    validInput = true;
                    wantsRecommendation = true;
                }
                else if (readResult == "n")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. (y/n)");
                    validInput = false;
                }
            } while (validInput == false);

            //if 'yes' is entered, a switch case gives a book recommendation based on the entered genre or page count
            bool defaultGenre = false;
            if (wantsRecommendation == true)
            {
                switch (genre)
                { 
                    case "Mystery":
                        Console.WriteLine($"I would recommend the fantasy {genre.ToLower()} novel:");
                        Console.WriteLine("'Lies of Locke Lamora', written by Scott Lynch!");
                        break;
                    case "Romance":
                        Console.WriteLine($"I would recommend the fantasy {genre.ToLower()} novel:");
                        Console.WriteLine("'Tress of the Emerald Sea', written by Brandon Sanderson!");
                        break;
                    case "Adventure":
                        Console.WriteLine($"I would recommend the fantasy {genre.ToLower()} novel:");
                        Console.WriteLine("'Kings of the Wyld', written by Nicholas Eames!");
                        break;
                    case "Heist":
                        Console.WriteLine($"I would recommend the fantasy {genre.ToLower()} novel:");
                        Console.WriteLine("'Mistborn', written by Brandon Sanderson!");
                        break;
                    default:
                        defaultGenre = true;
                        break;
                }
                //if another genre was input by the user, the BookRecommendation() recommends based on page count instead
                if (defaultGenre == true)
                {
                    switch (numOfPages)
                    {
                        case < 450:
                            Console.WriteLine($"I would recommend the fantasy mystery novel:");
                            Console.WriteLine("'Mistborn', written by Brandon Sanderson!");
                            break;
                        case >= 450:
                            Console.WriteLine($"I would recommend the fantasy adventure novel:");
                            Console.WriteLine("'Name of the Wind', written by Patrick Rothfuss!");
                            break;
                    }
                }
                Console.WriteLine("------");
                Console.WriteLine();
            }
        }
    }
}
