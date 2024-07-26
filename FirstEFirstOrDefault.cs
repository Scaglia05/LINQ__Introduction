using LINQ.Models;

namespace LINQ {
    public class FirstEFirstOrDefault {
        public static void Executar() {

            var songs = new List<Songs> {
                new Songs(id: 1, name: "Californication", band: "Red Hot Chili Peppers", new DateTime(year: 1999, month: 6, day: 8)),
                new Songs(id: 2, name: "Hotel California", band: "Eagles", new DateTime(year: 1977, month: 2, day: 22)),
                new Songs(id: 3, name: "November Rain", band: "Guns N' Roses", new DateTime(year: 1992, month: 2, day: 18)),
                new Songs(id: 4, name: "A Little Piece of Heaven", band: "Avenged Sevenfold", new DateTime(year: 2007, month: 10, day: 30)),
                new Songs(id: 5, name: "Wait and Bleed", band: "Slipknot", new DateTime(year: 1999, month: 7, day: 28))
            };

            Console.WriteLine("\nFirst");
            var result = songs.First();
            Console.WriteLine($"Id: {result.Id} | Name: {result.Name} | Band: {result.Band} | Released: {result.ReleaseDate}");

            Console.WriteLine("\nFirstOrDefault");
            var Resp = Console.ReadLine();
            if (int.TryParse(Resp, out int songId)) {
                var resultFirstOr = (from firstprod in songs
                                     where firstprod.Id == songId
                                     select firstprod).FirstOrDefault();
                if (resultFirstOr != null) {
                    Console.WriteLine($"Id: {resultFirstOr.Id} | Name: {resultFirstOr.Name} | Band: {resultFirstOr.Band} | Released: {resultFirstOr.ReleaseDate}");
                } else {
                    Console.WriteLine("Song not found.");
                }
            } else {
                Console.WriteLine("Invalid input. Please enter a valid numeric Id.");
            }
        }
    }

}