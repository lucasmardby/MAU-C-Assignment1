namespace ConsoleApps
{
    internal class TicketSeller
    {
        private string name = null!;
        private double price = 100;
        private double childDiscount = 0.25;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public void TicketSellerStart()
        {
            Console.WriteLine("Welcome to LISEBERG!\nChildren always get a 25% discount!");

            ReadInput();
            CalculateAmountToPay();
            ShowResults();

            HelperMethods.ConfirmationButton();
        }

        private void ReadInput()
        {
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
