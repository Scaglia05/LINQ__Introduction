using LINQ.Models;

namespace LINQ {
    public class SingleESingleOrDefault {
        public static void Executar() {

            var songs = new List<Songs> {
                new Songs(id: 1, name: "Californication", band: "Red Hot Chili Peppers", new DateTime(year: 1999, month: 6, day: 8)),
                new Songs(id: 2, name: "Hotel California", band: "Eagles", new DateTime(year: 1977, month: 2, day: 22)),
                new Songs(id: 3, name: "November Rain", band: "Guns N' Roses", new DateTime(year: 1992, month: 2, day: 18)),
                new Songs(id: 4, name: "A Little Piece of Heaven", band: "Avenged Sevenfold", new DateTime(year: 2007, month: 10, day: 30)),
                new Songs(id: 5, name: "Wait and Bleed", band: "Slipknot", new DateTime(year: 1999, month: 7, day: 28))
            };

            Console.WriteLine("\nSingle");
            Console.Write("Enter song Id: ");
            var singleResp = Console.ReadLine();
            if (int.TryParse(singleResp, out int singleId)) {
                try {
                    var singleResult = (from song in songs
                                        where song.Id == singleId
                                        select song).Single();
                    Console.WriteLine($"Id: {singleResult.Id} | Name: {singleResult.Name} | Band: {singleResult.Band} | Released: {singleResult.ReleaseDate.ToShortDateString()}");
                } catch (InvalidOperationException) {
                    Console.WriteLine("Song not found or multiple songs found with the same Id.");
                }
            } else {
                Console.WriteLine("Invalid input. Please enter a valid numeric Id.");
            }

            // SingleOrDefault
            Console.WriteLine("\nSingleOrDefault");
            Console.Write("Enter song Id: ");
            var singleOrDefaultResp = Console.ReadLine();
            if (int.TryParse(singleOrDefaultResp, out int singleOrDefaultId)) {
                var singleOrDefaultResult = (from song in songs
                                             where song.Id == singleOrDefaultId
                                             select song).SingleOrDefault();
                if (singleOrDefaultResult != null) {
                    Console.WriteLine($"Id: {singleOrDefaultResult.Id} | Name: {singleOrDefaultResult.Name} | Band: {singleOrDefaultResult.Band} | Released: {singleOrDefaultResult.ReleaseDate.ToShortDateString()}");
                } else {
                    Console.WriteLine("Song not found.");
                }
            } else {
                Console.WriteLine("Invalid input. Please enter a valid numeric Id.");
            }
        }
    }

}