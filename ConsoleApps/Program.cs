namespace ConsoleApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var petObj = new Pet();
            petObj.PetStart();

            var ticketObj = new TicketSeller();
            ticketObj.TicketSellerStart();

            var albumObj = new Album();
            albumObj.AlbumStart();

            var bookObj = new Book();
            bookObj.BookStart();

        }
    }
}