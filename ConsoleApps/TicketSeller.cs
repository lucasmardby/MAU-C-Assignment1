namespace ConsoleApps
{
    //Task 2: TicketSeller class
    internal class TicketSeller
    {
        //declaring fields for user input and prize calculations
        private string name = null!;
        private double price = 100;
        private double childDiscount = 0.25;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        //method executed in Program.cs
        public void TicketSellerStart()
        {
            Console.Clear();
            Console.WriteLine("Welcome to KIDS' FUN FAIR!\nChildren always get a 75% discount!");

            ReadInput();
            CalculateAmountToPay();
            ShowResults();

            HelperMethods.ConfirmationButton();
        }

        private void ReadInput()
        {
            //get name and number of adults/children
            Console.WriteLine();
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
            Console.WriteLine("Number of adults:");
            numOfAdults = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of children:");
            numOfChildren = Convert.ToInt32(Console.ReadLine());
        }

        private void CalculateAmountToPay()
        {
            /*calculate ticket prize based on number of guests
              100 per ticket, with a 75% discount for children*/
            amountToPay = (price * numOfAdults) + (numOfChildren * (price * childDiscount));
        }

        private void ShowResults()
        {
            Console.WriteLine(" +++ Your receipt +++");
            Console.WriteLine($" +++ Amount to pay = {amountToPay}");
            Console.WriteLine($" +++ Price per ticket = {price}");
            Console.WriteLine();
            Console.WriteLine($" +++ Thank you {name} and please come back! +++");
        }
    }
}
