namespace ConsoleApps
{
    //Assignment 1: Console Application, by Lucas Mårdby
    internal class Program
    {
        static void Main(string[] args)
        {
            var readResult = "";
            var exitProgram = false;

            //Application "Main Menu", to make easier to select and return back to a class
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Assignment 1, made by Lucas Mårdby");
                Console.WriteLine();
                Console.WriteLine("Pick a number to enter one of my classes!");
                Console.WriteLine("[1] Pet Class\n[2] TicketSeller Class\n[3] Album Class\n[4] Book Class (My own class),");
                Console.WriteLine("Or type 'Exit' to exit the application.");
                Console.WriteLine();

                //Switch case into the different classes
                readResult = Console.ReadLine();
                switch (readResult.ToLower())
                {
                    case "1":
                        var petObj = new Pet();
                        petObj.PetStart();
                        break;

                    case "2":
                        var ticketObj = new TicketSeller();
                        ticketObj.TicketSellerStart();
                        break;

                    case "3":
                        var albumObj = new Album();
                        albumObj.AlbumStart();
                        break;

                    case "4":
                        var bookObj = new Book();
                        bookObj.BookStart();
                        break;

                    case "exit":
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine("Please try again!");
                        HelperMethods.ConfirmationButton();
                        Console.Clear();
                        break;
                }

            } while (exitProgram == false);
            

            

            

            

        }
    }
}