using LINQ.Models;

namespace LINQ {
    public class LastELastOrDefault {
        public static void Executar() {

            var songs = new List<Songs> {
                new Songs(id: 1, name: "Californication", band: "Red Hot Chili Peppers", new DateTime(year: 1999, month: 6, day: 8)),
                new Songs(id: 2, name: "Hotel California", band: "Eagles", new DateTime(year: 1977, month: 2, day: 22)),
                new Songs(id: 3, name: "November Rain", band: "Guns N' Roses", new DateTime(year: 1992, month: 2, day: 18)),
                new Songs(id: 4, name: "A Little Piece of Heaven", band: "Avenged Sevenfold", new DateTime(year: 2007, month: 10, day: 30)),
                new Songs(id: 5, name: "Wait and Bleed", band: "Slipknot", new DateTime(year: 1999, month: 7, day: 28))
            };

            Console.WriteLine("\nLast");
            var result = songs.Last();
            Console.WriteLine($"Id: {result.Id} | Name: {result.Name} | Band: {result.Band} | Released: {result.ReleaseDate}");

            Console.WriteLine("\nLastOrDefault");
            var Resp = Console.ReadLine();
            if (int.TryParse(Resp, out int songId)) {
                var resultLastOr = (from lastprod in songs
                                     where lastprod.Id == songId
                                     select lastprod).LastOrDefault();
                if (resultLastOr != null) {
                    Console.WriteLine($"Id: {resultLastOr.Id} | Name: {resultLastOr.Name} | Band: {resultLastOr.Band} | Released: {resultLastOr.ReleaseDate}");
                } else {
                    Console.WriteLine("Song not found.");
                }
            } else {
                Console.WriteLine("Invalid input. Please enter a valid numeric Id.");
            }
        }
    }

}