namespace ConsoleApps
{
    //Task 3: Album class
    internal class Album
    {
        private string albumName = null!;
        private string artistName = null!;
        private int numOfTracks;

        public void AlbumStart()
        {
            Console.Clear();
            Console.WriteLine("Starting the Album program!");
            Console.WriteLine();

            ReadAlbumName();
            ReadArtistName();
            ReadTracks();
            DisplayAlbumInfo();

            HelperMethods.ConfirmationButton();
        }

        private void ReadAlbumName()
        {
            Console.WriteLine("What is the name of your favourite music album?");
            albumName = Console.ReadLine();
        }
        private void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band of {albumName}?");
            artistName = Console.ReadLine();
        }
        private void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {albumName} have?");

            //do-while loop to make sure user input is a valid number
            var validInput = false;
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    numOfTracks = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number for the amount of tracks.");
                }
            } while (validInput == false);
        }
        private void DisplayAlbumInfo()
        {
            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of Tracks: {numOfTracks}");
            Console.WriteLine("Enjoy listening!");
        }
    }
}
